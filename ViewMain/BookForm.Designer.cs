/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2013/11/10
 * 时间: 16:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace ViewMain
{
	partial class BookForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书证信息变更ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书证挂失与解除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销借书证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者类型管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PwdChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labLdNum = new System.Windows.Forms.Label();
            this.labb_l = new System.Windows.Forms.Label();
            this.txtBoxState = new System.Windows.Forms.TextBox();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.labDateReg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxDepart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labDepart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserSex = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labUserState = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labUserSex = new System.Windows.Forms.Label();
            this.labUserType = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBoxNewRank = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxRID = new System.Windows.Forms.TextBox();
            this.labAsk = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labResult = new System.Windows.Forms.Label();
            this.btnPwdCancel = new System.Windows.Forms.Button();
            this.btnPwdOk = new System.Windows.Forms.Button();
            this.txtBoxPwdRepeat = new System.Windows.Forms.TextBox();
            this.txtBoxPwdNew = new System.Windows.Forms.TextBox();
            this.txtBoxPwdOld = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BookToolStripMenuItem,
            this.ReaderToolStripMenuItem,
            this.BorrowToolStripMenuItem,
            this.UserToolStripMenuItem,
            this.HelpToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BookToolStripMenuItem
            // 
            this.BookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NBToolStripMenuItem,
            this.BIToolStripMenuItem});
            this.BookToolStripMenuItem.Image = global::ViewMain.Properties.Resources.book2;
            this.BookToolStripMenuItem.Name = "BookToolStripMenuItem";
            this.BookToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.BookToolStripMenuItem.Text = "图书管理";
            // 
            // NBToolStripMenuItem
            // 
            this.NBToolStripMenuItem.Name = "NBToolStripMenuItem";
            this.NBToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.NBToolStripMenuItem.Text = "新书入库";
            this.NBToolStripMenuItem.Click += new System.EventHandler(this.NBToolStripMenuItem_Click);
            // 
            // BIToolStripMenuItem
            // 
            this.BIToolStripMenuItem.Name = "BIToolStripMenuItem";
            this.BIToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.BIToolStripMenuItem.Text = "图书信息维护";
            this.BIToolStripMenuItem.Click += new System.EventHandler(this.BIToolStripMenuItem_Click);
            // 
            // ReaderToolStripMenuItem
            // 
            this.ReaderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeCardToolStripMenuItem,
            this.借书证信息变更ToolStripMenuItem,
            this.借书证挂失与解除ToolStripMenuItem,
            this.注销借书证ToolStripMenuItem,
            this.读者类型管理ToolStripMenuItem});
            this.ReaderToolStripMenuItem.Image = global::ViewMain.Properties.Resources.user1;
            this.ReaderToolStripMenuItem.Name = "ReaderToolStripMenuItem";
            this.ReaderToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ReaderToolStripMenuItem.Text = "读者管理";
            // 
            // MakeCardToolStripMenuItem
            // 
            this.MakeCardToolStripMenuItem.Name = "MakeCardToolStripMenuItem";
            this.MakeCardToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.MakeCardToolStripMenuItem.Text = "办理借书证";
            this.MakeCardToolStripMenuItem.Click += new System.EventHandler(this.MakeCardToolStripMenuItem_Click);
            // 
            // 借书证信息变更ToolStripMenuItem
            // 
            this.借书证信息变更ToolStripMenuItem.Name = "借书证信息变更ToolStripMenuItem";
            this.借书证信息变更ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.借书证信息变更ToolStripMenuItem.Text = "借书证信息变更";
            this.借书证信息变更ToolStripMenuItem.Click += new System.EventHandler(this.ChangeCardToolStripMenuItem_Click);
            // 
            // 借书证挂失与解除ToolStripMenuItem
            // 
            this.借书证挂失与解除ToolStripMenuItem.Name = "借书证挂失与解除ToolStripMenuItem";
            this.借书证挂失与解除ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.借书证挂失与解除ToolStripMenuItem.Text = "借书证挂失与解除";
            this.借书证挂失与解除ToolStripMenuItem.Click += new System.EventHandler(this.LostCardToolStripMenuItem_Click);
            // 
            // 注销借书证ToolStripMenuItem
            // 
            this.注销借书证ToolStripMenuItem.Name = "注销借书证ToolStripMenuItem";
            this.注销借书证ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.注销借书证ToolStripMenuItem.Text = "注销借书证";
            this.注销借书证ToolStripMenuItem.Click += new System.EventHandler(this.CancelCardToolStripMenuItem_Click);
            // 
            // 读者类型管理ToolStripMenuItem
            // 
            this.读者类型管理ToolStripMenuItem.Name = "读者类型管理ToolStripMenuItem";
            this.读者类型管理ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.读者类型管理ToolStripMenuItem.Text = "读者类型管理";
            this.读者类型管理ToolStripMenuItem.Click += new System.EventHandler(this.TypeCardToolStripMenuItem_Click);
            // 
            // BorrowToolStripMenuItem
            // 
            this.BorrowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoToolStripMenuItem,
            this.rbToolStripMenuItem,
            this.rtToolStripMenuItem});
            this.BorrowToolStripMenuItem.Image = global::ViewMain.Properties.Resources.qian;
            this.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem";
            this.BorrowToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.BorrowToolStripMenuItem.Text = "借阅管理";
            // 
            // BoToolStripMenuItem
            // 
            this.BoToolStripMenuItem.Name = "BoToolStripMenuItem";
            this.BoToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.BoToolStripMenuItem.Text = "借书";
            this.BoToolStripMenuItem.Click += new System.EventHandler(this.BoToolStripMenuItem_Click);
            // 
            // rbToolStripMenuItem
            // 
            this.rbToolStripMenuItem.Name = "rbToolStripMenuItem";
            this.rbToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.rbToolStripMenuItem.Text = "续借";
            this.rbToolStripMenuItem.Click += new System.EventHandler(this.rbToolStripMenuItem_Click);
            // 
            // rtToolStripMenuItem
            // 
            this.rtToolStripMenuItem.Name = "rtToolStripMenuItem";
            this.rtToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.rtToolStripMenuItem.Text = "还书";
            this.rtToolStripMenuItem.Click += new System.EventHandler(this.rtToolStripMenuItem_Click);
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RankToolStripMenuItem,
            this.PwdChangeToolStripMenuItem});
            this.UserToolStripMenuItem.Image = global::ViewMain.Properties.Resources.users;
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.UserToolStripMenuItem.Text = "用户管理";
            // 
            // RankToolStripMenuItem
            // 
            this.RankToolStripMenuItem.Name = "RankToolStripMenuItem";
            this.RankToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.RankToolStripMenuItem.Text = "权限管理";
            // 
            // PwdChangeToolStripMenuItem
            // 
            this.PwdChangeToolStripMenuItem.Name = "PwdChangeToolStripMenuItem";
            this.PwdChangeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.PwdChangeToolStripMenuItem.Text = "密码修改";
            this.PwdChangeToolStripMenuItem.Click += new System.EventHandler(this.PwdChangeToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.HelpToolStripMenuItem.Image = global::ViewMain.Properties.Resources.help;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "关于";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::ViewMain.Properties.Resources.exit;
            this.ExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(510, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labDate
            // 
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labLdNum);
            this.groupBox1.Controls.Add(this.labb_l);
            this.groupBox1.Controls.Add(this.txtBoxState);
            this.groupBox1.Controls.Add(this.txtBoxType);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.labDateReg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxMail);
            this.groupBox1.Controls.Add(this.txtBoxTel);
            this.groupBox1.Controls.Add(this.txtBoxDepart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labPhone);
            this.groupBox1.Controls.Add(this.labDepart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserSex);
            this.groupBox1.Controls.Add(this.txtUserID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labUserState);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.labUserSex);
            this.groupBox1.Controls.Add(this.labUserType);
            this.groupBox1.Controls.Add(this.labUserName);
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前用户信息";
            // 
            // labLdNum
            // 
            this.labLdNum.AutoSize = true;
            this.labLdNum.Location = new System.Drawing.Point(223, 220);
            this.labLdNum.Name = "labLdNum";
            this.labLdNum.Size = new System.Drawing.Size(59, 12);
            this.labLdNum.TabIndex = 25;
            this.labLdNum.Text = "labLd_Num";
            // 
            // labb_l
            // 
            this.labb_l.AutoSize = true;
            this.labb_l.Location = new System.Drawing.Point(220, 190);
            this.labb_l.Name = "labb_l";
            this.labb_l.Size = new System.Drawing.Size(71, 12);
            this.labb_l.TabIndex = 24;
            this.labb_l.Text = "已借/可借：";
            // 
            // txtBoxState
            // 
            this.txtBoxState.Location = new System.Drawing.Point(222, 127);
            this.txtBoxState.Name = "txtBoxState";
            this.txtBoxState.ReadOnly = true;
            this.txtBoxState.Size = new System.Drawing.Size(66, 21);
            this.txtBoxState.TabIndex = 23;
            // 
            // txtBoxType
            // 
            this.txtBoxType.Location = new System.Drawing.Point(222, 99);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.ReadOnly = true;
            this.txtBoxType.Size = new System.Drawing.Size(66, 21);
            this.txtBoxType.TabIndex = 22;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(223, 43);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(66, 21);
            this.txtBoxName.TabIndex = 21;
            // 
            // labDateReg
            // 
            this.labDateReg.AutoSize = true;
            this.labDateReg.Location = new System.Drawing.Point(220, 157);
            this.labDateReg.Name = "labDateReg";
            this.labDateReg.Size = new System.Drawing.Size(47, 12);
            this.labDateReg.TabIndex = 20;
            this.labDateReg.Text = "labDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(145, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "注册时间：";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(87, 249);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.ReadOnly = true;
            this.txtBoxMail.Size = new System.Drawing.Size(115, 21);
            this.txtBoxMail.TabIndex = 18;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(87, 217);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.ReadOnly = true;
            this.txtBoxTel.Size = new System.Drawing.Size(115, 21);
            this.txtBoxTel.TabIndex = 17;
            // 
            // txtBoxDepart
            // 
            this.txtBoxDepart.Location = new System.Drawing.Point(87, 187);
            this.txtBoxDepart.Name = "txtBoxDepart";
            this.txtBoxDepart.ReadOnly = true;
            this.txtBoxDepart.Size = new System.Drawing.Size(115, 21);
            this.txtBoxDepart.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "用户邮箱：";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(14, 220);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(65, 12);
            this.labPhone.TabIndex = 14;
            this.labPhone.Text = "联系电话：";
            // 
            // labDepart
            // 
            this.labDepart.AutoSize = true;
            this.labDepart.Location = new System.Drawing.Point(15, 190);
            this.labDepart.Name = "labDepart";
            this.labDepart.Size = new System.Drawing.Size(65, 12);
            this.labDepart.TabIndex = 13;
            this.labDepart.Text = "院系单位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "120*120";
            // 
            // txtUserSex
            // 
            this.txtUserSex.AutoSize = true;
            this.txtUserSex.Location = new System.Drawing.Point(221, 75);
            this.txtUserSex.Name = "txtUserSex";
            this.txtUserSex.Size = new System.Drawing.Size(65, 12);
            this.txtUserSex.TabIndex = 8;
            this.txtUserSex.Text = "txtUserSex";
            // 
            // txtUserID
            // 
            this.txtUserID.AutoSize = true;
            this.txtUserID.Location = new System.Drawing.Point(221, 22);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(59, 12);
            this.txtUserID.TabIndex = 6;
            this.txtUserID.Text = "txtUserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(146, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户ID:";
            // 
            // labUserState
            // 
            this.labUserState.AutoSize = true;
            this.labUserState.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserState.Location = new System.Drawing.Point(146, 129);
            this.labUserState.Name = "labUserState";
            this.labUserState.Size = new System.Drawing.Size(70, 14);
            this.labUserState.TabIndex = 4;
            this.labUserState.Text = "用户状态:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ViewMain.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(13, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labUserSex
            // 
            this.labUserSex.AutoSize = true;
            this.labUserSex.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserSex.Location = new System.Drawing.Point(146, 72);
            this.labUserSex.Name = "labUserSex";
            this.labUserSex.Size = new System.Drawing.Size(70, 14);
            this.labUserSex.TabIndex = 2;
            this.labUserSex.Text = "用户性别:";
            // 
            // labUserType
            // 
            this.labUserType.AutoSize = true;
            this.labUserType.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserType.Location = new System.Drawing.Point(146, 101);
            this.labUserType.Name = "labUserType";
            this.labUserType.Size = new System.Drawing.Size(70, 14);
            this.labUserType.TabIndex = 1;
            this.labUserType.Text = "用户类型:";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labUserName.Location = new System.Drawing.Point(146, 45);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(63, 14);
            this.labUserName.TabIndex = 0;
            this.labUserName.Text = "用户名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBoxNewRank);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxRID);
            this.groupBox2.Controls.Add(this.labAsk);
            this.groupBox2.Controls.Add(this.btnCommit);
            this.groupBox2.Location = new System.Drawing.Point(321, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 105);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "权限管理";
            // 
            // CBoxNewRank
            // 
            this.CBoxNewRank.FormattingEnabled = true;
            this.CBoxNewRank.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "4",
            "8",
            "15"});
            this.CBoxNewRank.Location = new System.Drawing.Point(66, 57);
            this.CBoxNewRank.Name = "CBoxNewRank";
            this.CBoxNewRank.Size = new System.Drawing.Size(40, 20);
            this.CBoxNewRank.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "新权限:";
            // 
            // txtBoxRID
            // 
            this.txtBoxRID.Location = new System.Drawing.Point(66, 19);
            this.txtBoxRID.Name = "txtBoxRID";
            this.txtBoxRID.Size = new System.Drawing.Size(80, 21);
            this.txtBoxRID.TabIndex = 4;
            // 
            // labAsk
            // 
            this.labAsk.AutoSize = true;
            this.labAsk.ForeColor = System.Drawing.Color.Red;
            this.labAsk.Location = new System.Drawing.Point(12, 23);
            this.labAsk.Name = "labAsk";
            this.labAsk.Size = new System.Drawing.Size(47, 12);
            this.labAsk.TabIndex = 3;
            this.labAsk.Text = "用户ID:";
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(124, 56);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(37, 23);
            this.btnCommit.TabIndex = 0;
            this.btnCommit.Text = "提交";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labResult);
            this.groupBox3.Controls.Add(this.btnPwdCancel);
            this.groupBox3.Controls.Add(this.btnPwdOk);
            this.groupBox3.Controls.Add(this.txtBoxPwdRepeat);
            this.groupBox3.Controls.Add(this.txtBoxPwdNew);
            this.groupBox3.Controls.Add(this.txtBoxPwdOld);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(321, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 169);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "修改密码";
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.ForeColor = System.Drawing.Color.Red;
            this.labResult.Location = new System.Drawing.Point(18, 112);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(0, 12);
            this.labResult.TabIndex = 8;
            // 
            // btnPwdCancel
            // 
            this.btnPwdCancel.Location = new System.Drawing.Point(100, 129);
            this.btnPwdCancel.Name = "btnPwdCancel";
            this.btnPwdCancel.Size = new System.Drawing.Size(55, 23);
            this.btnPwdCancel.TabIndex = 7;
            this.btnPwdCancel.Text = "取消";
            this.btnPwdCancel.UseVisualStyleBackColor = true;
            this.btnPwdCancel.Click += new System.EventHandler(this.btnPwdCancel_Click);
            // 
            // btnPwdOk
            // 
            this.btnPwdOk.Location = new System.Drawing.Point(18, 130);
            this.btnPwdOk.Name = "btnPwdOk";
            this.btnPwdOk.Size = new System.Drawing.Size(55, 23);
            this.btnPwdOk.TabIndex = 6;
            this.btnPwdOk.Text = "确定";
            this.btnPwdOk.UseVisualStyleBackColor = true;
            this.btnPwdOk.Click += new System.EventHandler(this.btnPwdOk_Click);
            // 
            // txtBoxPwdRepeat
            // 
            this.txtBoxPwdRepeat.Location = new System.Drawing.Point(78, 80);
            this.txtBoxPwdRepeat.Name = "txtBoxPwdRepeat";
            this.txtBoxPwdRepeat.PasswordChar = '*';
            this.txtBoxPwdRepeat.Size = new System.Drawing.Size(80, 21);
            this.txtBoxPwdRepeat.TabIndex = 5;
            // 
            // txtBoxPwdNew
            // 
            this.txtBoxPwdNew.Location = new System.Drawing.Point(78, 52);
            this.txtBoxPwdNew.Name = "txtBoxPwdNew";
            this.txtBoxPwdNew.PasswordChar = '*';
            this.txtBoxPwdNew.Size = new System.Drawing.Size(80, 21);
            this.txtBoxPwdNew.TabIndex = 4;
            // 
            // txtBoxPwdOld
            // 
            this.txtBoxPwdOld.Location = new System.Drawing.Point(78, 22);
            this.txtBoxPwdOld.Name = "txtBoxPwdOld";
            this.txtBoxPwdOld.PasswordChar = '*';
            this.txtBoxPwdOld.Size = new System.Drawing.Size(80, 21);
            this.txtBoxPwdOld.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "重复密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "新密码：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "旧密码：";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 354);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookForm";
            this.Text = "BookMan v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MakeCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书证信息变更ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书证挂失与解除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销借书证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者类型管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PwdChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labUserType;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labUserSex;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labUserState;
        private System.Windows.Forms.Label txtUserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUserSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxDepart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labDepart;
        private System.Windows.Forms.Label labDateReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxState;
        private System.Windows.Forms.TextBox txtBoxType;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labAsk;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label labb_l;
        private System.Windows.Forms.Label labLdNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPwdCancel;
        private System.Windows.Forms.Button btnPwdOk;
        private System.Windows.Forms.TextBox txtBoxPwdRepeat;
        private System.Windows.Forms.TextBox txtBoxPwdNew;
        private System.Windows.Forms.TextBox txtBoxPwdOld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.ComboBox CBoxNewRank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxRID;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
	}
}
