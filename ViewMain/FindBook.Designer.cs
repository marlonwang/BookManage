namespace ViewMain
{
    partial class FindBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBook));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnScanAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSpecific = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBack = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnScanAll,
            this.toolStripSeparator1,
            this.tsBtnSpecific,
            this.toolStripSeparator2,
            this.tsBtnModify,
            this.toolStripSeparator3,
            this.tsBtnReport,
            this.toolStripSeparator4,
            this.tsBtnBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(744, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnScanAll
            // 
            this.tsBtnScanAll.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnScanAll.Image")));
            this.tsBtnScanAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnScanAll.Name = "tsBtnScanAll";
            this.tsBtnScanAll.Size = new System.Drawing.Size(73, 22);
            this.tsBtnScanAll.Text = "浏览全部";
            this.tsBtnScanAll.Click += new System.EventHandler(this.tsBtnScanAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnSpecific
            // 
            this.tsBtnSpecific.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSpecific.Image")));
            this.tsBtnSpecific.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSpecific.Name = "tsBtnSpecific";
            this.tsBtnSpecific.Size = new System.Drawing.Size(73, 22);
            this.tsBtnSpecific.Text = "查看详细";
            this.tsBtnSpecific.Click += new System.EventHandler(this.tsBtnSpecific_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnModify
            // 
            this.tsBtnModify.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModify.Image")));
            this.tsBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModify.Name = "tsBtnModify";
            this.tsBtnModify.Size = new System.Drawing.Size(73, 22);
            this.tsBtnModify.Text = "修改选中";
            this.tsBtnModify.Click += new System.EventHandler(this.tsBtnModify_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnReport
            // 
            this.tsBtnReport.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnReport.Image")));
            this.tsBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReport.Name = "tsBtnReport";
            this.tsBtnReport.Size = new System.Drawing.Size(73, 22);
            this.tsBtnReport.Text = "生成报表";
            this.tsBtnReport.Click += new System.EventHandler(this.tsBtnReport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnBack
            // 
            this.tsBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBack.Image")));
            this.tsBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBack.Name = "tsBtnBack";
            this.tsBtnBack.Size = new System.Drawing.Size(49, 22);
            this.tsBtnBack.Text = "返回";
            this.tsBtnBack.Click += new System.EventHandler(this.tsBtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvResult);
            this.panel1.Location = new System.Drawing.Point(13, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 263);
            this.panel1.TabIndex = 1;
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(3, 3);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(713, 257);
            this.dgvResult.TabIndex = 0;
            this.dgvResult.SelectionChanged += new System.EventHandler(this.dgvResult_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpInDate);
            this.groupBox1.Controls.Add(this.dtpPublishDate);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtBoxISBN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBoxClass);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxPress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxAuthor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件( 可部分不填写 )";
            // 
            // dtpInDate
            // 
            this.dtpInDate.Location = new System.Drawing.Point(237, 57);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(77, 21);
            this.dtpInDate.TabIndex = 18;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(83, 57);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(77, 21);
            this.dtpPublishDate.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(646, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxISBN
            // 
            this.txtBoxISBN.Location = new System.Drawing.Point(546, 59);
            this.txtBoxISBN.Name = "txtBoxISBN";
            this.txtBoxISBN.Size = new System.Drawing.Size(77, 21);
            this.txtBoxISBN.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "ISBN：";
            // 
            // txtBoxClass
            // 
            this.txtBoxClass.Location = new System.Drawing.Point(396, 59);
            this.txtBoxClass.Name = "txtBoxClass";
            this.txtBoxClass.Size = new System.Drawing.Size(77, 21);
            this.txtBoxClass.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "类别名称：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "入馆日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "出版日期：";
            // 
            // txtBoxPress
            // 
            this.txtBoxPress.Location = new System.Drawing.Point(546, 23);
            this.txtBoxPress.Name = "txtBoxPress";
            this.txtBoxPress.Size = new System.Drawing.Size(77, 21);
            this.txtBoxPress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "出版社：";
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(396, 23);
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(77, 21);
            this.txtBoxAuthor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "图书作者：";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(237, 24);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(77, 21);
            this.txtBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "图书名称：";
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Location = new System.Drawing.Point(83, 23);
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(77, 21);
            this.txtBoxCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编号：";
            // 
            // FindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FindBook";
            this.Text = "图书查询与维护";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnScanAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnSpecific;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxPress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxISBN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.DateTimePicker dtpInDate;
    }
}