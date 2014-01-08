--*********************************
--*********ͼ����Ϣ����*************
--DB name :BookMS
--author: alexwang252@gmail.com
--data:  2013-12-1 16:50
--*********************************

----step1  �������ݿ�
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

--step2    �����
--��������
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

--������Ϣ��
use BookMS
go
create table BMS_Reader
(
  RdID int not null primary key,
  RdName nvarchar(20),
  RdSex nchar(1) check(RdSex in ('��','Ů')),
  RdType smallint not null,
  RdDepart nvarchar(20),
  RdPhone nvarchar(25),
  RdEmail nvarchar(25),
  RdDateReg datetime default(getdate()),
  RdPhotoImg image,
  RdStatus nchar(2) check(RdStatus in ('��Ч','��ʧ','ע��')), 
  RdBorrowQty int,
  RdPwd nvarchar(20),
  RdAdminRoles smallint default (0),
  constraint FK_RdType foreign key (RdType) references BMS_ReaderType(RdType)
)
go

--ͼ����Ϣ��
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
  bkInTime datetime,   --�������ʱ��
  bkNums int,          --����ͼ�鱾��
  bkStatus nchar(2),
  constraint CK_language check(bkLanguage in (0,1,2,3,4,5)),
  constraint CK_status check(bkStatus in('�ڹ�','���','��ʧ','����','����'))
)

--ͼ����ı�
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
----step3  ����������
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

----step4  �����洢����
--����
--BLL �����ж� ��ǰ���Ƿ񱻱��������
use BookMS
go
create procedure BookBorrow --����id ������id ����Ա����
@readerid int , @book2borrow int,@operator nvarchar(20)
as
 begin
   set nocount off;
   if exists (select * from BMS_Reader where RdID=@readerid and RdStatus='��Ч') 
   begin        
	   if exists (select * from BMS_Book where bkID=@book2borrow and bkStatus='�ڹ�')
	   begin
		  declare @numall int, @numnow int, @bookleft int --�ɽ�����  �ѽ����� ʣ������
		  select @numall=BMS_ReaderType.CanLendQty 
			from BMS_ReaderType inner join BMS_Reader
			  on BMS_ReaderType.RdType=BMS_Reader.RdType and BMS_Reader.RdID=@readerid;
		  select @numnow=RdBorrowQty from BMS_Reader where RdID=@readerid;
		  if(@numnow<@numall)   --�ɽ�<�ѽ�
			begin transaction
				declare @errorsum int;
				set @errorsum=0;
				select @bookleft=bkNums from BMS_Book where bkID=@book2borrow; --����ʣ������
				if(@bookleft>0)
				  begin
					set @errorsum=@errorsum + @@error;  --����ͳ��
					update BMS_Reader set RdBorrowQty=@numnow+1 where RdID=@readerid;
					set @errorsum=@errorsum + @@error;
					insert into BMS_Borrow (rdID,bkID,ldContinueTimes,ldDateOut,ldDateRetPlan,
											ldHasReturn,OperatorLend)
									values (@readerid,@book2borrow,default,getdate(),dateadd(day,30,getdate()),0,@operator);
					--select DATEADD(day,30,GETDATE()) ��ǰʱ���ϼ�30��
					set @errorsum=@errorsum + @@error;
					update BMS_Book set bkNums=@bookleft-1 where bkID=@book2borrow;
					set @errorsum=@errorsum + @@error;
					if(@bookleft-1 = 0) --ʣ������Ϊ0
						update BMS_Book set bkStatus='���' where bkID=@book2borrow;--ʣ����Ϊ0ʱ ���
					set @errorsum=@errorsum + @@error;
                  end
			if (@errorSum = 0)
				commit transaction;
			else 
				rollback transaction;
			 
	   end
   end
end            
    
