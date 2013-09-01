using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BookManage.Model;

namespace BookManage.DAL
{
    public class BookDAL
    {
        //insert
        public static int Add(Book book)
        {
            int rows = 0;
            string sql = "insert into BMS_Book (bkCode,bkName,bkAuthor,bkPress,bkDatePress,bkISBN,bkCatalog,bkLanguage,bkPages,bkPrice,bkBriefCont,bkCover,bkInTime,bkNums,bkStatus)"
                + "values (@bkCode,@bkName,@bkAuthor,@bkPress,@bkDatePress,@bkISBN,@bkCatalog,@bkLanguage,@bkPages,@bkPrice,@bkBriefCont,@bkCover,@bkInTime,@bkNums,@bkStatus)";
            SqlParameter[] parameters ={
                                         
                                          new SqlParameter("@bkCode",book.bkCode),
                                          new SqlParameter("@bkName",book.bkName),
                                          new SqlParameter("@bkAuthor",book.bkAuthor),
                                          new SqlParameter("@bkPress",book.bkPress),
                                          new SqlParameter("@bkDatePress",book.bkDatePress),
                                          new SqlParameter("@bkISBN",book.bkISBN),
                                          new SqlParameter("@bkCatalog",book.bkCatalog),
                                          new SqlParameter("@bkLanguage",book.bkLanguage),
                                          new SqlParameter("@bkPages",book.bkPages),
                                          new SqlParameter("@bkPrice",book.bkPrice),
                                          new SqlParameter("@bkBriefCont",book.bkBriefCont),
                                          new SqlParameter("@bkCover",book.bkCover),
                                          new SqlParameter("@bkInTime",book.bkInTime),
                                          new SqlParameter("@bkNums",book.bkNums),
                                          new SqlParameter("@bkStatus",book.bkStatus)
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
        //是否允许删除？？　理论上不可删
        //delete
        public static int Delete(Book book)
        {
            int rows = 0;
            string sql = "delete from BMS_Book where bkID=@bkID";
            SqlParameter[] parameters ={
                                          new SqlParameter("@bkID",book.bkID)
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
        public static int Update(Book book)
        {
            int rows = 0;
            string sql = "update BMS_Book set "
                + "bkCode=@bkCode,"
                + "bkName=@bkName,"
                + "bkAuthor=@bkAuthor,"
                + "bkPress=@bkPress,"
                + "bkDatePress=@bkDatePress,"
                + "bkISBN=@bkISBN,"
                + "bkCatalog=@bkCatalog,"
                + "bkLanguage=@bkLanguage,"
                + "bkPages=@bkPages,"
                + "bkPrice=@bkPrice,"
                + "bkBriefCont=@bkBriefCont,"
                + "bkCover=@bkCover,"
                + "bkInTime=@bkInTime,"
                + "bkNums=@bkNums,"
                + "bkStatus=@bkStatus "
                + "where bkID=@bkID";
            SqlParameter[] parameters ={
                                          new SqlParameter("@bkCode",book.bkCode),
                                          new SqlParameter("@bkName",book.bkName),
                                          new SqlParameter("@bkAuthor",book.bkAuthor),
                                          new SqlParameter("@bkPress",book.bkPress),
                                          new SqlParameter("@bkDatePress",book.bkDatePress),
                                          new SqlParameter("@bkISBN",book.bkISBN),
                                          new SqlParameter("@bkCatalog",book.bkCatalog),
                                          new SqlParameter("@bkLanguage",book.bkLanguage),
                                          new SqlParameter("@bkPages",book.bkPages),
                                          new SqlParameter("@bkPrice",book.bkPrice),
                                          new SqlParameter("@bkBriefCont",book.bkBriefCont),
                                          new SqlParameter("@bkCover",book.bkCover),
                                          new SqlParameter("@bkInTime",book.bkInTime),
                                          new SqlParameter("@bkNums",book.bkNums),
                                          new SqlParameter("@bkStatus",book.bkStatus),
                                          new SqlParameter("@bkID",book.bkID)
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


        #region GetDRByID
        ///<summary>
        ///由读者类型ID(bkID)得到读者类型信息 返回DataRow
        ///<summary>
        ///<returns>Datarow</returns>
        public static DataRow GetDRByID(int bkID)
        {
            string sql = "select * from BMS_Book where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", bkID) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "BMS_Book");
            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
                return dr;
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }

        public static Book GetObjectByID(int bkID)
        {
            DataRow dr = GetDRByID(bkID);
            return SqlHelper.DataRowToT<Book>(dr);
            //????
        }
        #endregion

        #region 根据bkID返回DataTable
        public static DataTable ReturnBookByID(int bkID)
        {
            string sql = "select * from BMS_Book where bkID=@bkID";
            SqlParameter[] parameters = { new SqlParameter("@bkID", bkID) };
            return SqlHelper.GetDataTable(sql, parameters, "BMS_Book");
        }
        #endregion 

        #region 返回图书表结构

        public static DataTable GetBookStruct()
        {
            string sql = "select * from BMS_Book where 0=1";
            return SqlHelper.GetDataTable(sql, null, "BMS_Book");
        }
        #endregion 

        #region 返回所有图书
        public static DataTable GetAllBook()
        {
            string sql = "select * from BMS_Book ";
            return SqlHelper.GetDataTable(sql, null, "BMS_Book");
        }
        #endregion

        #region 查询指定图书
        /*
        public static DataTable GetBook(string bkCode, string bkName, string bkAuthor, string bkPress,
            DateTime bkDatePress, string bkISBN, string bkCatalog, DateTime bkInDate)
        */
        public static DataTable GetBook(string bkCode, string bkName, string bkAuthor, string bkPress,
            string bkISBN, string bkCatalog)
        {
            string sql;
            bkCode = (bkCode == "") ? ("%") : ("%" + bkCode + "%");
            bkName = (bkName == "") ? ("%") : ("%" + bkName + "%");
            bkAuthor = (bkAuthor == "") ? ("%") : ("%" + bkAuthor + "%");
            bkPress = (bkPress == "") ? ("%") : ("%" + bkPress + "%");
            //bkDatePress = (bkDatePress.ToLongDateString().ToString() == "") ? ("%") : ("%" + bkDatePress + "%");
            bkISBN = (bkISBN == "") ? ("%") : ("%" + bkISBN + "%");
            bkCatalog = (bkCatalog == "") ? ("%") : ("%" + bkCatalog + "%");
            //bkInDate = (bkInDate.ToLongDateString().ToString() == "") ? ("%") : ("%" + bkInDate + "%");
            
            //以该模糊方式查询　　包括模糊和非模糊情况

            sql = "select * from BMS_Book where bkCode like @bkCode and bkName like @bkName and bkAuthor like @bkAuthor and bkPress like @bkPress and bkISBN like @bkISBN and bkCatalog like @bkCatalog";   
                //+ "bkDatePress like @bkDatePress and "
                //+ "bkInDate like @bkInDate";
            SqlParameter[] parameters ={
                                          new SqlParameter("@bkCode",bkCode),
                                          new SqlParameter("@bkName",bkName),
                                          new SqlParameter("@bkAuthor",bkAuthor),
                                          new SqlParameter("@bkPress",bkPress),
                                          //new SqlParameter("@bkDatePress",bkDatePress),
                                          new SqlParameter("@bkISBN",bkISBN),
                                          new SqlParameter("@bkCatalog",bkCatalog)
                                          //new SqlParameter("@bkInDate",bkInDate)
                                      };
            return SqlHelper.GetDataTable(sql, parameters, "BMS_Book");
          
        }
        #endregion
    }
}
