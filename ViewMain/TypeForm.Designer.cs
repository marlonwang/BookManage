namespace ViewMain
{
    partial class TypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnFirstRec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnPreRec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnNextRec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnLastRec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnAddRec = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBack = new System.Windows.Forms.ToolStripButton();
            this.labName = new System.Windows.Forms.Label();
            this.labCanlend = new System.Windows.Forms.Label();
            this.txtBoxTypeName = new System.Windows.Forms.TextBox();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.labCanLendDay = new System.Windows.Forms.Label();
            this.txtBoxDays = new System.Windows.Forms.TextBox();
            this.labContinueTimes = new System.Windows.Forms.Label();
            this.txtBoxCanTimes = new System.Windows.Forms.TextBox();
            this.labPuniRate = new System.Windows.Forms.Label();
            this.txtBoxPnRate = new System.Windows.Forms.TextBox();
            this.labValibDate = new System.Windows.Forms.Label();
            this.txtBoxValibDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRT = new System.Windows.Forms.TextBox();
            this.labReslt = new System.Windows.Forms.Label();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnFirstRec,
            this.toolStripSeparator1,
            this.tsBtnPreRec,
            this.toolStripSeparator2,
            this.tsBtnNextRec,
            this.toolStripSeparator3,
            this.tsBtnLastRec,
            this.toolStripSeparator4,
            this.tsBtnAddRec,
            this.toolStripSeparator5,
            this.tsBtnModify,
            this.toolStripSeparator6,
            this.tsBtnDelete,
            this.toolStripSeparator7,
            this.tsBtnBack,
            this.toolStripSeparator8,
            this.tsBtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnFirstRec
            // 
            this.tsBtnFirstRec.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFirstRec.Image")));
            this.tsBtnFirstRec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFirstRec.Name = "tsBtnFirstRec";
            this.tsBtnFirstRec.Size = new System.Drawing.Size(45, 32);
            this.tsBtnFirstRec.Text = "首记录";
            this.tsBtnFirstRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnFirstRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnFirstRec.Click += new System.EventHandler(this.tsBtnFirstRec_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnPreRec
            // 
            this.tsBtnPreRec.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPreRec.Image")));
            this.tsBtnPreRec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPreRec.Name = "tsBtnPreRec";
            this.tsBtnPreRec.Size = new System.Drawing.Size(45, 32);
            this.tsBtnPreRec.Text = "上记录";
            this.tsBtnPreRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnPreRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnPreRec.Click += new System.EventHandler(this.tsBtnPreRec_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnNextRec
            // 
            this.tsBtnNextRec.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNextRec.Image")));
            this.tsBtnNextRec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNextRec.Name = "tsBtnNextRec";
            this.tsBtnNextRec.Size = new System.Drawing.Size(45, 32);
            this.tsBtnNextRec.Text = "下记录";
            this.tsBtnNextRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnNextRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnNextRec.Click += new System.EventHandler(this.tsBtnNextRec_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnLastRec
            // 
            this.tsBtnLastRec.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLastRec.Image")));
            this.tsBtnLastRec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLastRec.Name = "tsBtnLastRec";
            this.tsBtnLastRec.Size = new System.Drawing.Size(45, 32);
            this.tsBtnLastRec.Text = "尾记录";
            this.tsBtnLastRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnLastRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnLastRec.Click += new System.EventHandler(this.tsBtnLastRec_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnAddRec
            // 
            this.tsBtnAddRec.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAddRec.Image")));
            this.tsBtnAddRec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddRec.Name = "tsBtnAddRec";
            this.tsBtnAddRec.Size = new System.Drawing.Size(33, 32);
            this.tsBtnAddRec.Text = "添加";
            this.tsBtnAddRec.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnAddRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnAddRec.Click += new System.EventHandler(this.tsBtnAddRec_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnModify
            // 
            this.tsBtnModify.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnModify.Image")));
            this.tsBtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnModify.Name = "tsBtnModify";
            this.tsBtnModify.Size = new System.Drawing.Size(33, 32);
            this.tsBtnModify.Text = "修改";
            this.tsBtnModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnModify.Click += new System.EventHandler(this.tsBtnModify_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnDelete
            // 
            this.tsBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDelete.Image")));
            this.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnDelete.Name = "tsBtnDelete";
            this.tsBtnDelete.Size = new System.Drawing.Size(33, 32);
            this.tsBtnDelete.Text = "删除";
            this.tsBtnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnDelete.Click += new System.EventHandler(this.tsBtnDelete_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnBack
            // 
            this.tsBtnBack.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBack.Image")));
            this.tsBtnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBack.Name = "tsBtnBack";
            this.tsBtnBack.Size = new System.Drawing.Size(33, 32);
            this.tsBtnBack.Text = "返回";
            this.tsBtnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBtnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBtnBack.Click += new System.EventHandler(this.tsBtnBack_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(12, 83);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(65, 12);
            this.labName.TabIndex = 1;
            this.labName.Text = "类型名称：";
            // 
            // labCanlend
            // 
            this.labCanlend.AutoSize = true;
            this.labCanlend.Location = new System.Drawing.Point(202, 83);
            this.labCanlend.Name = "labCanlend";
            this.labCanlend.Size = new System.Drawing.Size(77, 12);
            this.labCanlend.TabIndex = 2;
            this.labCanlend.Text = "可借书数量：";
            // 
            // txtBoxTypeName
            // 
            this.txtBoxTypeName.Location = new System.Drawing.Point(82, 78);
            this.txtBoxTypeName.Name = "txtBoxTypeName";
            this.txtBoxTypeName.Size = new System.Drawing.Size(78, 21);
            this.txtBoxTypeName.TabIndex = 3;
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.Location = new System.Drawing.Point(285, 78);
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.Size = new System.Drawing.Size(78, 21);
            this.txtBoxQty.TabIndex = 4;
            // 
            // labCanLendDay
            // 
            this.labCanLendDay.AutoSize = true;
            this.labCanLendDay.Location = new System.Drawing.Point(401, 83);
            this.labCanLendDay.Name = "labCanLendDay";
            this.labCanLendDay.Size = new System.Drawing.Size(77, 12);
            this.labCanLendDay.TabIndex = 5;
            this.labCanLendDay.Text = "可借书天数：";
            // 
            // txtBoxDays
            // 
            this.txtBoxDays.Location = new System.Drawing.Point(480, 78);
            this.txtBoxDays.Name = "txtBoxDays";
            this.txtBoxDays.Size = new System.Drawing.Size(78, 21);
            this.txtBoxDays.TabIndex = 6;
            // 
            // labContinueTimes
            // 
            this.labContinueTimes.AutoSize = true;
            this.labContinueTimes.Location = new System.Drawing.Point(202, 114);
            this.labContinueTimes.Name = "labContinueTimes";
            this.labContinueTimes.Size = new System.Drawing.Size(77, 12);
            this.labContinueTimes.TabIndex = 7;
            this.labContinueTimes.Text = "可续借次数：";
            // 
            // txtBoxCanTimes
            // 
            this.txtBoxCanTimes.Location = new System.Drawing.Point(285, 111);
            this.txtBoxCanTimes.Name = "txtBoxCanTimes";
            this.txtBoxCanTimes.Size = new System.Drawing.Size(78, 21);
            this.txtBoxCanTimes.TabIndex = 8;
            // 
            // labPuniRate
            // 
            this.labPuniRate.AutoSize = true;
            this.labPuniRate.Location = new System.Drawing.Point(12, 114);
            this.labPuniRate.Name = "labPuniRate";
            this.labPuniRate.Size = new System.Drawing.Size(53, 12);
            this.labPuniRate.TabIndex = 9;
            this.labPuniRate.Text = "罚款率：";
            // 
            // txtBoxPnRate
            // 
            this.txtBoxPnRate.Location = new System.Drawing.Point(82, 111);
            this.txtBoxPnRate.Name = "txtBoxPnRate";
            this.txtBoxPnRate.Size = new System.Drawing.Size(78, 21);
            this.txtBoxPnRate.TabIndex = 10;
            // 
            // labValibDate
            // 
            this.labValibDate.AutoSize = true;
            this.labValibDate.Location = new System.Drawing.Point(403, 114);
            this.labValibDate.Name = "labValibDate";
            this.labValibDate.Size = new System.Drawing.Size(77, 12);
            this.labValibDate.TabIndex = 11;
            this.labValibDate.Text = "证件有效期：";
            // 
            // txtBoxValibDate
            // 
            this.txtBoxValibDate.Location = new System.Drawing.Point(480, 109);
            this.txtBoxValibDate.Name = "txtBoxValibDate";
            this.txtBoxValibDate.Size = new System.Drawing.Size(55, 21);
            this.txtBoxValibDate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "年";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvResult);
            this.groupBox1.Location = new System.Drawing.Point(14, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 243);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "结果列表";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(6, 18);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(575, 219);
            this.dgvResult.TabIndex = 15;
            this.dgvResult.SelectionChanged += new System.EventHandler(this.dgvResult_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "读者类型：";
            // 
            // txtBoxRT
            // 
            this.txtBoxRT.Location = new System.Drawing.Point(82, 48);
            this.txtBoxRT.Name = "txtBoxRT";
            this.txtBoxRT.Size = new System.Drawing.Size(78, 21);
            this.txtBoxRT.TabIndex = 16;
            // 
            // labReslt
            // 
            this.labReslt.AutoSize = true;
            this.labReslt.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labReslt.ForeColor = System.Drawing.Color.Red;
            this.labReslt.Location = new System.Drawing.Point(204, 51);
            this.labReslt.Name = "labReslt";
            this.labReslt.Size = new System.Drawing.Size(0, 14);
            this.labReslt.TabIndex = 17;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 35);
            // 
            // tsBtnRefresh
            // 
            this.tsBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRefresh.Image")));
            this.tsBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRefresh.Name = "tsBtnRefresh";
            this.tsBtnRefresh.Size = new System.Drawing.Size(49, 32);
            this.tsBtnRefresh.Text = "刷新";
            this.tsBtnRefresh.Click += new System.EventHandler(this.tsBtnRefresh_Click);
            // 
            // TypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 401);
            this.Controls.Add(this.labReslt);
            this.Controls.Add(this.txtBoxRT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxValibDate);
            this.Controls.Add(this.labValibDate);
            this.Controls.Add(this.txtBoxPnRate);
            this.Controls.Add(this.labPuniRate);
            this.Controls.Add(this.txtBoxCanTimes);
            this.Controls.Add(this.labContinueTimes);
            this.Controls.Add(this.txtBoxDays);
            this.Controls.Add(this.labCanLendDay);
            this.Controls.Add(this.txtBoxQty);
            this.Controls.Add(this.txtBoxTypeName);
            this.Controls.Add(this.labCanlend);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TypeForm";
            this.Text = "读者类别管理";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnFirstRec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnPreRec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnNextRec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnLastRec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsBtnAddRec;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsBtnModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsBtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsBtnBack;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCanlend;
        private System.Windows.Forms.TextBox txtBoxTypeName;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.Label labCanLendDay;
        private System.Windows.Forms.TextBox txtBoxDays;
        private System.Windows.Forms.Label labContinueTimes;
        private System.Windows.Forms.TextBox txtBoxCanTimes;
        private System.Windows.Forms.Label labPuniRate;
        private System.Windows.Forms.TextBox txtBoxPnRate;
        private System.Windows.Forms.Label labValibDate;
        private System.Windows.Forms.TextBox txtBoxValibDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRT;
        private System.Windows.Forms.Label labReslt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsBtnRefresh;
    }
}