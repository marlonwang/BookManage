using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BookManage.Model;

namespace BookManage.DAL
{
    public class ReaderDAL
    {
        //insert into db
        public static int Add(Reader reader)
        {
            int rows = 0;
            string sql = "insert into BMS_Reader(RdID,RdName,RdSex,RdType,RdDepart,RdPhone,RdEmail,RdDateReg,RdPhotoImg,RdStatus,RdBorrowQty,RdPwd,RdAdminRoles)" +
                "values (@RdID,@RdName,@RdSex,@RdType,@RdDepart,@RdPhone,@RdEmail,@RdDateReg,@RdPhotoImg,@RdStatus,@RdBorrowQty,@RdPwd,@RdAdminRoles)";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdID",reader.RdID),
                                          new SqlParameter("@RdName",reader.RdName),
                                          new SqlParameter("@RdSex",reader.RdSex),
                                          new SqlParameter("@RdType",reader.RdType),
                                          new SqlParameter("@RdDepart",reader.RdDepart),
                                          new SqlParameter("@RdPhone",reader.RdPhone),
                                          new SqlParameter("@RdEmail",reader.RdEmail),
                                          new SqlParameter("@RdDateReg",reader.RdDateReg),
                                          new SqlParameter("@RdPhotoImg",reader.RdPhotoImg),
                                          new SqlParameter("@RdStatus",reader.RdStatus),
                                          new SqlParameter("@RdBorrowQty",reader.RdBorrowQty),
                                          new SqlParameter("@RdPwd",reader.RdPwd),
                                          new SqlParameter("@RdAdminRoles",reader.RdAdminRoles)
                                   
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
        //update set
        public static int Update(Reader reader)
        {
            int rows = 0;
            string sql = "update BMS_Reader set "
                + "RdName=@RdName,"
                + "RdSex=@RdSex,"
                + "RdType=@RdType,"
                + "RdDepart=@RdDepart,"
                + "RdPhone=@RdPhone,"
                + "RdEmail=@RdEmail,"
                + "RdDateReg=@RdDateReg,"
                + "RdPhotoImg=@RdPhotoImg,"
                + "RdStatus=@RdStatus,"
                + "RdBorrowQty=@RdBorrowQty,"
                + "RdPwd=@RdPwd,"
                + "RdAdminRoles=@RdAdminRoles "
                + "where RdID=@RdID";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdName",reader.RdName),
                                          new SqlParameter("@RdSex",reader.RdSex),
                                          new SqlParameter("@RdType",reader.RdType),
                                          new SqlParameter("@RdDepart",reader.RdDepart),
                                          new SqlParameter("@RdPhone",reader.RdPhone),
                                          new SqlParameter("@RdEmail",reader.RdEmail),
                                          new SqlParameter("@RdDateReg",reader.RdDateReg),
                                          new SqlParameter("@RdPhotoImg",reader.RdPhotoImg),
                                          new SqlParameter("@RdStatus",reader.RdStatus),
                                          new SqlParameter("@RdBorrowQty",reader.RdBorrowQty),
                                          new SqlParameter("@RdPwd",reader.RdPwd),
                                          new SqlParameter("@RdAdminRoles",reader.RdAdminRoles),
                                          new SqlParameter("@RdID",reader.RdID)
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
        //delete table
        public static int Delete(Reader reader)
        {
            int rows = 0;
            string sql = "delete from BMS_Reader where RdID=@RdID";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdID",reader.RdID)
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
        //修改密码
        public static int ChangePwd(int RdID, string RdPwd)
        {
            int rows = 0;
            string sql = "update BMS_Reader set RdPwd=@RdPwd where RdID=@RdID ";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdID",RdID),
                                          new SqlParameter("@RdPwd",RdPwd)
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
        //更改权限
        public static int ChangeRank(int RdID, int RdType)
        {
            int rows = 0;
            string sql = "update BMS_Reader set RdType=@RdType where RdID=@RdID ";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdID",RdID),
                                          new SqlParameter("@RdType",RdType)
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

        ///<summary>
        ///由读者类型ID(RdID)得到读者类型信息 返回DataRow
        ///<summary>
        ///<returns>Datarow</returns>
        public static DataRow GetDRByID(int RdID)
        {
            string sql = "select * from BMS_Reader where RdID=@RdID";
            SqlParameter[] parameters = { new SqlParameter("@RdID", RdID) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "BMS_Reader");
            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
                return dr;
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }
        //reader
        public static Reader GetObjectByID(int RdID)
        {
            DataRow dr = GetDRByID(RdID);
            return SqlHelper.DataRowToT<Reader>(dr);
        }

        //GetAll()
        public static DataTable GetAll()
        {
            string sql = "select * from BMS_ReaderType";
            return SqlHelper.GetDataTable(sql, null, "BMS_ReaderType");
        }

        //GetReader()
        public static DataTable GetReader(int rdType, string rdDept, string rdName)
        {
            string sql;
            if (rdType <= 0 && rdDept == "" && rdName == "")
            {
                sql = "select * from BMS_Reader where 0=1";//??无结果返回
                return SqlHelper.GetDataTable(sql, null, "BMS_Reader");
            }
            rdDept = (rdDept == "") ? ("%") : ("%" + rdDept + "%");
            rdName = (rdName == "") ? ("%") : ("%" + rdName + "%");
            if (rdType <= 0)
            {
                sql = "select * from BMS_Reader where RdDepart like @rdDept and RdName like @rdName";
                SqlParameter[] parameters ={
                                              new SqlParameter("@rdDept",rdDept),
                                              new SqlParameter("@rdName",rdName)
                                          };
                return SqlHelper.GetDataTable(sql, parameters, "BMS_Reader");
            }
            else
            {
                sql = "select * from BMS_Reader where RdType=@rdType and RdDepart like @rdDept and RdName like @rdName";
                SqlParameter[] parameters ={
                                              new SqlParameter("@rdType",rdType),
                                              new SqlParameter("@rdDept",rdDept),
                                              new SqlParameter("@rdName",rdName)
                                          };
                return SqlHelper.GetDataTable(sql, parameters, "BMS_Reader");
            }
        }
        
    }
}
