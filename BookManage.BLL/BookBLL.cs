using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BookManage.Model;
using BookManage.DAL;

namespace BookManage.BLL
{
    public class BookBLL
    {
        private Book book;
        public BookBLL()
        {
            if (book== null)
            {
                book = new Book();
            }
        }
        
        //添加图书
        public int InsertBook(Book book)
        {
            return (BookDAL.Add(book));
        }

        //查出图书表结构
        public DataTable GetBookStructure()
        {
            return (BookDAL.GetBookStruct());
        } 

        //浏览所有图书
        public DataTable GetAllBooks()
        {
            return (BookDAL.GetAllBook());
        }

        //查询图书
        public DataTable GetBook(string bkCode, string bkName, string bkAuthor, string bkPress,
            string bkISBN, string bkCatalog)
        {
            return (BookDAL.GetBook(bkCode, bkName, bkAuthor, bkPress, bkISBN, bkCatalog));
        }
        //查询图书
        public Book GetBook(int bkID)
        {
            return (DAL.BookDAL.GetObjectByID(bkID));
        }

        //修改图书
        public int UpdateBook(Book book)
        {
            return (BookDAL.Update(book));
        }

        //根据bkID返回 Book DataTable
        public DataTable ReturnBookByID(int bkID)
        {
            return (BookDAL.ReturnBookByID(bkID));
        }

    }
}
