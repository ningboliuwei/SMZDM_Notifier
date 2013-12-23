namespace SMZDM_Notifier
{
	partial class Main
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.chkMinimizeWhenClose = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.chkStartupWithSystem = new System.Windows.Forms.CheckBox();
			this.chkSilentMode = new System.Windows.Forms.CheckBox();
			this.cmbLocationToShow = new System.Windows.Forms.ComboBox();
			this.cmbNotifyStayTime = new System.Windows.Forms.ComboBox();
			this.cmbKeepMessageAmount = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRefreshInterval = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDefault = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnApply = new System.Windows.Forms.Button();
			this.btnGetFeed = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSilentMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.bgwGetFeed = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.notifyIconMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 341);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(382, 197);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "基本设置";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
			this.tableLayoutPanel3.Controls.Add(this.chkMinimizeWhenClose, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.chkStartupWithSystem, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.chkSilentMode, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.cmbLocationToShow, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.cmbNotifyStayTime, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.cmbKeepMessageAmount, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.txtRefreshInterval, 1, 4);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 6;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 176);
			this.tableLayoutPanel3.TabIndex = 11;
			// 
			// chkMinimizeWhenClose
			// 
			this.chkMinimizeWhenClose.AutoSize = true;
			this.chkMinimizeWhenClose.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkMinimizeWhenClose.Location = new System.Drawing.Point(133, 3);
			this.chkMinimizeWhenClose.Name = "chkMinimizeWhenClose";
			this.chkMinimizeWhenClose.Size = new System.Drawing.Size(114, 24);
			this.chkMinimizeWhenClose.TabIndex = 14;
			this.chkMinimizeWhenClose.Text = "关闭仍最小化";
			this.chkMinimizeWhenClose.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 30);
			this.label4.TabIndex = 12;
			this.label4.Text = "自动刷新间隔（秒）";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 30);
			this.label3.TabIndex = 11;
			this.label3.Text = "商品所在地区选择";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chkStartupWithSystem
			// 
			this.chkStartupWithSystem.AutoSize = true;
			this.chkStartupWithSystem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkStartupWithSystem.Location = new System.Drawing.Point(3, 3);
			this.chkStartupWithSystem.Name = "chkStartupWithSystem";
			this.chkStartupWithSystem.Size = new System.Drawing.Size(124, 24);
			this.chkStartupWithSystem.TabIndex = 2;
			this.chkStartupWithSystem.Text = "随系统启动";
			this.chkStartupWithSystem.UseVisualStyleBackColor = true;
			// 
			// chkSilentMode
			// 
			this.chkSilentMode.AutoSize = true;
			this.chkSilentMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkSilentMode.Location = new System.Drawing.Point(253, 3);
			this.chkSilentMode.Name = "chkSilentMode";
			this.chkSilentMode.Size = new System.Drawing.Size(120, 24);
			this.chkSilentMode.TabIndex = 3;
			this.chkSilentMode.Text = "安静模式(不弹窗)";
			this.chkSilentMode.UseVisualStyleBackColor = true;
			// 
			// cmbLocationToShow
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.cmbLocationToShow, 2);
			this.cmbLocationToShow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbLocationToShow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLocationToShow.FormattingEnabled = true;
			this.cmbLocationToShow.Items.AddRange(new object[] {
            "全部",
            "仅国内",
            "仅国外"});
			this.cmbLocationToShow.Location = new System.Drawing.Point(133, 93);
			this.cmbLocationToShow.Name = "cmbLocationToShow";
			this.cmbLocationToShow.Size = new System.Drawing.Size(240, 23);
			this.cmbLocationToShow.TabIndex = 10;
			// 
			// cmbNotifyStayTime
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.cmbNotifyStayTime, 2);
			this.cmbNotifyStayTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbNotifyStayTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbNotifyStayTime.FormattingEnabled = true;
			this.cmbNotifyStayTime.Items.AddRange(new object[] {
            "3",
            "5",
            "10",
            "20"});
			this.cmbNotifyStayTime.Location = new System.Drawing.Point(133, 33);
			this.cmbNotifyStayTime.Name = "cmbNotifyStayTime";
			this.cmbNotifyStayTime.Size = new System.Drawing.Size(240, 23);
			this.cmbNotifyStayTime.TabIndex = 5;
			// 
			// cmbKeepMessageAmount
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.cmbKeepMessageAmount, 2);
			this.cmbKeepMessageAmount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbKeepMessageAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKeepMessageAmount.FormattingEnabled = true;
			this.cmbKeepMessageAmount.Items.AddRange(new object[] {
            "100",
            "200",
            "500",
            "1000",
            "5000",
            "10000"});
			this.cmbKeepMessageAmount.Location = new System.Drawing.Point(133, 63);
			this.cmbKeepMessageAmount.Name = "cmbKeepMessageAmount";
			this.cmbKeepMessageAmount.Size = new System.Drawing.Size(240, 23);
			this.cmbKeepMessageAmount.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 30);
			this.label2.TabIndex = 7;
			this.label2.Text = "最近信息保留条数";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "提醒停留时间（秒）";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtRefreshInterval
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.txtRefreshInterval, 2);
			this.txtRefreshInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRefreshInterval.Location = new System.Drawing.Point(133, 123);
			this.txtRefreshInterval.Name = "txtRefreshInterval";
			this.txtRefreshInterval.Size = new System.Drawing.Size(240, 22);
			this.txtRefreshInterval.TabIndex = 13;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel4);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 206);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(382, 81);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "频道选择";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.Controls.Add(this.checkBox3, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.checkBox6, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.checkBox7, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.checkBox4, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.checkBox5, 1, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 18);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(376, 60);
			this.tableLayoutPanel4.TabIndex = 0;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox3.Location = new System.Drawing.Point(3, 3);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(119, 24);
			this.checkBox3.TabIndex = 22;
			this.checkBox3.Text = "优惠精选";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox6.Location = new System.Drawing.Point(128, 33);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(119, 24);
			this.checkBox6.TabIndex = 25;
			this.checkBox6.Text = "经验盒子";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// checkBox7
			// 
			this.checkBox7.AutoSize = true;
			this.checkBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox7.Location = new System.Drawing.Point(3, 33);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(119, 24);
			this.checkBox7.TabIndex = 26;
			this.checkBox7.Text = "晒物广场";
			this.checkBox7.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox4.Location = new System.Drawing.Point(253, 3);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(120, 24);
			this.checkBox4.TabIndex = 23;
			this.checkBox4.Text = "海淘专区";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox5.Location = new System.Drawing.Point(128, 3);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(119, 24);
			this.checkBox5.TabIndex = 24;
			this.checkBox5.Text = "发现频道";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.btnDefault, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnApply, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnGetFeed, 3, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 293);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 45);
			this.tableLayoutPanel2.TabIndex = 18;
			// 
			// btnDefault
			// 
			this.btnDefault.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDefault.Location = new System.Drawing.Point(98, 3);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(89, 39);
			this.btnDefault.TabIndex = 2;
			this.btnDefault.Text = "恢复默认(&D)";
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(193, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(89, 39);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "放弃修改(&C)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnApply
			// 
			this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnApply.Location = new System.Drawing.Point(3, 3);
			this.btnApply.Name = "btnApply";
			this.btnApply.Size = new System.Drawing.Size(89, 39);
			this.btnApply.TabIndex = 0;
			this.btnApply.Text = "应用设置(&A)";
			this.btnApply.UseVisualStyleBackColor = true;
			this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
			// 
			// btnGetFeed
			// 
			this.btnGetFeed.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnGetFeed.Location = new System.Drawing.Point(288, 3);
			this.btnGetFeed.Name = "btnGetFeed";
			this.btnGetFeed.Size = new System.Drawing.Size(91, 39);
			this.btnGetFeed.TabIndex = 3;
			this.btnGetFeed.Text = "开始抓取(&S)";
			this.btnGetFeed.UseVisualStyleBackColor = true;
			this.btnGetFeed.Click += new System.EventHandler(this.btnGetFeed_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.ContextMenuStrip = this.notifyIconMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "什么值得买小助手";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
			this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
			// 
			// notifyIconMenuStrip
			// 
			this.notifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemSilentMode,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
			this.notifyIconMenuStrip.Name = "notifyIconMenuStrip";
			this.notifyIconMenuStrip.Size = new System.Drawing.Size(135, 76);
			// 
			// toolStripMenuItemShow
			// 
			this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
			this.toolStripMenuItemShow.Size = new System.Drawing.Size(134, 22);
			this.toolStripMenuItemShow.Text = "显示(&S)";
			this.toolStripMenuItemShow.Click += new System.EventHandler(this.toolStripMenuItemShow_Click);
			// 
			// toolStripMenuItemSilentMode
			// 
			this.toolStripMenuItemSilentMode.CheckOnClick = true;
			this.toolStripMenuItemSilentMode.Name = "toolStripMenuItemSilentMode";
			this.toolStripMenuItemSilentMode.Size = new System.Drawing.Size(134, 22);
			this.toolStripMenuItemSilentMode.Text = "安静模式(&L)";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(134, 22);
			this.toolStripMenuItemExit.Text = "退出(&X)";
			// 
			// bgwGetFeed
			// 
			this.bgwGetFeed.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwGetFeed_DoWork);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(388, 341);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Main";
			this.ShowInTaskbar = false;
			this.Text = "“什么值得买”小助手";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.notifyIconMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbNotifyStayTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkSilentMode;
		private System.Windows.Forms.CheckBox chkStartupWithSystem;
		private System.Windows.Forms.ComboBox cmbLocationToShow;
		private System.Windows.Forms.ComboBox cmbKeepMessageAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnApply;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRefreshInterval;
		private System.Windows.Forms.CheckBox chkMinimizeWhenClose;
		private System.Windows.Forms.Button btnDefault;
		private System.Windows.Forms.ContextMenuStrip notifyIconMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSilentMode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.ComponentModel.BackgroundWorker bgwGetFeed;
		private System.Windows.Forms.Button btnGetFeed;
	}
}

