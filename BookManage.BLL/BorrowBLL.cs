using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class BorrowBLL
    {
        private Borrow borrow;
        public BorrowBLL()
        {
            if (borrow== null)
            {
                borrow = new Borrow();
            }
        }

        //借书表结构
        public DataTable GetBorrowStructure()
        {
            return (BorrowDAL.GetBorrowStruct());
        }

        //用户的借书信息
        public DataTable GetReaderBorrow(int RDID)
        {
            return (BorrowDAL.GetBorrowbook(RDID));
        }

        //根据borrowid 返回借书信息
        public Borrow GetBorrowByid(decimal BORROWID)
        {
            return (BorrowDAL.GetObjectByID(BORROWID));
        }

        //用户类型表　相关借书量和罚款率
        public DataTable GetReaderType(int RdType)
        {
            return (BorrowDAL.GetReaderType(RdType));
        }

        //查询时　修改罚款情况
        public int UpdateMoney(int ldOverDay, float ldOverMoney, float ldPunishMoney,int borrowID)
        {
            return (BorrowDAL.UpdateMoney(ldOverDay, ldOverMoney, ldPunishMoney,borrowID));
        }

        //用户借书
        public bool BookBorrow(int rdID, int bookID, string OptorName)
        {
            //借书成功标记
            bool success = false;
            if (BorrowDAL.IsBorrowing(rdID, bookID) == 0)
            {
                BorrowDAL.BorrowBook(rdID, bookID, OptorName);
                success = true;
            }
            else
            {
                success = false;
            }
            return success;
        }
        
        //用户还书
        public int BookReturn(int rdID, int bookID, string OptorName)
        {
            return BorrowDAL.ReturnBook(rdID, bookID, OptorName);
        }

        //用户续借
        public int BookReborrow(int rdID, int bookID, string OptorName)
        {
            return BorrowDAL.BorrowAgin(rdID, bookID, OptorName);
        }
    }
}