--����
use BookMS
go 
create procedure BookReturn           --�������id ����id ������Ա
@readerid int , @book2return int,@operator nvarchar(20)
as 
begin 
   set nocount off;
   if exists (select * from BMS_Reader where RdID=@readerid and RdStatus='��Ч') 
    begin 
      if exists (select * from BMS_Book where bkID=@book2return)
       begin 
         declare @numnow int, @bookleft int --�ѽ����� ʣ������ 
         select @numnow=RdBorrowQty from BMS_Reader where RdID=@readerid;
         select @bookleft=bkNums from BMS_Book where bkID=@book2return; --����ʣ������
         if exists (select * from BMS_Borrow where bkID=@book2return and rdID=@readerid) --������Ƿ���ڵ�ǰδ����¼
           begin transaction
             declare @errorsum int;
			 set @errorsum=0;
             if(@numnow>0) --�������� >0 ʱ ������ �ѽ�������
               begin
                 update BMS_Reader set RdBorrowQty=@numnow-1 where RdID=@readerid;
                 set @errorsum=@errorsum + @@error;
                 update BMS_Book set bkNums=@bookleft+1 where bkID=@book2return;
                 set @errorsum=@errorsum + @@error;
                 if(@bookleft=0)
                 update BMS_Book set bkStatus='�ڹ�' where bkID=@book2return;
                 set @errorsum=@errorsum + @@error;       --����ʱ ���巣�� ���ڷ����0
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
     
--����
use BookMS 
go
create procedure BookContinue              --����id ������id �������Ա 
@readerid int , @book2continue int,@operator nvarchar(20)
as 
begin
  set nocount off;
   if exists (select * from BMS_Reader where RdID=@readerid and RdStatus='��Ч') 
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
              --������߿��������
              select @xujietimes=CanContinueTimes from BMS_ReaderType inner join
                                 BMS_Reader on BMS_Reader.RdType=BMS_ReaderType.RdType
                                 and BMS_Reader.RdID=@readerid; 
              --��ǰͼ���ѽ���� ���� 0
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
values (10,'��ʦ',12,60,2,0.05,0);
insert into BMS_ReaderType
values (20,'������',8,30,1,0.05,4);
insert into BMS_ReaderType
values (21,'ר����',8,30,1,0.05,3);
insert into BMS_ReaderType
values (30,'˶ʿ�о���',8,30,1,0.05,3);
insert into BMS_ReaderType
values (31,'��ʿ�о���',8,30,1,0.05,4);
go

use BookMS
go
insert into BMS_Reader
values
( 10001,'���ٻ�','��',10,'�������ѧѧԺ','13507218421',
  'lsh@yangtzeu.edu.cn',default,null,'��Ч',2,'123456',
  0
)
go
--------------------------------------------------
--------------------------------------------------
use BookMS
go
insert into BMS_Reader
values
( 10002,'��С��','��',20,'����ѧԺ','13207160716',
  'zxw@yangtzeu.edu.cn',default,null,'��Ч',0,'666666',
  1
)
go

insert into BMS_Reader
values
( 10003,'��С��','��',21,'������ϢѧԺ','13507160000',
  'cx2@qq.com',default,null,'��Ч',1,'666666',
  2
)
go

insert into BMS_Reader
values
( 10004,'��СѾ','Ů',30,'��ѧԺ','13500000000',
  'wxy@sina.com',default,null,'��Ч',3,'666666',
  4
)
go

insert into BMS_Reader
values
( 10005,'��С��','Ů',31,'���ʹ�ϵѧԺ','13600001111',
  'xiaoqiao@163.com',default,null,'��Ч',5,'666666',
  15
)
go
--------------------------------------------------------

--------------------------------------------------------
use BookMS
go
insert into BMS_Book
values 
       (10000,'TP368.1-524','MCS-51��Ƭ��ԭ����Ӧ��','���ɷ�',
        '�廪��ѧ������','2008-6-1 4:00:00','978-7-302-16959',
        '�����Ӳ��',0,411,38.00,
        '������MCS-51ϵ�е�Ƭ��Ϊ��������,����΢�ͻ��Ļ�������,�ں˽ṹ,����ԭ��',
        null,getdate(),2,'�ڹ�')
go

select * from BMS_Book
select * from BMS_Reader

--�ѽ�ͼ��
use BookMS
go
insert into BMS_Borrow 
values
(10005,10000,1,'2013-11-20 13:00:00','2013-12-20 13:00:00',null,0,0,0,0,'��СѾ',null)
go

--ִ�д洢����
exec BookBorrow 10001,10000,'��С��'
exec BookReturn 10001,10003,'��С��'
exec BookContinue 10001,10003,'��С��'



