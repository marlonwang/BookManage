namespace ViewMain
{
    partial class BorrowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxLended = new System.Windows.Forms.TextBox();
            this.labLendedNum = new System.Windows.Forms.Label();
            this.txtBoxCanum = new System.Windows.Forms.TextBox();
            this.labCanLenNum = new System.Windows.Forms.Label();
            this.txtBoxCanDay = new System.Windows.Forms.TextBox();
            this.labCanLenday = new System.Windows.Forms.Label();
            this.txtBoxUsType = new System.Windows.Forms.TextBox();
            this.labUsType = new System.Windows.Forms.Label();
            this.txtBoxUsDep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUName = new System.Windows.Forms.TextBox();
            this.labUsName = new System.Windows.Forms.Label();
            this.txtBoxUSID = new System.Windows.Forms.TextBox();
            this.labUserId = new System.Windows.Forms.Label();
            this.dgvLBook = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBookFind = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.labookName = new System.Windows.Forms.Label();
            this.txtBoxIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReBorrow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.labNowTime = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.labOpraName = new System.Windows.Forms.Label();
            this.labOperator = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLBook)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtBoxLended);
            this.groupBox1.Controls.Add(this.labLendedNum);
            this.groupBox1.Controls.Add(this.txtBoxCanum);
            this.groupBox1.Controls.Add(this.labCanLenNum);
            this.groupBox1.Controls.Add(this.txtBoxCanDay);
            this.groupBox1.Controls.Add(this.labCanLenday);
            this.groupBox1.Controls.Add(this.txtBoxUsType);
            this.groupBox1.Controls.Add(this.labUsType);
            this.groupBox1.Controls.Add(this.txtBoxUsDep);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxUName);
            this.groupBox1.Controls.Add(this.labUsName);
            this.groupBox1.Controls.Add(this.txtBoxUSID);
            this.groupBox1.Controls.Add(this.labUserId);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者信息";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(117, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxLended
            // 
            this.txtBoxLended.Location = new System.Drawing.Point(651, 40);
            this.txtBoxLended.Name = "txtBoxLended";
            this.txtBoxLended.Size = new System.Drawing.Size(67, 21);
            this.txtBoxLended.TabIndex = 13;
            // 
            // labLendedNum
            // 
            this.labLendedNum.AutoSize = true;
            this.labLendedNum.Location = new System.Drawing.Point(580, 44);
            this.labLendedNum.Name = "labLendedNum";
            this.labLendedNum.Size = new System.Drawing.Size(65, 12);
            this.labLendedNum.TabIndex = 12;
            this.labLendedNum.Text = "已借书量：";
            // 
            // txtBoxCanum
            // 
            this.txtBoxCanum.Location = new System.Drawing.Point(454, 41);
            this.txtBoxCanum.Name = "txtBoxCanum";
            this.txtBoxCanum.Size = new System.Drawing.Size(90, 21);
            this.txtBoxCanum.TabIndex = 11;
            // 
            // labCanLenNum
            // 
            this.labCanLenNum.AutoSize = true;
            this.labCanLenNum.Location = new System.Drawing.Point(385, 45);
            this.labCanLenNum.Name = "labCanLenNum";
            this.labCanLenNum.Size = new System.Drawing.Size(65, 12);
            this.labCanLenNum.TabIndex = 10;
            this.labCanLenNum.Text = "可借数量：";
            // 
            // txtBoxCanDay
            // 
            this.txtBoxCanDay.Location = new System.Drawing.Point(277, 41);
            this.txtBoxCanDay.Name = "txtBoxCanDay";
            this.txtBoxCanDay.Size = new System.Drawing.Size(67, 21);
            this.txtBoxCanDay.TabIndex = 9;
            // 
            // labCanLenday
            // 
            this.labCanLenday.AutoSize = true;
            this.labCanLenday.Location = new System.Drawing.Point(208, 46);
            this.labCanLenday.Name = "labCanLenday";
            this.labCanLenday.Size = new System.Drawing.Size(65, 12);
            this.labCanLenday.TabIndex = 8;
            this.labCanLenday.Text = "可借天数：";
            // 
            // txtBoxUsType
            // 
            this.txtBoxUsType.Location = new System.Drawing.Point(651, 14);
            this.txtBoxUsType.Name = "txtBoxUsType";
            this.txtBoxUsType.Size = new System.Drawing.Size(67, 21);
            this.txtBoxUsType.TabIndex = 7;
            // 
            // labUsType
            // 
            this.labUsType.AutoSize = true;
            this.labUsType.Location = new System.Drawing.Point(580, 17);
            this.labUsType.Name = "labUsType";
            this.labUsType.Size = new System.Drawing.Size(65, 12);
            this.labUsType.TabIndex = 6;
            this.labUsType.Text = "读者类型：";
            // 
            // txtBoxUsDep
            // 
            this.txtBoxUsDep.Location = new System.Drawing.Point(454, 14);
            this.txtBoxUsDep.Name = "txtBoxUsDep";
            this.txtBoxUsDep.Size = new System.Drawing.Size(90, 21);
            this.txtBoxUsDep.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "读者单位：";
            // 
            // txtBoxUName
            // 
            this.txtBoxUName.Location = new System.Drawing.Point(277, 15);
            this.txtBoxUName.Name = "txtBoxUName";
            this.txtBoxUName.Size = new System.Drawing.Size(67, 21);
            this.txtBoxUName.TabIndex = 3;
            // 
            // labUsName
            // 
            this.labUsName.AutoSize = true;
            this.labUsName.Location = new System.Drawing.Point(206, 18);
            this.labUsName.Name = "labUsName";
            this.labUsName.Size = new System.Drawing.Size(65, 12);
            this.labUsName.TabIndex = 2;
            this.labUsName.Text = "读者姓名：";
            // 
            // txtBoxUSID
            // 
            this.txtBoxUSID.Location = new System.Drawing.Point(24, 38);
            this.txtBoxUSID.Name = "txtBoxUSID";
            this.txtBoxUSID.Size = new System.Drawing.Size(82, 21);
            this.txtBoxUSID.TabIndex = 1;
            // 
            // labUserId
            // 
            this.labUserId.AutoSize = true;
            this.labUserId.Location = new System.Drawing.Point(23, 18);
            this.labUserId.Name = "labUserId";
            this.labUserId.Size = new System.Drawing.Size(65, 12);
            this.labUserId.TabIndex = 0;
            this.labUserId.Text = "读者编号：";
            // 
            // dgvLBook
            // 
            this.dgvLBook.AllowUserToAddRows = false;
            this.dgvLBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLBook.Location = new System.Drawing.Point(13, 100);
            this.dgvLBook.Name = "dgvLBook";
            this.dgvLBook.RowTemplate.Height = 23;
            this.dgvLBook.Size = new System.Drawing.Size(752, 150);
            this.dgvLBook.TabIndex = 1;
            this.dgvLBook.SelectionChanged += new System.EventHandler(this.dgvLBook_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBookFind);
            this.groupBox2.Controls.Add(this.txtBoxName);
            this.groupBox2.Controls.Add(this.labookName);
            this.groupBox2.Controls.Add(this.txtBoxIndex);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 45);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息";
            // 
            // btnBookFind
            // 
            this.btnBookFind.Location = new System.Drawing.Point(453, 13);
            this.btnBookFind.Name = "btnBookFind";
            this.btnBookFind.Size = new System.Drawing.Size(56, 23);
            this.btnBookFind.TabIndex = 4;
            this.btnBookFind.Text = "查询";
            this.btnBookFind.UseVisualStyleBackColor = true;
            this.btnBookFind.Click += new System.EventHandler(this.btnBookFind_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(276, 15);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(113, 21);
            this.txtBoxName.TabIndex = 3;
            // 
            // labookName
            // 
            this.labookName.AutoSize = true;
            this.labookName.Location = new System.Drawing.Point(207, 21);
            this.labookName.Name = "labookName";
            this.labookName.Size = new System.Drawing.Size(65, 12);
            this.labookName.TabIndex = 2;
            this.labookName.Text = "图书名称：";
            // 
            // txtBoxIndex
            // 
            this.txtBoxIndex.Location = new System.Drawing.Point(89, 15);
            this.txtBoxIndex.Name = "txtBoxIndex";
            this.txtBoxIndex.Size = new System.Drawing.Size(82, 21);
            this.txtBoxIndex.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "图书序号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "已借图书：";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(14, 318);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowTemplate.Height = 23;
            this.dgvBook.Size = new System.Drawing.Size(751, 158);
            this.dgvBook.TabIndex = 4;
            this.dgvBook.SelectionChanged += new System.EventHandler(this.dgvBook_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.btnReBorrow);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnBorrow);
            this.panel1.Controls.Add(this.labNowTime);
            this.panel1.Controls.Add(this.labTime);
            this.panel1.Controls.Add(this.labOpraName);
            this.panel1.Controls.Add(this.labOperator);
            this.panel1.Location = new System.Drawing.Point(14, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 28);
            this.panel1.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(572, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(55, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "还书";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReBorrow
            // 
            this.btnReBorrow.Location = new System.Drawing.Point(483, 4);
            this.btnReBorrow.Name = "btnReBorrow";
            this.btnReBorrow.Size = new System.Drawing.Size(55, 23);
            this.btnReBorrow.TabIndex = 6;
            this.btnReBorrow.Text = "续借";
            this.btnReBorrow.UseVisualStyleBackColor = true;
            this.btnReBorrow.Click += new System.EventHandler(this.btnReBorrow_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(661, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(390, 4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(55, 23);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "借阅";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // labNowTime
            // 
            this.labNowTime.AutoSize = true;
            this.labNowTime.Location = new System.Drawing.Point(253, 8);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(65, 12);
            this.labNowTime.TabIndex = 3;
            this.labNowTime.Text = "2013-12-16";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(182, 8);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(65, 12);
            this.labTime.TabIndex = 2;
            this.labTime.Text = "当前时间：";
            // 
            // labOpraName
            // 
            this.labOpraName.AutoSize = true;
            this.labOpraName.Location = new System.Drawing.Point(83, 8);
            this.labOpraName.Name = "labOpraName";
            this.labOpraName.Size = new System.Drawing.Size(71, 12);
            this.labOpraName.TabIndex = 1;
            this.labOpraName.Text = "labOpraName";
            // 
            // labOperator
            // 
            this.labOperator.AutoSize = true;
            this.labOperator.Location = new System.Drawing.Point(11, 8);
            this.labOperator.Name = "labOperator";
            this.labOperator.Size = new System.Drawing.Size(65, 12);
            this.labOperator.TabIndex = 0;
            this.labOperator.Text = "操作人员：";
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvLBook);
            this.Controls.Add(this.groupBox1);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLBook)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labUsName;
        private System.Windows.Forms.TextBox txtBoxUSID;
        private System.Windows.Forms.Label labUserId;
        private System.Windows.Forms.Label labLendedNum;
        private System.Windows.Forms.TextBox txtBoxCanum;
        private System.Windows.Forms.Label labCanLenNum;
        private System.Windows.Forms.TextBox txtBoxCanDay;
        private System.Windows.Forms.Label labCanLenday;
        private System.Windows.Forms.TextBox txtBoxUsType;
        private System.Windows.Forms.Label labUsType;
        private System.Windows.Forms.TextBox txtBoxUsDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUName;
        private System.Windows.Forms.DataGridView dgvLBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBoxLended;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBookFind;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label labookName;
        private System.Windows.Forms.TextBox txtBoxIndex;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labOpraName;
        private System.Windows.Forms.Label labOperator;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label labNowTime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Button btnReBorrow;
        private System.Windows.Forms.Button btnReturn;
    }
}