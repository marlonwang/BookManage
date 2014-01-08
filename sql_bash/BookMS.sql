--*********************************
--*********图书信息管理*************
--DB name :BookMS
--author: alexwang252@gmail.com
--data:  2013-12-1 16:50
--*********************************

----step1  创建数据库
use master 
go
if exists(select * from sysdatabases where name='BookMS') --sys.databases
drop database BookMS
go

create database BookMS
on primary
(name='BookMS',
 filename='c:\BookMS_DATA.MDF',
 size=5MB,
 maxsize=unlimited,
 filegrowth=10%)
 log on
(name='BookMS_Log',
 filename='c:\BookMS_LOG.LDF',
 size=5MB,
 maxsize=unlimited,
 filegrowth=5MB)
go  

--step2    表设计
--读者类别表
use BookMS
go
create table BMS_ReaderType
(
  RdType smallint not null primary key,
  RdTypeName nvarchar(20) not null unique,
  CanLendQty int ,
  CanLendDay int ,
  CanContinueTimes int ,
  PunishRate  float,
  DateAvailab smallint not null
)
go

--读者信息表
use BookMS
go
create table BMS_Reader
(
  RdID int not null primary key,
  RdName nvarchar(20),
  RdSex nchar(1) check(RdSex in ('男','女')),
  RdType smallint not null,
  RdDepart nvarchar(20),
  RdPhone nvarchar(25),
  RdEmail nvarchar(25),
  RdDateReg datetime default(getdate()),
  RdPhotoImg image,
  RdStatus nchar(2) check(RdStatus in ('有效','挂失','注销')), 
  RdBorrowQty int,
  RdPwd nvarchar(20),
  RdAdminRoles smallint default (0),
  constraint FK_RdType foreign key (RdType) references BMS_ReaderType(RdType)
)
go

--图书信息表
use BookMS
go
create table BMS_Book
(
  bkID int primary key,
  bkCode nvarchar(20),
  bkName nvarchar(50),
  bkAuthor nvarchar(30),
  bkPress nvarchar(50),
  bkDatePress datetime ,
  bkISBN nvarchar(15),
  bkCatalog nvarchar(30),
  bkLanguage smallint ,
  bkPages int,
  bkPrice money,
  bkBriefCont text,
  bkCover image,
  bkInTime datetime,   --新增入馆时间
  bkNums int,          --新增图书本数
  bkStatus nchar(2),
  constraint CK_language check(bkLanguage in (0,1,2,3,4,5)),
  constraint CK_status check(bkStatus in('在馆','借出','遗失','变卖','销毁'))
)

--图书借阅表
use BookMS
go
create table BMS_Borrow
(
  borrowID numeric(12,0) primary key,
  rdID int ,
  bkID int ,
  ldContinueTimes int default(0),
  ldDateOut datetime default(getdate()),
  ldDateRetPlan datetime,
  ldDateRetAct datetime,
  ldOverDay int,
  ldOverMoney money,
  ldPunishMoney money,
  ldHasReturn bit,
  OperatorLend nvarchar(20),
  OperatorRetn nvarchar(20),
  constraint FK_RdID foreign key (rdID) references BMS_Reader(RdID),
  constraint FK_bkID foreign key (bkID) references BMS_Book(bkID)
)
go

/*
----step3  创建触发器
--delete BMS_Reader
use BookMS
go
create trigger del_reader
on BMS_Reader
for delete
as
   print 'delete is not permitted here.'
   rollback

--delete BMS_Borrow
use BookMS
go 
create trigger del_borrow
on BMS_Borrow
for delete
as
   print 'delete is not permitted here.'
   rollback
*/

