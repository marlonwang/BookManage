using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BookManage.Model;

namespace BookManage.DAL
{
    public class BorrowDAL
    {
		//BMS_Borrow表中插改由存储过程实现
		//以下方法未用
        //insert
        public static int Add(Borrow borrow)
        {
            int rows = 0;
            string sql = "insert into BMS_Borrow(borrowID,rdID,bkID,ldContinueTimes,ldDateOut,ldDateRetPlan,ldDateRetAct,ldOverDay,ldOverMoney,ldPunishMoney,ldHasReturn,OperatorLend,OperatorRetn)"
                + "values (@borrowID,@rdID,@bkID,@ldContinueTimes,@ldDateOut,@ldDateRetPlan,@ldDateRetAct,@ldOverDay,@ldOverMoney,@ldPunishMoney,@ldHasReturn,@OperatorLend,@OperatorRetn)";
            SqlParameter[] parameters ={
                                          new SqlParameter("@borrowID",borrow.borrowID),
                                          new SqlParameter("@rdID",borrow.rdID),
                                          new SqlParameter("@bkID",borrow.bkID),
                                          new SqlParameter("@ldContinueTimes",borrow.ldContinueTimes),
                                          new SqlParameter("@ldDateOut",borrow.ldDateOut),
                                          new SqlParameter("@ldDateRetPlan",borrow.ldDateRetPlan),
                                          new SqlParameter("@ldDateRetAct",borrow.ldDateRetAct),
                                          new SqlParameter("@ldOverDay",borrow.ldOverDay),
                                          new SqlParameter("@ldOverMoney",borrow.ldOverMoney),
                                          new SqlParameter("@ldPunishMoney",borrow.ldPunishMoney),
                                          new SqlParameter("@ldHasReturn",borrow.ldHasReturn),
                                          new SqlParameter("@OperatorLend",borrow.OperatorLend),
                                          new SqlParameter("@OperatorRetn",borrow.OperatorRetn)
                                      };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        //Delete
        public static int Delete(Borrow borrow)
        {
            int rows = 0;
            string sql = "delete from BMS_Borrow where borrowID=@borrowID";
            SqlParameter[] parameters ={
                                         new SqlParameter("@borrowID",borrow.borrowID)
                                     };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        //update
        public static int Update(Borrow borrow)
        {
            int rows = 0;
            string sql="update BMS_Borrow set "
                + "rdID=@rdID,"
                + "bkID=@bkID,"
                + "ldContinueTimes=@ldContinueTimes,"
                + "ldDateOut=@ldDateOut,"
                + "ldDateRetPlan=@ldDateRetPlan,"
                + "ldDateRetAct=@ldDateRetAct,"
                + "ldOverDay=@ldOverDay,"
                + "ldOverMoney=@ldOverMoney,"
                + "ldPunishMoney=@ldPunishMoney,"
                + "ldHasReturn=@ldHasReturn,"
                + "OperatorLend=@OperatorLend,"
                + "OperatorRetn=@OperatorRetn "
                + "where borrowID=@borrowID";
            SqlParameter[] parameters ={
                                          new SqlParameter("@borrowID",borrow.borrowID), 
                                          new SqlParameter("@rdID",borrow.rdID),
                                          new SqlParameter("@bkID",borrow.bkID),
                                          new SqlParameter("@ldContinueTimes",borrow.ldContinueTimes),
                                          new SqlParameter("@ldDateOut",borrow.ldDateOut),
                                          new SqlParameter("@ldDateRetPlan",borrow.ldDateRetPlan),
                                          new SqlParameter("@ldDateRetAct",borrow.ldDateRetAct),
                                          new SqlParameter("@ldOverDay",borrow.ldOverDay),
                                          new SqlParameter("@ldOverMoney",borrow.ldOverMoney),
                                          new SqlParameter("@ldPunishMoney",borrow.ldPunishMoney),
                                          new SqlParameter("@ldHasReturn",borrow.ldHasReturn),
                                          new SqlParameter("@OperatorLend",borrow.OperatorLend),
                                          new SqlParameter("@OperatorRetn",borrow.OperatorRetn)
                                    };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }

        public static int UpdateMoney(int ldOverDay,float ldOverMoney,float ldPunishMoney,int borrowID)
        {
            int rows = 0;
            string sql = "update BMS_Borrow set "
                + "ldOverDay=@ldOverDay,"
                + "ldOverMoney=@ldOverMoney,"
                + "ldPunishMoney=@ldPunishMoney "
                + "where borrowID=@borrowID";
            SqlParameter[] parameters ={  
                                          new SqlParameter("@ldOverDay",ldOverDay),
                                          new SqlParameter("@ldOverMoney",ldOverMoney),
                                          new SqlParameter("@ldPunishMoney",ldPunishMoney),
                                          new SqlParameter("@borrowID",borrowID)
                                    };
            try
            {
                rows = SqlHelper.ExecuteNonQuery(sql, parameters);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return rows;
        }
     
        #region 返回图书表结构
        //返回结束表的表结构
        public static DataTable GetBorrowStruct()
        {
            string sql = "select * from BMS_Borrow where 0=1";
            return SqlHelper.GetDataTable(sql, null, "BMS_Borrow");
        }
        #endregion 

        #region 根据读者ID 返回读者借书表
        //借书表
        public static DataTable GetBorrowbook(int rdID)
        {
            string sql = "select * from BMS_Borrow where rdID=@rdID ";
            SqlParameter[] parameters ={
                                          new SqlParameter("@rdID",rdID)
                                      };
            return SqlHelper.GetDataTable(sql, parameters, "BMS_Borrow");
        }
        #endregion

        #region 根据借书ID 返回借书表
        //借书表
        public static DataRow GetBorrowByID(decimal borrowID)
        {
            string sql = "select borrowID,rdID,bkID,ldContinueTimes,ldDateOut,ldDateRetPlan,"
                       +"ldOverDay,ldOverMoney,ldPunishMoney,ldHasReturn,OperatorLend,OperatorRetn"
                       +" from BMS_Borrow where borrowID=@borrowID and ldHasReturn=0";

            SqlParameter[] parameters ={
                                          new SqlParameter("@borrowID",borrowID)
                                      };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "BMS_Borrow");
            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
                return dr;
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }

        public static Borrow GetObjectByID(decimal borrowID)
        {
            DataRow dr = GetBorrowByID(borrowID);
            return SqlHelper.DataRowToT<Borrow>(dr);
        }
        #endregion

        //是否续借过
        public static int IsBorrowing(int rdID, int bkID)
        {
            int row = 0;
            string sql = "select * from BMS_Borrow where bkID=@bkID and rdID=@rdID and ldContinueTimes > 0";
            SqlParameter[] parameters ={
                                       new SqlParameter("@rdID",rdID),
                                       new SqlParameter("@bkID",bkID)
                                      };
            try
            {
                row = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, parameters)); //返回select 受影响的行数
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return row;
        }

        //读者类型表 罚款率
        public static DataTable GetReaderType(int RdType)
        {
            string sql = "select * from BMS_ReaderType where RdType=@RdType";
            SqlParameter[] parameters = { new SqlParameter("@RdType", RdType) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "BMS_ReaderType");
            return dt;
        }

        //借书
        public static int BorrowBook(int rdID,int bookID,string Operator)
        {
            int row = 0;
            SqlParameter[] parameters={
                                          new SqlParameter("@readerid",rdID),
                                          new SqlParameter("@book2borrow",bookID),
                                          new SqlParameter("@operator",Operator)
                                      };
            try
            {
                row = SqlHelper.ExecuteStoredProc("BookBorrow",parameters);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return row;
        }

        //还书
        public static int ReturnBook(int rdID,int bookID,string Operator)
        {
            int row=0;
            SqlParameter[] parameters ={
                                          new SqlParameter("@readerid",rdID),
                                          new SqlParameter("@book2return",bookID),
                                          new SqlParameter("@operator",Operator)
                                      };
            try
            {
                row = SqlHelper.ExecuteStoredProc("BookReturn", parameters);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return row;

            //@readerid int , @book2return int,@operator nvarchar(20)
        }

        //续借
        public static int BorrowAgin(int rdID, int bookID, string Operator)
        {
            int row = 0;
            SqlParameter[] parameters ={
                                          new SqlParameter("@readerid",rdID),
                                          new SqlParameter("@book2continue",bookID),
                                          new SqlParameter("@operator",Operator)
                                      };
            try
            {
                row = SqlHelper.ExecuteStoredProc("BookContinue", parameters);
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return row;
            //@readerid int , @book2continue int,@operator nvarchar(20)
        }

    }
}
