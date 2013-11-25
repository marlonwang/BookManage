using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BookManage.Model;
using BookManage.BLL;

namespace ViewMain
{
    internal enum opStatus
    {
        inSelect = 0,  //查询操作状态
        inNew = 1,     //办理新借书证
        inChange = 2   //变更借书证状态
    };

    public partial class ReaderForm : Form
    {
        private DataTable dt = null;
        private Reader reader = new Reader();
        private ReaderBLL readerBLL = new ReaderBLL();
        private opStatus ops;

        #region 初始化GridView 和 ComoboBox
        ///<summary>
        ///从数据库选出用户类型 填写到gridview列名
        ///</summary>
        ///<param name="strText"></param>
        ///<returns></returns>
        public ReaderForm()
        {
            InitializeComponent();
            dt = readerBLL.GetAllReaderType();
            foreach (DataRow dr in dt.Rows)
            {
                tsCBoxRT.Items.Add(dr["RdType"].ToString() + "--" + dr["RdTypeName"].ToString()); //null
                CBoxRT.Items.Add(dr["RdType"].ToString() + "--" + dr["RdTypeName"].ToString());
            }
            SetStatus(opStatus.inSelect);
            dt = readerBLL.GetReader(0, "", "");//查询空记录，得到读者表结构
            ShowData();
            txtBoxLended.Text = "0";
        }
        #endregion

        #region 用户状态
        private void SetStatus(opStatus opst)
        {
            ops = opst;
            switch (ops)
            {
                case opStatus.inSelect:
                    toolStrip1.Enabled = true;  //查询工具栏
                    groupBox1.Enabled = true;   //查询结果
                    groupBox2.Enabled = true;   //借阅信息　groupBox1 与 groupBox2　一起　
                    groupBox3.Enabled = false;  //读者信息 和　办证
                    break;
                case opStatus.inNew:
                    toolStrip1.Enabled = false; //工具栏不启用
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = true;  //启用办证
                    btnBanZheng.Enabled = true; //确认办证
                    //btnUpdateReader.Enabled =false; //不存在　修改用户读者信息在BookForm.cs 实现
                    break;
                case opStatus.inChange:
                    toolStrip1.Enabled = false;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = true;
                    btnBanZheng.Enabled = false;
                    //btnUpdateReader.Enabled = true; //不存在　修改用户读者信息在BookForm.cs 实现
                    break;
            }
        }
        #endregion

