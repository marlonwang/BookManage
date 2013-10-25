using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.Model;
using BookManage.BLL;

namespace ViewMain
{
    public partial class TypeForm : Form
    {
        private DataTable dt = null;
        private ReaderType rdtype = new ReaderType();
        private ReaderTypeBLL rdtypebll = new ReaderTypeBLL();

        #region 初始化GridView列名

        public TypeForm()
        {
            InitializeComponent();
            dt = rdtypebll.GetAllReaderType();
            showTitle();
        }
        #endregion

        #region 显示数据到GridView
        public void showTitle()
        {
            dgvResult.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvResult.Columns[dc.ColumnName].HeaderText = ReaderType.ColumnTitle(dc.ColumnName);
            }
        }
        #endregion

        #region SetReaderTypeToText
        //读者类型属性　转　文本输入框内容
        private void SetReaderTypeToText()
        {
            txtBoxRT.Text = Convert.ToString(rdtype.RdType);
            txtBoxTypeName.Text = rdtype.RdTypeName;
            txtBoxQty.Text = rdtype.CanLendQty.ToString();
            txtBoxDays.Text = rdtype.CanLendDay.ToString();
            txtBoxPnRate.Text = rdtype.PunishRate.ToString();
            txtBoxCanTimes.Text = Convert.ToString(rdtype.CanContinueTimes);
            txtBoxValibDate.Text = Convert.ToString(rdtype.DateAvailab);
        }
        #endregion

        #region SetTextToReaderType
        //文本框内容转　RederType 的属性
        private void SetTextToReaderType()
        {
            rdtype.RdType = Convert.ToInt32(txtBoxRT.Text.Trim()); //smallint 与　int32 转换问题
            rdtype.RdTypeName = txtBoxTypeName.Text.Trim();
            rdtype.CanLendQty = Convert.ToInt32(txtBoxQty.Text.Trim());
            rdtype.CanLendDay = Convert.ToInt32(txtBoxDays.Text.Trim());
            rdtype.PunishRate = float.Parse(txtBoxPnRate.Text.Trim());  //转换小数点后位数 error
            rdtype.CanContinueTimes = Convert.ToInt32(txtBoxCanTimes.Text.Trim());
            rdtype.DateAvailab = Convert.ToInt32(txtBoxValibDate.Text.Trim()); //smallint
        }
        #endregion

        #region DataGridView行操作

        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResult.CurrentCell == null)
                return;
            rdtype = rdtypebll.GetReaderType((Int16)dgvResult["RdType", dgvResult.CurrentCell.RowIndex].Value);
            //smallint类型对应int16
            if (rdtype != null)
            {
                SetReaderTypeToText();
            }  
        }
        #endregion

        #region 添加读者类型
        //添加类型
        private void tsBtnAddRec_Click(object sender, EventArgs e)
        {
            if (txtBoxRT.Text == null || txtBoxTypeName.Text == null || txtBoxValibDate.Text == null)
            {
                labReslt.Text = "类型信息　填写不全，请查证!!!";
            }
            else
            {
                SetTextToReaderType();
                if (rdtypebll.InsertType(rdtype) > 0)
                {
                    labReslt.Text = "^_^ 添加读者类型成功!";
                }
                else
                {
                    labReslt.Text = "#_# 添加读者类型失败!";
                }
            }

        }
        #endregion

        #region 返回到主窗体　BookForm.cs
        //返回
        private void tsBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }
        #endregion

        #region 删除类型

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxRT.Text != null)
            {
                SetTextToReaderType();
                if (rdtypebll.DeleteType(rdtype) > 0)
                    labReslt.Text = "^_^ 删除类型成功.";
                else
                    labReslt.Text = "#_# 删除类型失败!";
            }

            //当前索引自动移动  error
            //int indexid = dgvResult.CurrentRow.Index;
            //if (indexid < 0)
            //{ indexid = indexid + 1; }
            //if (indexid > dgvResult.Rows.Count - 1)
            //{ indexid = indexid - 1; }
            //dgvResult.CurrentCell = dgvResult.Rows[indexid].Cells[0];
        }
        #endregion

        #region 修改类型　类型ID不可变
        //修改类型
        private void tsBtnModify_Click(object sender, EventArgs e)
        {
            txtBoxRT.ReadOnly = true;
            if (txtBoxRT.Text != null)
            {
                SetTextToReaderType();
                if (rdtypebll.UpdateType(rdtype) > 0)
                    labReslt.Text = "^_^ 修改类型成功.";
                else
                    labReslt.Text = "#_# 修改类型失败!";
            }
        }
        #endregion

        #region 记录索引操作

        //尾条记录
        private void tsBtnLastRec_Click(object sender, EventArgs e)
        {
            int index = dgvResult.Rows.Count;
            dgvResult.CurrentCell = dgvResult.Rows[index-1].Cells[0];
        }

        //下一条记录
        private void tsBtnNextRec_Click(object sender, EventArgs e)
        {
            int index = dgvResult.CurrentRow.Index;
            if (++index < dgvResult.Rows.Count)
                dgvResult.CurrentCell=dgvResult.Rows[index].Cells[0];
        }

        //上一条记录
        private void tsBtnPreRec_Click(object sender, EventArgs e)
        {
            int index = dgvResult.CurrentRow.Index;
            if (--index >= 0)
                dgvResult.CurrentCell = dgvResult.Rows[index].Cells[0];
        }

        //第一条记录
        private void tsBtnFirstRec_Click(object sender, EventArgs e)
        {
            dgvResult.CurrentCell = dgvResult.Rows[0].Cells[0];
        }

        #endregion

        #region 刷新纪录表
        //刷新记录　
        private void tsBtnRefresh_Click(object sender, EventArgs e)
        {
            //刷新时　上次选中的类型信息被删　
            //SetReaderToText() 处TypeName尚未改变
            
            dt = rdtypebll.GetAllReaderType();
            showTitle();
        }
        #endregion 
    }
}
