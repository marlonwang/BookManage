using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.BLL;
using BookManage.Model;

namespace ViewMain
{
    public partial class BMSLogin : Form
    {
        #region 声明
        ///<summary>
        ///变量声明
        ///</summary>
        ///<param name="strText">loginTimes readerBLL reader</param>
        ///<returns></returns>
        private int loginTimes = 0; //登录次数
        private ReaderBLL readerBLL = new ReaderBLL();
        public static Reader reader = null;//用户信息 全局
        #endregion

        public BMSLogin()
        {
            InitializeComponent();
            //调试帐户
            comboBox1.Text = "管理员";
            txtUser.Text = "10005";
            txtPwd.Text = "666666";
        }

        #region 登录按钮
        ///<summary>
        ///用户登录
        ///</summary>
        ///<param name="strText"></param>
        ///<returns>DialogResult.OK</returns>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginTimes++;
            int rdid;
            //string usrtype = this.comboBox1.Text;//用户类型
            //MessageBox.Show(usrtype);
            if (txtUser.Text == "")
            {
                MessageBox.Show("用户名不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                rdid = Convert.ToInt32(txtUser.Text.Trim());
                reader = readerBLL.GetReader(rdid);

                if (reader == null)
                {
                    txtUser.Focus();
                    labInfo.Text = "登陆出错,无该用户." + "出错次数" + loginTimes.ToString() + "次";
                    MessageBox.Show("用户帐户不存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reader.RdPwd == txtPwd.Text)
                    {
                        this.DialogResult = DialogResult.OK;//登录成功
                    }
                    else
                    {
                        txtPwd.Text = "";
                        txtPwd.Focus();
                        labInfo.Text = "-_-||密码错误!" + "出错次数" + loginTimes.ToString() + "次";
                    }
                }
            }
        }
        #endregion

        #region 退出操作
        ///<summary>
        ///退出关闭窗体
        ///</summary>
        ///<param name="strText"></param>
        ///<returns></returns>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