        #region 读者操作状态切换
        //办理借书证
        private void btnMakeCard_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inNew);
        }
     　 //变更借书证
        private void btnModifyCard_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inChange);  
        }
        //撤销
        private void btnCheXiao_Click(object sender, EventArgs e)
        {
            SetStatus(opStatus.inSelect);
        }
        #endregion

        #region 显示数据到GridView
        //ShowData()
        private void ShowData()
        {
            dgvReader.DataSource = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                dgvReader.Columns[dc.ColumnName].HeaderText = Reader.ColumnTitle(dc.ColumnName);
            }
        }
        #endregion

        #region 查找按钮
        //查找用户
        private void tsBtnFind_Click(object sender, EventArgs e)
        {
            int rdType;
            string rdDept, rdName;
            if (tsCBoxRT.Text.Trim() == "")
            {
                rdType = 0;
            }
            else
            {
                int i = tsCBoxRT.Text.IndexOf("--");
                if (i > 0)
                    rdType = Convert.ToInt32(tsCBoxRT.Text.Substring(0, i));
                else
                    rdType = Convert.ToInt32(tsCBoxRT.Text);
            }
            rdDept = tsCBoxRD.Text;
            rdName = tsCBoxRN.Text;
            dt = readerBLL.GetReader(rdType, rdDept, rdName);
            ShowData();
        }
        #endregion

        #region DataGridView行操作
        private void dgvReader_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReader.CurrentCell == null)
                return;
            reader = readerBLL.GetReader((int)dgvReader["RdID", dgvReader.CurrentCell.RowIndex].Value);
            SetReaderToText();
        }
        #endregion

        #region 退出 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 注销借书证

        //更改状态为　注销
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (CBoxStatus.Text.Trim() == "有效" || CBoxStatus.Text.Trim() == "挂失")
            {
                CBoxStatus.Text = "注销";
                SetTextToReader();
                if (readerBLL.UpdateReader(reader) > 0)
                {
                    MessageBox.Show("证件注销成功.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("注销失败.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 挂失证件
        //挂失
        private void btnLostCard_Click(object sender, EventArgs e)
        {
            if (CBoxStatus.Text.Trim() == "有效")
            {
                CBoxStatus.Text = "挂失";
                SetTextToReader();
                if (readerBLL.UpdateReader(reader) > 0)
                {
                    MessageBox.Show("挂失成功,挂失期间证件不可用.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }
            else if(CBoxStatus.Text.Trim()=="挂失")
            {
                MessageBox.Show("证件已经挂失,不要重复挂失.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("证件已注销或无效.操作时失败.", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region   //解除挂失

        private void btnFindCard_Click(object sender, EventArgs e)
        {
            if (CBoxStatus.Text.Trim() == "挂失")
            {
                CBoxStatus.Text = "有效";
                SetTextToReader();
                if (readerBLL.UpdateReader(reader) > 0)
                    MessageBox.Show("解除挂失成功", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("非挂失状态,操作失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 办证
        //确认办证
        private void btnBanZheng_Click(object sender, EventArgs e)
        {
            if (txtBoxID.Text == null || txtBoxName == null || txtBoxPwd == null || CBoxRT == null)
            {
                MessageBox.Show("用户信息不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SetTextToReader();
                if ( readerBLL.InsertReader(reader) > 0) //InsertReader()办证
                {
                    MessageBox.Show("恭喜，证件已办理", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("办理失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region SetTextToReader
        //办证时的输入信息转为读者属性
        private void SetTextToReader()
        {
            reader.RdID = Convert.ToInt32(txtBoxID.Text);
            reader.RdName = txtBoxName.Text;
            reader.RdPwd = txtBoxPwd.Text;
            reader.RdSex = cBoxSex.Text;
            reader.RdBorrowQty =Convert.ToInt32(txtBoxLended.Text);
            reader.RdStatus = CBoxStatus.Text;
            reader.RdAdminRoles = Convert.ToInt32(txtBoxRole.Text);

            int i = CBoxRT.Text.IndexOf("--");
            if (i > 0)
                reader.RdType = Convert.ToInt32(CBoxRT.Text.Substring(0, i));
            else
                reader.RdType = Convert.ToInt32(CBoxRT.Text);

            reader.RdDepart = CBoxRD.Text;
            reader.RdPhone = txtBoxTel.Text;
            reader.RdEmail = txtBoxMail.Text;

            //注册时间可由数据库获取 此处获取但不使用
            reader.RdDateReg = dateTimePicker1.Value; 
            //dateTimePicker当前时间 数据库中自动添加时间getdate();

            if (ReaderPBox.Image == null)
            {
                MessageBox.Show("用户图片不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);//默认图片
            }
            else if (ReaderPBox.Image != null)
            {
                MemoryStream ms = new MemoryStream();      //???出错
                ReaderPBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                reader.RdPhotoImg = ms.GetBuffer();
            }
        }
        #endregion

        #region 上传图片
        //上传图片 图片大小 112*126
        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "图像文件(*.jpg;*.bmp;*.png;*.gif)|*.jpg;*.bmp;*.png;*gif";
            //openFileDialog.RestoreDirectory = true;
            //openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image imgPhoto=Image.FromFile(openFileDialog.FileName);
                ReaderPBox.Image = imgPhoto;
            }
        }
        #endregion

        #region SetReaderToText
        //选中读者是右侧显示读者信息
        private void SetReaderToText()
        {
            txtBoxID.Text = Convert.ToString(reader.RdID);
            txtBoxName.Text = reader.RdName;
            txtBoxPwd.Text = reader.RdPwd;
            cBoxSex.Text = reader.RdSex;
            CBoxRT.Text = Convert.ToString(reader.RdType);
            CBoxRD.Text = reader.RdDepart;
            txtBoxTel.Text = reader.RdPhone;
            txtBoxMail.Text = reader.RdEmail;
            dateTimePicker1.Value = reader.RdDateReg;
            if (reader.RdPhotoImg == null)
            {
                ReaderPBox.Image = Properties.Resources._default; //无图片时
                if (ReaderPBox.Image == null)
                {
                    MemoryStream ms = new MemoryStream();      
                    ReaderPBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    reader.RdPhotoImg = ms.GetBuffer();
                }
            }
            else
            {
                MemoryStream ms = new MemoryStream(reader.RdPhotoImg);
                Image imgphoto = Bitmap.FromStream(ms, true);
                ReaderPBox.Image = imgphoto;
            }
            CBoxStatus.Text = reader.RdStatus;
            txtBoxLended.Text = Convert.ToString(reader.RdBorrowQty);
            txtBoxRole.Text = Convert.ToString(reader.RdAdminRoles);
        }
        #endregion

        #region 变更借书证

        private void btnModifyOk_Click(object sender, EventArgs e)
        {
            //reader.RdID = Convert.ToInt32(txtBoxID.Text);
            SetTextToReader();
            if(readerBLL.UpdateReader(reader)>0)
                MessageBox.Show("恭喜，证件已变更", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("哎呀，证件变更出错", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region 读者类别导出
        //导出Excel
        private void tsBtnOutExcel_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)this.dgvReader.DataSource;
            if (dt == null)
            {
                return;
            } 
            if (dt.Rows.Count == 0)
            {                
                return;
            }
            /*
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("请确保您的电脑已经安装Excel", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dt == null || dt.Rows.Count == 0) return;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                return;
            }
            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range range;
            long totalCount = dt.Rows.Count;
            long rowRead = 0;
            float percent = 0;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Interior.ColorIndex = 15;
                range.Font.Bold = true;
            }
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dt.Rows[r][i].ToString();
                }
                rowRead++;
                percent = ((float)(100 * rowRead)) / totalCount;
            }
            xlApp.Visible = true;
         * */
            
        }
        #endregion

        #region 导出EXCEL
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File To";
            saveFileDialog.ShowDialog();
            Stream myStream;
            myStream = saveFileDialog.OpenFile();
            //StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            StreamWriter sw = new StreamWriter(myStream, System.Text.Encoding.GetEncoding(-0));
            string str = "";
            try
            {
                //写标题
                for (int i = 0; i < dgvReader.ColumnCount; i++)
                {
                    if (i > 0)
                    {
                        str += "\t";
                    }
                    str += dgvReader.Columns[i].HeaderText;
                }
                sw.WriteLine(str);
                //写内容
                for (int j = 0; j < dgvReader.Rows.Count; j++)
                {
                    string tempStr = "";
                    for (int k = 0; k < dgvReader.Columns.Count; k++)
                    {
                        if (k > 0)
                        {
                            tempStr += "\t";
                        }
                        tempStr += dgvReader.Rows[j].Cells[k].Value.ToString();
                    }
                    sw.WriteLine(tempStr);
                }
                sw.Close();
                myStream.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            finally
            {
                sw.Close();
                myStream.Close();
            }          
        }
        #endregion

    }      
}
