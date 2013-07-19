using System;
using System.Data;
using System.Data.SqlClient;
using BookManage.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.DAL
{
    public class ReaderTypeDAL
    {
        public static int Add(ReaderType readertype)
        {
            int rows = 0;
            string sql = "insert into BMS_ReaderType(RdType,RdTypeName,CanLendQty,CanLendDay,CanContinueTimes,PunishRate,DateAvailab)" +
                "values (@RdType,@RdTypeName,@CanLendQty,@CanLendDay,@CanContinueTimes,@PunishRate,@DateAvailab)";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdType",readertype.RdType),
                                          new SqlParameter("@RdTypeName",readertype.RdTypeName),
                                          new SqlParameter("@CanLendQty",readertype.CanLendQty),
                                          new SqlParameter("@CanLendDay",readertype.CanLendDay),
                                          new SqlParameter("@CanContinueTimes",readertype.CanContinueTimes),
                                          new SqlParameter("@PunishRate",readertype.PunishRate),
                                          new SqlParameter("@DateAvailab",readertype.DateAvailab)
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

        public static int Delete(ReaderType readertype)
        {
            int rows = 0;
            string sql = "delete from BMS_ReaderType where RdType=@RdType";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdType",readertype.RdType)
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

        public static int Update(ReaderType readertype)
        {
            int rows = 0;
            string sql = "update BMS_ReaderType set "
                + "RdTypeName=@RdTypeName,"
                + "CanLendQty=@CanLendQty,"
                + "CanLendDay=@CanLendDay,"
                + "CanContinueTimes=@CanContinueTimes,"
                + "PunishRate=@PunishRate,"
                + "DateAvailab=@DateAvailab "
                + "where RdType=@RdType";
            SqlParameter[] parameters ={
                                          new SqlParameter("@RdTypeName",readertype.RdTypeName),
                                          new SqlParameter("@CanLendQty",readertype.CanLendQty),
                                          new SqlParameter("@CanLendDay",readertype.CanLendDay),
                                          new SqlParameter("@CanContinueTimes",readertype.CanContinueTimes),
                                          new SqlParameter("@PunishRate",readertype.PunishRate),
                                          new SqlParameter("@DateAvailab",readertype.DateAvailab),
                                          new SqlParameter("@RdType",readertype.RdType)
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
        ///由读者类型ID(RdType)得到读者类型信息 返回DataRow
        ///<summary>
        ///<returns>Datarow</returns>
        public static DataRow GetDRByID(int RdType)
        {
            string sql = "select * from BMS_ReaderType where RdType=@RdType";
            SqlParameter[] parameters = { new SqlParameter("@RdType", RdType) };
            DataTable dt = null;
            dt = SqlHelper.GetDataTable(sql, parameters, "BMS_ReaderType");
            DataRow dr = null;
            if (dt == null || dt.Rows.Count == 0)
                return dr;
            else
            {
                dr = dt.Rows[0];
                return dr;
            }
        }

        public static ReaderType GetObjectByID(int RdType)
        {
            DataRow dr = GetDRByID(RdType);
            return SqlHelper.DataRowToT<ReaderType>(dr);
            //????
        }
        //GetAllReaderType()
        public static DataTable GetAll()
        {
            string sql = "select * from BMS_ReaderType";
            return SqlHelper.GetDataTable(sql, null, "BMS_ReaderType");
        }
    }
}
