using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{

    /// <summary>
    /// Borrow
    /// </summary>
    public class Borrow
    {
        public Borrow() { }

        #region 借书表属性

        public long borrowID { get; set; }
        public int rdID { get; set; }
        public int bkID { get; set; }
        public int ldContinueTimes { get; set; }
        public DateTime ldDateOut { get; set; }
        public DateTime ldDateRetPlan { get; set; }
        public DateTime ldDateRetAct { get; set; }
        public int ldOverDay { get; set; }
        public float ldOverMoney { get; set; }
        public float ldPunishMoney { get; set; }
        public bool ldHasReturn { get; set; }
        public string OperatorLend { get; set; }
        public string OperatorRetn { get; set; }

        #endregion

        #region 返回BMS_Book表中字段名
        //返回BMS_Book表中字段名
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "borrowID": sTitle = "借书序号"; break;
                case "rdID": sTitle = "读者序号"; break;
                case "bkID": sTitle = "图书序号"; break;
                case "ldContinueTimes": sTitle = "续借次数"; break;
                case "ldDateOut": sTitle = "借出日期"; break;
                case "ldDateRetPlan": sTitle = "应还日期"; break;
                case "ldDateRetAct": sTitle = "实还日期"; break;
                case "ldOverDay": sTitle = "逾期天数"; break;
                case "ldOverMoney": sTitle = "超期金额"; break;
                case "ldPunishMoney": sTitle = "罚款金额"; break;
                case "ldHasReturn": sTitle = "是否归还"; break;
                case "OperatorLend": sTitle = "借书操作员"; break;
                case "OperatorRetn": sTitle = "还书操作员"; break;
            }
            return sTitle;
        }

        #endregion
    }
}
