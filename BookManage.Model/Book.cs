using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    /// <summary>
    /// Book
    /// </summary>
    public class Book
    {
        public Book() { }

        #region 图书属性
        public int bkID { get; set; }
        public string bkCode { get; set; }
        public string bkName { get; set; }
        public string bkAuthor { get; set; }
        public string bkPress { get; set; }
        public DateTime bkDatePress { get; set; }
        public string bkISBN { get; set; }
        public string bkCatalog { get; set; }
        public int bkLanguage { get; set; }
        public int bkPages { get; set; }
        public float bkPrice { get; set; }
        public string bkBriefCont { get; set; }
        public Byte[] bkCover { get; set; }
        public DateTime bkInTime { get; set; }
        public int bkNums { get; set; }
        public string bkStatus { get; set; }

        #endregion

        #region 返回BMS_Book表中字段名
        //返回BMS_Book表中字段名
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "bkID": sTitle = "图书序号"; break;
                case "bkCode": sTitle = "图书编号"; break;
                case "bkName": sTitle = "图书名称"; break;
                case "bkAuthor": sTitle = "图书作者"; break;
                case "bkPress": sTitle = "出版社名"; break;
                case "bkDatePress": sTitle = "出版日期"; break;
                case "bkISBN": sTitle = "ISBN"; break;
                case "bkCatalog": sTitle = "图书分类"; break;
                case "bkLanguage": sTitle = "图书语种"; break;
                case "bkPages": sTitle = "图书页数"; break;
                case "bkPrice": sTitle = "图书价格"; break;
                case "bkBriefCont": sTitle = "内容简介"; break;
                case "bkCover": sTitle = "图书封面"; break;
                case "bkInTime": sTitle = "入馆时间"; break;
                case "bkNums": sTitle = "图书本数"; break;
                case "bkStatus": sTitle = "借阅状态"; break;
            }
            return sTitle;
        }

        #endregion 
    }
}
