using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManage.BLL;
using BookManage.Model;
using System.IO;

namespace ViewMain
{
    public partial class AddBook : Form
    {
        //private DataTable dt = null;
        private Book book=new Book();
        private BookBLL bookbll = new BookBLL();
        private string status = "在馆";

        //判断　是否处于维护状态
        bool IsBookModify = FindBook.isModify;

        #region IniTialize

        public AddBook()
        {
            InitializeComponent();
            cBoxLang.SelectedIndex= 0;   //语言类型默认　0-中文
            if (IsBookModify == true)
            {
                labBkIndex.Visible = true;
                txtBoxIndex.Visible = true;
                btnSave.Visible = true;
                btnBack.Visible = true;
                btnAdd.Visible = false;
                labBkIndex.Visible = true;
                txtBoxIndex.Visible = true;
                ShowBookInfo();
            }
            else
            {
                labBkIndex.Visible = false;
                txtBoxIndex.Visible = false;
                btnSave.Visible = false;
                btnBack.Visible = false;
            }
        }
        #endregion

        #region SetTextToBook
        //SetTextToBook()
        private void SetTextToBook()
        {
            book.bkCode = txtBoxCode.Text.Trim();
            book.bkName = txtBoxName.Text.Trim();
            book.bkAuthor = txtBoxAuthor.Text.Trim();
            book.bkPress = txtBoxPbN.Text.Trim();
            book.bkDatePress = Convert.ToDateTime(txtBoxPubDay.Text);
            book.bkISBN = txtBoxISBN.Text.Trim();
            book.bkCatalog = txtBoxClass.Text;

            //语言类型转　整型
            int i = cBoxLang.Text.IndexOf("-");
            if (i > 0)
                book.bkLanguage = Convert.ToInt32(cBoxLang.Text.Substring(0, i));
            else
                book.bkLanguage = Convert.ToInt32(cBoxLang.Text);

            book.bkPages = Convert.ToInt32(txtBoxPages.Text.Trim());
            book.bkPrice = float.Parse(txtBoxPrice.Text);
            book.bkInTime = dtPicker.Value;
            book.bkNums = Convert.ToInt32(txtBoxNums.Text);
            book.bkStatus = status;
            book.bkBriefCont = rtBoxCon.Text;

            //图书封面
            if (ptBoxImg.Image == null)
            {
                MessageBox.Show("图书图片为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);//默认图片
            }
            else if (ptBoxImg.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                ptBoxImg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                book.bkCover = ms.GetBuffer();
            }

            //修该图书的参数
            if (txtBoxIndex.Text != "")
                book.bkID = Convert.ToInt32(txtBoxIndex.Text);
            else
                txtBoxIndex.Text = "0";     
        }
        #endregion

        #region 上传图片
        //上传图片 图片大小 112*126
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "图像文件(*.jpg;*.bmp;*.png;*.gif)|*.jpg;*.bmp;*.png;*gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto=Image.FromFile(openFileDialog.FileName);
                ptBoxImg.Image = imgPhoto;
            }
        }
        #endregion

        #region 添加图书

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxCode.Text == null || txtBoxName.Text == null || txtBoxAuthor == null)
            {
                MessageBox.Show("用户信息不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SetTextToBook();
                if(bookbll.InsertBook(book)>0)
                    MessageBox.Show("添加图书成功!","消息",MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                    MessageBox.Show("图书添加失败!","消息",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //取消添加
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBoxCode.Text = "";
            txtBoxName.Text = "";
            txtBoxAuthor.Text = "";
            txtBoxPbN.Text = "";
            txtBoxPubDay.Text = "";
            txtBoxISBN.Text = "";
            txtBoxClass.Text = "";
            cBoxLang.SelectedIndex = 0;
            txtBoxPages.Text = "";
            txtBoxPrice.Text = "";
            dtPicker.Text = "";
            txtBoxNums.Text = "";
            rtBoxCon.Text = "";
        }

        #endregion

        #region SetBookToText
        //将控件的内容保存为图书的属性
        private void SetBookToText()
        {
            txtBoxCode.Text = book.bkCode;
            txtBoxName.Text = book.bkName;
            txtBoxAuthor.Text = book.bkAuthor;
            txtBoxPubDay.Text = book.bkDatePress.ToLongDateString().ToString();
            txtBoxISBN.Text = book.bkISBN;
            txtBoxClass.Text = book.bkCatalog;
            txtBoxPbN.Text = book.bkPress;

            int lan = book.bkLanguage;
            switch (lan)
            {
                case 0: cBoxLang.Text = "0-中文"; break;
                case 1: cBoxLang.Text = "1-英文"; break;
                case 2: cBoxLang.Text = "2-日文"; break;
                case 3: cBoxLang.Text = "3-俄文"; break;
                case 4: cBoxLang.Text = "4-德文"; break;
                case 5: cBoxLang.Text = "5-法文"; break;
            }

            txtBoxPages.Text = book.bkPages.ToString();
            txtBoxPrice.Text = book.bkPrice.ToString();
            dtPicker.Value = book.bkInTime;
            txtBoxNums.Text = book.bkNums.ToString();
            txtBoxIndex.Text = book.bkID.ToString();

            rtBoxCon.Text = book.bkBriefCont;

            if (book.bkCover != null)
            {
                MemoryStream ms = new MemoryStream(book.bkCover);
                Image imgphoto = Bitmap.FromStream(ms, true);
                ptBoxImg.Image = imgphoto;
            }
            
        }
        #endregion

        #region 显示FindBook　传的参数
        //显示FindBook窗体传递过来的book类
        private void ShowBookInfo()
        {
            book = FindBook.book;
            if (book != null)
                SetBookToText();
        }
        #endregion

        #region 修改图书
        //修改
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxIndex.Text != "")
            {
                SetTextToBook();
                if (bookbll.UpdateBook(book) > 0)
                {
                    MessageBox.Show("修改图书成功!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("图书修改失败!", "消息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("被修改图书的序号ID不能为空!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
        
        #endregion 

       　
        //返回
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
