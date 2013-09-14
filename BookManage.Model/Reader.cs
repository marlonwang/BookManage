using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    /// <summary>
    /// Reader 
    /// </summary>
    public class Reader
    {
        public Reader() { }

        #region 读者属性

        public int RdID { get; set; }
        public string RdName { get; set; }
        public string RdSex { get; set; }
        public int RdType { get; set; }
        public string RdDepart { get; set; }
        public string RdPhone { get; set; }
        public string RdEmail { get; set; }
        public DateTime RdDateReg { get; set; }
        public Byte[] RdPhotoImg { get; set; }    // img path
        public string RdStatus { get; set; }
        public int RdBorrowQty { get; set; }
        public string RdPwd { get; set; }
        public int RdAdminRoles { get; set; }

        #endregion

        #region 读者类新判断
        //判断读者类型
        public bool IsReaderAdmin()
        {
            return ((RdAdminRoles & 1) > 0);
        }
        public bool IsBookAdmin()
        {
            return ((RdAdminRoles & 2) > 0);
        }
        public bool IsBorrowAdmin()
        {
            return ((RdAdminRoles & 4) > 0);
        }
        public bool IsSystemAdmin()
        {
            return ((RdAdminRoles & 8) > 0);
        }

        #endregion

        #region 返回表字段名
        //返回BMS_Reader表中字段名
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "RdID": sTitle = "借书证号"; break;
                case "RdName": sTitle = "姓名";break;
                case "RdSex": sTitle = "性别"; break;
                case "RdType": sTitle = "读者类别"; break;
                case "RdDepart": sTitle = "单位"; break;
                case "RdPhone": sTitle = "电话"; break;
                case "RdEmail": sTitle = "邮箱"; break;
                case "RdDateReg": sTitle = "办证日期"; break;
                case "RdPhotoImg": sTitle = "照片"; break;
                case "RdStatus": sTitle = "证件状态"; break;
                case "RdBorrowQty": sTitle = "已借书"; break;
                case "RdPwd": sTitle = "密码"; break;
                case "RdAdminRoles": sTitle = "管理员角色"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
