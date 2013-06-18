using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.DAL;
using BookManage.Model;

namespace BookManage.BLL
{
    public class ReaderTypeBLL
    {
        //返回　读者类型表 BMS_ReaderType 全部结构
        public DataTable GetAllReaderType()
        {
            return (ReaderTypeDAL.GetAll());
        }

        //根据RdType 返回ReaderType
        public ReaderType GetReaderType(int RdType)
        {
            return (DAL.ReaderTypeDAL.GetObjectByID(RdType));
        }

        //添加　读者类型
        public int InsertType(ReaderType rdtype)
        {
            return (ReaderTypeDAL.Add(rdtype));
        }

        //删除　读者类型
        public int DeleteType(ReaderType rdtype)
        {
            return (ReaderTypeDAL.Delete(rdtype));
        }

        //修改　读者类型
        public int UpdateType(ReaderType rdtype)
        {
            return (ReaderTypeDAL.Update(rdtype));
        }
    }
}
