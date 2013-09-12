using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManage.Model
{
    /// <summary>
    /// 实体类ReaderType
    /// </summary>
    public class ReaderType
    {
        public ReaderType() { }

        #region   用户属性定义
        private int _RdType;              // user type
        private string _RdTypeName;       // user type name
        private int _CanLendQty;         
        private int _CanLendDay;
        private int _CanContinueTimes;         // lend times
        private float _PunishRate;        
        private int _DateAvailab;           // available period
        #endregion

        #region   用户属性 get set
        public int RdType
        {
            get { return _RdType; }
            set { _RdType = value; }
        }
        public string RdTypeName
        {
            get { return _RdTypeName; }
            set { _RdTypeName = value; }
        }
        public int CanLendQty
        {
            get { return _CanLendQty; }
            set { _CanLendQty = value; }
        }
        public int CanLendDay
        {
            get { return _CanLendDay; }
            set { _CanLendDay = value; }
        }
        public int CanContinueTimes
        {
            get { return _CanContinueTimes; }
            set { _CanContinueTimes = value; }
        }
        public float PunishRate
        {
            get { return _PunishRate; }
            set { _PunishRate = value; }
        }
        public int DateAvailab
        {
            get { return _DateAvailab; }
            set { _DateAvailab = value; }
        }
        #endregion

        #region 用户属性　构造函数

        public ReaderType(ReaderType rt)
        {
            this.RdType = rt.RdType;
            this.RdTypeName = rt.RdTypeName;
            this.CanLendQty = rt.CanLendQty;
            this.CanLendDay = rt.CanLendDay;
            this.CanContinueTimes = rt.CanContinueTimes;
            this.PunishRate = rt.PunishRate;
            this.DateAvailab = rt.DateAvailab;
        }
        #endregion

        #region 返回BMS_ReaderType表中字段名
        //返回BMS_Reader表中字段名
        public static string ColumnTitle(string columnName)
        {
            string sTitle;
            sTitle = columnName;
            switch (columnName)
            {
                case "RdType": sTitle = "用户类别"; break;
                case "RdTypeName": sTitle = "类别名称"; break;
                case "CanLendQty": sTitle = "可借书数量"; break;
                case "CanLendDay": sTitle = "可借书天数"; break;
                case "CanContinueTimes": sTitle = "可续借次数"; break;
                case "PunishRate": sTitle = "罚款率"; break;
                case "DateAvailab": sTitle = "证件有效期"; break;
            }
            return sTitle;
        }
        #endregion
    }
}
