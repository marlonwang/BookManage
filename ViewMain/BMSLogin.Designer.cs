namespace ViewMain
{
    partial class BMSLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labPwd = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.labNotice = new System.Windows.Forms.Label();
            this.labInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ViewMain.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLogout);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.labPwd);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labType);
            this.groupBox1.Location = new System.Drawing.Point(188, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户登录";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(138, 166);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(54, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "退出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(46, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(54, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(97, 109);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(95, 21);
            this.txtPwd.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(97, 74);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(95, 21);
            this.txtUser.TabIndex = 4;
            // 
            // labPwd
            // 
            this.labPwd.AutoSize = true;
            this.labPwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPwd.Location = new System.Drawing.Point(23, 112);
            this.labPwd.Name = "labPwd";
            this.labPwd.Size = new System.Drawing.Size(53, 14);
            this.labPwd.TabIndex = 3;
            this.labPwd.Text = "密 码:";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(20, 82);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 14);
            this.labName.TabIndex = 2;
            this.labName.Text = "用户名:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "普通用户",
            "管理员"});
            this.comboBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "普通读者",
            "管理人员"});
            this.comboBox1.Location = new System.Drawing.Point(97, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("宋体", 9F);
            this.labType.Location = new System.Drawing.Point(22, 35);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(53, 12);
            this.labType.TabIndex = 0;
            this.labType.Text = "用户类型";
            // 
            // labNotice
            // 
            this.labNotice.AutoSize = true;
            this.labNotice.ForeColor = System.Drawing.Color.Red;
            this.labNotice.Location = new System.Drawing.Point(25, 218);
            this.labNotice.Name = "labNotice";
            this.labNotice.Size = new System.Drawing.Size(59, 12);
            this.labNotice.TabIndex = 2;
            this.labNotice.Text = "登录信息:";
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Location = new System.Drawing.Point(43, 244);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(107, 12);
            this.labInfo.TabIndex = 3;
            this.labInfo.Text = "^_^ 请登录后使用!";
            // 
            // BMSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 295);
            this.Controls.Add(this.labInfo);
            this.Controls.Add(this.labNotice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BMSLogin";
            this.Text = "用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label labPwd;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labNotice;
        private System.Windows.Forms.Label labInfo;
    }
}