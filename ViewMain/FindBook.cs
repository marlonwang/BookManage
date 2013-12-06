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
    public partial class FindBook : Form
    {
        public static Book book = new Book();
        private BookBLL bookbll = new BookBLL();
        private DataTable dt = null;
        public static bool isModify = false;

        public FindBook()
        {
            InitializeComponent();
            dt = bookbll.GetBookStructure();//查询空记录
            ShowData();                     ///得到图书表结构
        }

        #region 显示数据到GridView
        //ShowData()
        private void ShowData()
        {
            dgvResult.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvResult.Columns[dc.ColumnName].HeaderText = Book.ColumnTitle(dc.ColumnName);
            }
        }
        #endregion

        #region 浏览所有图书
        //返回BMS_Book表所有记录 
        private void tsBtnScanAll_Click(object sender, EventArgs e)
        {
            dt = bookbll.GetAllBooks();
            if (dt != null)
            {
                ShowData();
            }
        }
        #endregion

        #region 返回
        //返回上一级目录　退出当前窗口
        private void tsBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 

        #region 查询　
        //查询书籍
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string bookName = txtBoxName.Text;
            string bookCode = txtBoxCode.Text.Trim();
            string bookAuthor = txtBoxAuthor.Text;
            string bookPress = txtBoxPress.Text;
            string bookClass = txtBoxClass.Text;
            string bookISBN = txtBoxISBN.Text;
            DateTime bookPressDate = dtpPublishDate.Value;
            DateTime bookInDate = dtpInDate.Value;

            dt = bookbll.GetBook(bookCode, bookName, bookAuthor, bookPress, bookISBN, bookClass);
            if (dt != null)
            {
                ShowData();
                if (dgvResult.Rows.Count <= 0)
                {
                    MessageBox.Show("未找到符合条件的图书.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("未找到符合条件的图书.", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region DataGridView行操作
        private void dgvResult_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResult.CurrentCell == null)
                return;
            book = bookbll.GetBook((Int32)dgvResult["bkID", dgvResult.CurrentCell.RowIndex].Value);
           
        }
        #endregion

        #region 修改
        //修改图书
        private void tsBtnModify_Click(object sender, EventArgs e)
        {
            isModify = true;
            if (book != null)
            {
                AddBook abook = new AddBook();
                this.Visible = true;
                abook.ShowDialog();
            }
        }
        #endregion 

        #region 明细
        //图书明细
        private void tsBtnSpecific_Click(object sender, EventArgs e)
        {
            isModify = true;
            if (book != null)
            {
                AddBook abook = new AddBook();
                this.Visible = true;
                abook.ShowDialog();
            }
        }
        #endregion 

        //生成报表
        private void tsBtnReport_Click(object sender, EventArgs e)
        {
            ReportForm rptfrm = new ReportForm();
            this.Visible = true;
            rptfrm.ShowDialog();
        }
    }
}