----step4  创建存储过程
--借书
--BLL 中再判断 当前书是否被本人续借过
use BookMS
go
create procedure BookBorrow --读者id 被借书id 操作员名字
@readerid int , @book2borrow int,@operator nvarchar(20)
as
 begin
   set nocount off;
   if exists (select * from BMS_Reader where RdID=@readerid and RdStatus='有效') 
   begin        
	   if exists (select * from BMS_Book where bkID=@book2borrow and bkStatus='在馆')
	   begin
		  declare @numall int, @numnow int, @bookleft int --可借数量  已借数量 剩书数量
		  select @numall=BMS_ReaderType.CanLendQty 
			from BMS_ReaderType inner join BMS_Reader
			  on BMS_ReaderType.RdType=BMS_Reader.RdType and BMS_Reader.RdID=@readerid;
		  select @numnow=RdBorrowQty from BMS_Reader where RdID=@readerid;
		  if(@numnow<@numall)   --可借<已借
			begin transaction
				declare @errorsum int;
				set @errorsum=0;
				select @bookleft=bkNums from BMS_Book where bkID=@book2borrow; --该书剩余数量
				if(@bookleft>0)
				  begin
					set @errorsum=@errorsum + @@error;  --错误统计
					update BMS_Reader set RdBorrowQty=@numnow+1 where RdID=@readerid;
					set @errorsum=@errorsum + @@error;
					insert into BMS_Borrow (rdID,bkID,ldContinueTimes,ldDateOut,ldDateRetPlan,
											ldHasReturn,OperatorLend)
									values (@readerid,@book2borrow,default,getdate(),dateadd(day,30,getdate()),0,@operator);
					--select DATEADD(day,30,GETDATE()) 当前时间上加30天
					set @errorsum=@errorsum + @@error;
					update BMS_Book set bkNums=@bookleft-1 where bkID=@book2borrow;
					set @errorsum=@errorsum + @@error;
					if(@bookleft-1 = 0) --剩余数量为0
						update BMS_Book set bkStatus='借出' where bkID=@book2borrow;--剩余量为0时 借出
					set @errorsum=@errorsum + @@error;
                  end
			if (@errorSum = 0)
				commit transaction;
			else 
				rollback transaction;
			 
	   end
   end
end            
    
--还书
use BookMS
go 
create procedure BookReturn           --还书读者id 还书id 操作人员
@readerid int , @book2return int,@operator nvarchar(20)
as 
begin 
   set nocount off;
   if exists (select * from BMS_Reader where RdID=@readerid and RdStatus='有效') 
    begin 
      if exists (select * from BMS_Book where bkID=@book2return)
       begin 
         declare @numnow int, @bookleft int --已借数量 剩书数量 
         select @numnow=RdBorrowQty from BMS_Reader where RdID=@readerid;
         select @bookleft=bkNums from BMS_Book where bkID=@book2return; --该书剩余数量
         if exists (select * from BMS_Borrow where bkID=@book2return and rdID=@readerid) --借书表是否存在当前未还记录
           begin transaction
             declare @errorsum int;
			 set @errorsum=0;
             if(@numnow>0) --借书数量 >0 时 才消减 已借书数量
               begin
                 update BMS_Reader set RdBorrowQty=@numnow-1 where RdID=@readerid;
                 set @errorsum=@errorsum + @@error;
                 update BMS_Book set bkNums=@bookleft+1 where bkID=@book2return;
                 set @errorsum=@errorsum + @@error;
                 if(@bookleft=0)
                 update BMS_Book set bkStatus='在馆' where bkID=@book2return;
                 set @errorsum=@errorsum + @@error;       --还书时 还清罚款 超期罚款归0
                 update BMS_Borrow set ldDateRetAct=getdate(),ldOverDay=0,
                                       ldOverMoney=0,ldPunishMoney=0,
                                       ldHasReturn=1,OperatorRetn=@operator,
                                       ldContinueTimes=0
                                   where bkID=@book2return and rdID=@readerid;
                 set @errorsum=@errorsum + @@error;
               end
           if (@errorsum = 0)
			   commit transaction;
		   else 
               rollback transaction;
       end 
     end
end
     
