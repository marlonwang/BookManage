/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2013/11/10
 * 时间: 16:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BookManage.Model;
using System.IO;
using BookManage.BLL;

namespace ViewMain
{
	
	public partial class BookForm : Form
	{
        private ReaderBLL readerbll = new ReaderBLL();

		public BookForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            InitMenu();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
        public void InitMenu()
        {
            Reader reader = BMSLogin.reader;
            //获取登陆用户的读者信息
            //图书管理ToolStripMenuItem.Visiable = true; //可见？
            //图书管理ToolStripMenuItem.Available=false;//活动？

            //图书管理
            BookToolStripMenuItem.Enabled= reader.IsBookAdmin();
            //读者管理
            ReaderToolStripMenuItem.Enabled= (reader.IsReaderAdmin() || reader.IsSystemAdmin());
            //借阅管理
            BorrowToolStripMenuItem.Enabled= reader.IsBorrowAdmin();
            //权限管理
            RankToolStripMenuItem.Enabled= reader.IsSystemAdmin();
            //StatusLabel
            labDate.Text = "当前时间:" + DateTime.Now.ToLongDateString().ToString();

            //RdID
            txtUserID.Text = reader.RdID.ToString();
            //RdSex
            txtUserSex.Text = reader.RdSex.ToString();
            //RdName
            txtBoxName.Text = reader.RdName.ToString();
            //RdType
            txtBoxType.Text = reader.RdType.ToString();
            //RdState
            txtBoxState.Text = reader.RdStatus.ToString();
            //RdDateReg
            labDateReg.Text = reader.RdDateReg.ToLongDateString().ToString();
            //RdPhone
            txtBoxTel.Text = reader.RdPhone.ToString();
            //RdEmail
            txtBoxMail.Text = reader.RdEmail.ToString();
            //RdDepart
            txtBoxDepart.Text = reader.RdDepart.ToString();
            //RdBorrowQty
            labLdNum.Text = reader.RdBorrowQty.ToString() + "/5";

            //可否修改
            groupBox2.Enabled = reader.IsSystemAdmin();
        }

       
        //提交更改结果到数据库
        private void btnCommit_Click(object sender, EventArgs e)
        {
            int rdid = Convert.ToInt32(txtBoxRID.Text);
            int rdtype = Convert.ToInt16(CBoxNewRank.Text);
            if (readerbll.ChangeRank(rdid, rdtype) > 0)
            {
                MessageBox.Show("修改权限成功");
            }
            else
            {
                MessageBox.Show("更改权限失败");
            }
        }

        #region 修改密码
        //修改密码
        private void btnPwdOk_Click(object sender, EventArgs e)
        {
            string OldPwd = txtBoxPwdOld.Text;
            string NewPwd = txtBoxPwdNew.Text;
            string RptPwd = txtBoxPwdRepeat.Text;
            int rdid = Convert.ToInt32(txtUserID.Text);

            if ( OldPwd == "" || NewPwd == "" || RptPwd == "" )
            {
                MessageBox.Show("密码不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (NewPwd != RptPwd)
            {
                labResult.Text = "新密码前后输入不一致！";
            }
            else if (NewPwd == RptPwd)
            {
                if (readerbll.ChangePwd(rdid, NewPwd) > 0)
                {
                    labResult.Text = "修改密码成功！";
                }
                else
                    labResult.Text = "密码修改失败！";
            }
        }
        //取消修改
        private void btnPwdCancel_Click(object sender, EventArgs e)
        {
            txtBoxPwdOld.Text = "";
            txtBoxPwdNew.Text = "";
            txtBoxPwdRepeat.Text = "";
            labResult.Text = "";
        }

        private void PwdChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //当前窗体 无需跳转
        }
        #endregion

        #region 读者管理
        ///<summary>
        ///修改　变更　注销　挂失　查询
        /// </summary>

        //系统管理员则跳至ReaderForm.cs
        private void MakeCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderForm rdform = new ReaderForm();
            this.Visible = true;
            rdform.ShowDialog();
        }

        private void ChangeCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderForm rdform = new ReaderForm();
            this.Visible = true;
            rdform.ShowDialog();
        }

        private void LostCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderForm rdform = new ReaderForm();
            this.Visible = true;
            rdform.ShowDialog();
        }

        private void CancelCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderForm rdform = new ReaderForm();
            this.Visible = true;
            rdform.ShowDialog();
        }
        #endregion

        #region 读者类型管理

        private void TypeCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeForm tpform = new TypeForm();
            this.Visible = true;
            tpform.ShowDialog();
        }
        #endregion

        #region 图书管理
        //新书入库
        private void NBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook abook = new AddBook();
            this.Visible = true;
            abook.ShowDialog();
        }

        private void BIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindBook fbook = new FindBook();
            this.Visible = true;
            fbook.ShowDialog();
        }

        //退出程序
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //借书
        private void BoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowForm boform = new BorrowForm();
            this.Visible = true;
            boform.ShowDialog();
        }

        private void rtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowForm boform = new BorrowForm();
            this.Visible = true;
            boform.ShowDialog();
        }
        //图书维护
        private void rbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrowForm boform = new BorrowForm();
            this.Visible = true;
            boform.ShowDialog();
        }
        //关于
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("图书管理系统" + '\n' + "By 王威" + '\n' + "Email：alexwang252@gmail.com",
                "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        #endregion

    }
}
