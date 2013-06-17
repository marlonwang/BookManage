using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.DAL;
using BookManage.Model;

namespace BookManage.BLL
{
    public class ReaderBLL
    {
        private Reader reader;
        public ReaderBLL()
        {
            if (reader == null)
            {
                reader = new Reader();
            }
        }

        //根据rdID 返回reader
        public Reader GetReader(int rdID)
        {
            return (DAL.ReaderDAL.GetObjectByID(rdID));
        }

        public DataTable GetReader(int rdType, string rdDept, string rdName)
        {
            return (ReaderDAL.GetReader(rdType, rdDept, rdName));
        }

        //GetAllReaderType
        public DataTable GetAllReaderType()
        {
            return (ReaderTypeDAL.GetAll());
        }
        //添加读者
        public int InsertReader(Reader reader)
        {
            return (ReaderDAL.Add(reader));//返回受影响行数
        }
        //变更读者
        public int UpdateReader(Reader reader)
        {
            return (ReaderDAL.Update(reader));//返回受影响行数
        }

        //changerank
        public int ChangeRank(int RdID, int RdType)
        {
            return (ReaderDAL.ChangeRank(RdID, RdType));
        }
        //
        public int ChangePwd(int RdID, string RdPwd)
        {
            return (ReaderDAL.ChangePwd(RdID, RdPwd));
        }
    }
}
