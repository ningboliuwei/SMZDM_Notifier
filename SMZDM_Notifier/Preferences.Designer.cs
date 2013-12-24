namespace SMZDM_Notifier
{
	partial class Preferences
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.chkAutoStartFetching = new System.Windows.Forms.CheckBox();
			this.chkMinimizeWhenStartup = new System.Windows.Forms.CheckBox();
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDefault = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.cmbRefreshInterval = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 341);
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
			this.tableLayoutPanel3.Controls.Add(this.cmbRefreshInterval, 1, 5);
			this.tableLayoutPanel3.Controls.Add(this.chkAutoStartFetching, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.chkMinimizeWhenStartup, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.chkMinimizeWhenClose, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 5);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.chkStartupWithSystem, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.chkSilentMode, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.cmbLocationToShow, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.cmbNotifyStayTime, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.cmbKeepMessageAmount, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 18);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 7;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 176);
			this.tableLayoutPanel3.TabIndex = 11;
			// 
			// chkAutoStartFetching
			// 
			this.chkAutoStartFetching.AutoSize = true;
			this.chkAutoStartFetching.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkAutoStartFetching.Location = new System.Drawing.Point(133, 33);
			this.chkAutoStartFetching.Name = "chkAutoStartFetching";
			this.chkAutoStartFetching.Size = new System.Drawing.Size(114, 24);
			this.chkAutoStartFetching.TabIndex = 16;
			this.chkAutoStartFetching.Text = "自动开始抓取";
			this.chkAutoStartFetching.UseVisualStyleBackColor = true;
			// 
			// chkMinimizeWhenStartup
			// 
			this.chkMinimizeWhenStartup.AutoSize = true;
			this.chkMinimizeWhenStartup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chkMinimizeWhenStartup.Location = new System.Drawing.Point(3, 33);
			this.chkMinimizeWhenStartup.Name = "chkMinimizeWhenStartup";
			this.chkMinimizeWhenStartup.Size = new System.Drawing.Size(124, 24);
			this.chkMinimizeWhenStartup.TabIndex = 15;
			this.chkMinimizeWhenStartup.Text = "启动时最小化";
			this.chkMinimizeWhenStartup.UseVisualStyleBackColor = true;
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
			this.label4.Location = new System.Drawing.Point(3, 150);
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
			this.label3.Location = new System.Drawing.Point(3, 120);
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
			this.cmbLocationToShow.Location = new System.Drawing.Point(133, 123);
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
			this.cmbNotifyStayTime.Location = new System.Drawing.Point(133, 63);
			this.cmbNotifyStayTime.Name = "cmbNotifyStayTime";
			this.cmbNotifyStayTime.Size = new System.Drawing.Size(240, 23);
			this.cmbNotifyStayTime.TabIndex = 5;
			this.cmbNotifyStayTime.SelectedIndexChanged += new System.EventHandler(this.cmbNotifyStayTime_SelectedIndexChanged);
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
			this.cmbKeepMessageAmount.Location = new System.Drawing.Point(133, 93);
			this.cmbKeepMessageAmount.Name = "cmbKeepMessageAmount";
			this.cmbKeepMessageAmount.Size = new System.Drawing.Size(240, 23);
			this.cmbKeepMessageAmount.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 90);
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
			this.label1.Location = new System.Drawing.Point(3, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 30);
			this.label1.TabIndex = 4;
			this.label1.Text = "提醒停留时间（秒）";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Controls.Add(this.btnDefault, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnCancel, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnOK, 0, 0);
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
			this.btnDefault.Location = new System.Drawing.Point(257, 3);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(122, 39);
			this.btnDefault.TabIndex = 3;
			this.btnDefault.Text = "默认(&D)";
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnCancel.Location = new System.Drawing.Point(130, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(121, 39);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "取消(&C)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnOK.Location = new System.Drawing.Point(3, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(121, 39);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "确定(&O)";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// cmbRefreshInterval
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.cmbRefreshInterval, 2);
			this.cmbRefreshInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbRefreshInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRefreshInterval.FormattingEnabled = true;
			this.cmbRefreshInterval.Items.AddRange(new object[] {
            "30",
            "60",
            "120",
            "300"});
			this.cmbRefreshInterval.Location = new System.Drawing.Point(133, 153);
			this.cmbRefreshInterval.Name = "cmbRefreshInterval";
			this.cmbRefreshInterval.Size = new System.Drawing.Size(240, 23);
			this.cmbRefreshInterval.TabIndex = 17;
			// 
			// Preferences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 341);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Preferences";
			this.ShowInTaskbar = false;
			this.Text = "“什么值得买”小助手";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
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
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox chkMinimizeWhenClose;
		private System.Windows.Forms.Button btnDefault;
		private System.Windows.Forms.CheckBox chkMinimizeWhenStartup;
		private System.Windows.Forms.CheckBox chkAutoStartFetching;
		private System.Windows.Forms.ComboBox cmbRefreshInterval;
	}
}

