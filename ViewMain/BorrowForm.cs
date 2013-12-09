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
    public partial class BorrowForm : Form
    {
        #region Initialize
        private Borrow borrow = new Borrow();
        private BorrowBLL borrowbll = new BorrowBLL();

        private Reader reader = new Reader();
        private ReaderBLL readerbll = new ReaderBLL();

        private Book book = new Book();
        private BookBLL bookbll = new BookBLL();

        private ReaderType rdtype = new ReaderType();
        private ReaderTypeBLL rdtypebll = new ReaderTypeBLL();

        private DataTable dt = null;

        public BorrowForm()
        {
            InitializeComponent();
            //操作人员
            labOpraName.Text = BMSLogin.reader.RdName.ToString();
            //当前日期
            labNowTime.Text = DateTime.Now.ToLongDateString().ToString();
            //显示图书表结构
            dt = bookbll.GetBookStructure();
            ShowDataBook();
            //显示借书表结构
            dt = borrowbll.GetBorrowStructure();
            ShowDataBorrow();
        }
        #endregion

        #region 显示图书数据到GridView
        //ShowDataBook()
        private void ShowDataBook()
        {
            dgvBook.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvBook.Columns[dc.ColumnName].HeaderText = Book.ColumnTitle(dc.ColumnName);
            }
        }
        #endregion

        #region 显示借书数据到GridView
        //ShowDataBorrow
        private void ShowDataBorrow()
        {
            dgvLBook.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvLBook.Columns[dc.ColumnName].HeaderText = Borrow.ColumnTitle(dc.ColumnName);
            }
        }
        #endregion

        #region 查询读者
        //查询读者
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBoxUSID.Text != "")
            {
                int RDTYPE=0; //用户类型 16

                reader.RdID = Convert.ToInt32(txtBoxUSID.Text.Trim());
                if (reader.RdID > 0)
                {
                    reader = readerbll.GetReader(reader.RdID);
                    txtBoxUSID.Text = reader.RdID.ToString();
                    txtBoxUName.Text = reader.RdName;
                    txtBoxUsDep.Text = reader.RdDepart;
                    txtBoxLended.Text = reader.RdBorrowQty.ToString();
                    RDTYPE = reader.RdType; 
                }
                if (RDTYPE > 0)
                {
                    rdtype=rdtypebll.GetReaderType(Convert.ToInt16(RDTYPE));
                    txtBoxCanDay.Text = rdtype.CanLendDay.ToString();
                    txtBoxCanum.Text = rdtype.CanLendQty.ToString();
                    //用户类型
                    txtBoxUsType.Text = rdtype.RdType.ToString() + "--" + rdtype.RdTypeName;

                    //更新　过期罚款信息
                    PunishInfo();
                    ViewLendedBook();//显示已借图书表
                }
                else
                {
                    MessageBox.Show("抱歉，没找到指定人员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //显示当前读者借书情况 只显示借书未还的
            if (reader != null)
            {
                dt = borrowbll.GetReaderBorrow(reader.RdID);
                dgvLBook.DataSource = dt;
                ShowDataBorrow();
            }
        }
        #endregion

        #region 查询图书
        //查询图书
        private void btnBookFind_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == "" && txtBoxIndex.Text == "")
            {
                 MessageBox.Show("图书序号或图书名称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBoxIndex.Text != "")
            {
                int bookid = Convert.ToInt32(txtBoxIndex.Text.Trim()); //bkID int
                if (bookid > 0)
                {
                    dt = bookbll.ReturnBookByID(bookid);
                    dgvBook.DataSource = dt;
                    ShowDataBook(); 
                }
            }
            else if(txtBoxName.Text!="")
            {
                dt = bookbll.GetBook("", txtBoxName.Text, "", "", "", "");
                dgvBook.DataSource = dt;
                ShowDataBook();  
            }
            else
            {
                MessageBox.Show("抱歉，未找到指定图书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion 

        #region 显示已借图书
        private void ViewLendedBook()
        {
            if (reader != null)
            {
                dt = borrowbll.GetReaderBorrow(reader.RdID);
                dgvLBook.DataSource = dt;
                ShowDataBorrow();
            }
            else
            {
                MessageBox.Show("请先登录账户再向下操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region dgvLBook行操作
        private void dgvLBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLBook.CurrentCell == null)
                return;
            borrow = borrowbll.GetBorrowByid((decimal)dgvLBook["borrowID", dgvLBook.CurrentCell.RowIndex].Value);
            //MessageBox.Show(borrow.bkID.ToString());
        }
        #endregion

        #region dgvBook 行操作
        private void dgvBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBook.CurrentCell == null)
                return;
            book = bookbll.GetBook((Int32)dgvBook["bkID", dgvBook.CurrentCell.RowIndex].Value);
            txtBoxIndex.Text = book.bkID.ToString();
            txtBoxName.Text = book.bkName;
        }
        #endregion

        #region 借书
        //借书操作
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            int rdid=Convert.ToInt32(txtBoxUSID.Text.Trim());
            int bkid = Convert.ToInt32(txtBoxIndex.Text.Trim());
            string opreatorName = labOpraName.Text;
            if (reader != null && bkid >0)
            {
                if (borrowbll.BookBorrow(rdid, bkid, opreatorName) == true)
                {
                    MessageBox.Show("借书成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewLendedBook();//刷新显示
                }
                else
                {
                    MessageBox.Show("你当前的书已续借过，请先还书！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region 返回
        //返回
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 

        #region 计算罚款
        //罚款情况
        private void PunishInfo()
        {
            DateTime ldDateRetPlan;
            DateTime retDate=DateTime.Now;
            TimeSpan span;
            int OverDay;
            int borrowID;

            float punishRate;
            float ldPunishMoney;
            float ldOverMoney;

            DataTable dtb = new DataTable(); //borrow
            DataTable dtr = new DataTable(); //readertype 
  
            if (reader != null)
            {
                dtr=(borrowbll.GetReaderType(reader.RdType));
                dtb=(borrowbll.GetReaderBorrow(reader.RdID));
                if (dtb.Rows.Count>0)
                {
                    punishRate = float.Parse(dtr.Rows[0][5].ToString());

                    for (int i = 0; i < dtb.Rows.Count;i++ )
                    {
                        borrowID = Convert.ToInt32(dtb.Rows[i][0].ToString());
                        
                        ldDateRetPlan = Convert.ToDateTime(dtb.Rows[i][5].ToString());
                        span = retDate - ldDateRetPlan;
                        OverDay = Convert.ToInt32(span.TotalDays);
                        if (OverDay < 0)
                            OverDay = 0;
                        ldPunishMoney = punishRate * OverDay;
                        ldOverMoney = ldPunishMoney;

                        if (borrowbll.UpdateMoney(OverDay, ldOverMoney, ldPunishMoney, borrowID) > 0)
                        {
                            if (OverDay > 0)
                            {
                                MessageBox.Show("你有书已超过最大借书期限" + OverDay + "天" + ",欠款" + ldOverMoney + "元",
                                    "欠款信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("计算罚款出错");
                        }
                       
                    } 
                } 
            }
        }

        #endregion

        #region 续借
        //续借
        private void btnReBorrow_Click(object sender, EventArgs e)
        {
            int rdid=Convert.ToInt32(txtBoxUSID.Text.Trim());
            if (borrow != null)
            {
                int bkid = borrow.bkID;
                string opreatorName = labOpraName.Text;
                if (reader != null && book != null)
                {
                    if (borrowbll.BookReborrow(rdid, bkid, opreatorName) > 0)
                    {
                        MessageBox.Show("续借成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ViewLendedBook(); //刷新显示
                    }
                    else
                    {
                        MessageBox.Show("续借出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("你还未选择要借的图书");
                }
            }
            
        }
        #endregion 

        #region 还书
        //还书
        private void btnReturn_Click(object sender, EventArgs e)
        {
            int rdid = Convert.ToInt32(txtBoxUSID.Text.Trim());
            int bkid = borrow.bkID;
            string opreatorName = labOpraName.Text;
            if (reader != null && book != null)
            {
                if (borrowbll.BookReturn(rdid, bkid, opreatorName) > 0)
                {
                    MessageBox.Show("还书成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewLendedBook();//刷新显示
                }
                else
                {
                    MessageBox.Show("还书出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("你还未选择要还的图书");
            }
        }
        #endregion 
  
    }
}