--续借
use BookMS 
go
create procedure BookContinue              --读者id 续借书id 续借操作员 
@readerid int , @book2continue int,@operator nvarchar(20)
as 
begin
  set nocount off;
   if exists (select * from BMS_Reader where RdID=@readerid and RdStatus='有效') 
    begin 
      if exists (select * from BMS_Book where bkID=@book2continue)
        begin
          if exists (select * from BMS_Borrow where bkID=@book2continue
                                                and  rdID=@readerid
                                                and ldHasReturn=0)
            begin 
              declare @beforelenday datetime, @xujietimes int,@nowxujie int
              select @beforelenday=ldDateOut from BMS_Borrow where bkID=@book2continue
                                                               and rdID=@readerid
                                                               and ldHasReturn=0;
              --该类读者可续借次数
              select @xujietimes=CanContinueTimes from BMS_ReaderType inner join
                                 BMS_Reader on BMS_Reader.RdType=BMS_ReaderType.RdType
                                 and BMS_Reader.RdID=@readerid; 
              --当前图书已借次数 初借 0
              select @nowxujie=ldContinueTimes from BMS_Borrow where bkID=@book2continue
                                                                  and rdID=@readerid
                                                                  and ldHasReturn=0;
              if(@nowxujie<@xujietimes)
                begin transaction
                  declare @errorsum int;
                  set @errorsum=0 ;
                  update BMS_Borrow set ldDateRetPlan=dateadd(day,30,@beforelenday),
                                        OperatorLend=@operator,
                                        ldContinueTimes=@nowxujie+1
                                    where bkID=@book2continue
                                      and rdID=@readerid
                                      and ldHasReturn=0;
                  set @errorsum=@errorsum + @@error;                  
            
              if(@errorsum = 0)
			      commit transaction;
		      else 
                  rollback transaction;
           end
        end
    end
end

/**********test**********
************************/  
use BookMS
go
insert into BMS_ReaderType
values (10,'教师',12,60,2,0.05,0);
insert into BMS_ReaderType
values (20,'本科生',8,30,1,0.05,4);
insert into BMS_ReaderType
values (21,'专科生',8,30,1,0.05,3);
insert into BMS_ReaderType
values (30,'硕士研究生',8,30,1,0.05,3);
insert into BMS_ReaderType
values (31,'博士研究生',8,30,1,0.05,4);
go

use BookMS
go
insert into BMS_Reader
values
( 10001,'梁少华','男',10,'计算机科学学院','13507218421',
  'lsh@yangtzeu.edu.cn',default,null,'有效',2,'123456',
  0
)
go
--------------------------------------------------
--------------------------------------------------
use BookMS
go
insert into BMS_Reader
values
( 10002,'张小五','男',20,'经济学院','13207160716',
  'zxw@yangtzeu.edu.cn',default,null,'有效',0,'666666',
  1
)
go

insert into BMS_Reader
values
( 10003,'陈小二','男',21,'电子信息学院','13507160000',
  'cx2@qq.com',default,null,'有效',1,'666666',
  2
)
go

insert into BMS_Reader
values
( 10004,'王小丫','女',30,'文学院','13500000000',
  'wxy@sina.com',default,null,'有效',3,'666666',
  4
)
go

insert into BMS_Reader
values
( 10005,'周小乔','女',31,'国际关系学院','13600001111',
  'xiaoqiao@163.com',default,null,'有效',5,'666666',
  15
)
go
--------------------------------------------------------

--------------------------------------------------------
use BookMS
go
insert into BMS_Book
values 
       (10000,'TP368.1-524','MCS-51单片机原理与应用','潘松峰',
        '清华大学出版社','2008-6-1 4:00:00','978-7-302-16959',
        '计算机硬件',0,411,38.00,
        '本书以MCS-51系列单片机为基本内容,介绍微型机的基本概念,内核结构,工作原理',
        null,getdate(),2,'在馆')
go

select * from BMS_Book
select * from BMS_Reader

--已借图书
use BookMS
go
insert into BMS_Borrow 
values
(10005,10000,1,'2013-11-20 13:00:00','2013-12-20 13:00:00',null,0,0,0,0,'王小丫',null)
go

--执行存储过程
exec BookBorrow 10001,10000,'周小乔'
exec BookReturn 10001,10003,'周小乔'
exec BookContinue 10001,10003,'张小五'



