namespace SMZDM_Notifier
{
	partial class Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.bgwFetchFeed = new System.ComponentModel.BackgroundWorker();
			this.notifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSilentMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.bgwNotify = new System.ComponentModel.BackgroundWorker();
			this.bgwBrowser = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.wbsMain = new System.Windows.Forms.WebBrowser();
			this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripTextBoxKeyword = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripComboBoxChannel = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonChannel = new System.Windows.Forms.ToolStripButton();
			this.notifyIconMenuStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// bgwFetchFeed
			// 
			this.bgwFetchFeed.WorkerSupportsCancellation = true;
			this.bgwFetchFeed.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFetchFeed_DoWork);
			this.bgwFetchFeed.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwFetchFeed_RunWorkerCompleted);
			// 
			// notifyIconMenuStrip
			// 
			this.notifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemSilentMode,
            this.toolStripMenuItemExit});
			this.notifyIconMenuStrip.Name = "notifyIconMenuStrip";
			this.notifyIconMenuStrip.Size = new System.Drawing.Size(135, 70);
			// 
			// toolStripMenuItemShow
			// 
			this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
			this.toolStripMenuItemShow.Size = new System.Drawing.Size(134, 22);
			this.toolStripMenuItemShow.Text = "显示(&S)";
			// 
			// toolStripMenuItemSilentMode
			// 
			this.toolStripMenuItemSilentMode.CheckOnClick = true;
			this.toolStripMenuItemSilentMode.Name = "toolStripMenuItemSilentMode";
			this.toolStripMenuItemSilentMode.Size = new System.Drawing.Size(134, 22);
			this.toolStripMenuItemSilentMode.Text = "安静模式(&L)";
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(134, 22);
			this.toolStripMenuItemExit.Text = "退出(&X)";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.ContextMenuStrip = this.notifyIconMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "什么值得买小助手";
			this.notifyIcon.Visible = true;
			// 
			// bgwNotify
			// 
			this.bgwNotify.WorkerSupportsCancellation = true;
			// 
			// bgwBrowser
			// 
			this.bgwBrowser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwBrowser_DoWork);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.statusStripMain, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.toolStripMain, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.wbsMain, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 640);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// statusStripMain
			// 
			this.statusStripMain.Location = new System.Drawing.Point(0, 618);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(784, 22);
			this.statusStripMain.TabIndex = 0;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// toolStripMain
			// 
			this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripButtonRefresh,
            this.toolStripButtonAbout,
            this.toolStripButton5,
            this.toolStripButtonSearch,
            this.toolStripTextBoxKeyword,
            this.toolStripSeparator1,
            this.toolStripComboBoxChannel,
            this.toolStripButtonChannel,
            this.toolStripSeparator2});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(784, 71);
			this.toolStripMain.TabIndex = 1;
			// 
			// toolStripButtonStart
			// 
			this.toolStripButtonStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
			this.toolStripButtonStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStart.Name = "toolStripButtonStart";
			this.toolStripButtonStart.Size = new System.Drawing.Size(68, 68);
			this.toolStripButtonStart.Text = "开始抓取";
			this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
			// 
			// toolStripButtonStop
			// 
			this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
			this.toolStripButtonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonStop.Name = "toolStripButtonStop";
			this.toolStripButtonStop.Size = new System.Drawing.Size(68, 68);
			this.toolStripButtonStop.Text = "停止抓取";
			this.toolStripButtonStop.Visible = false;
			this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
			// 
			// toolStripButtonRefresh
			// 
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
			this.toolStripButtonRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
			this.toolStripButtonRefresh.Size = new System.Drawing.Size(68, 68);
			this.toolStripButtonRefresh.Text = "刷新";
			this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
			this.toolStripButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Size = new System.Drawing.Size(68, 68);
			this.toolStripButtonAbout.Text = "设置";
			this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonPreferences_Click);
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(68, 68);
			this.toolStripButton5.Text = "关于";
			this.toolStripButton5.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
			// 
			// wbsMain
			// 
			this.wbsMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbsMain.Location = new System.Drawing.Point(3, 74);
			this.wbsMain.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbsMain.Name = "wbsMain";
			this.wbsMain.Size = new System.Drawing.Size(778, 541);
			this.wbsMain.TabIndex = 2;
			// 
			// toolStripButtonSearch
			// 
			this.toolStripButtonSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSearch.Image")));
			this.toolStripButtonSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSearch.Name = "toolStripButtonSearch";
			this.toolStripButtonSearch.Size = new System.Drawing.Size(68, 68);
			this.toolStripButtonSearch.Text = "搜索";
			// 
			// toolStripTextBoxKeyword
			// 
			this.toolStripTextBoxKeyword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripTextBoxKeyword.Name = "toolStripTextBoxKeyword";
			this.toolStripTextBoxKeyword.Size = new System.Drawing.Size(100, 71);
			// 
			// toolStripComboBoxChannel
			// 
			this.toolStripComboBoxChannel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripComboBoxChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxChannel.Name = "toolStripComboBoxChannel";
			this.toolStripComboBoxChannel.Size = new System.Drawing.Size(121, 71);
			this.toolStripComboBoxChannel.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxChannel_SelectedIndexChanged);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
			// 
			// toolStripButtonChannel
			// 
			this.toolStripButtonChannel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonChannel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonChannel.Image")));
			this.toolStripButtonChannel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButtonChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonChannel.Name = "toolStripButtonChannel";
			this.toolStripButtonChannel.Size = new System.Drawing.Size(68, 68);
			this.toolStripButtonChannel.Text = "频道";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 640);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Main";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.notifyIconMenuStrip.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.BackgroundWorker bgwFetchFeed;
		private System.Windows.Forms.ContextMenuStrip notifyIconMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSilentMode;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.ComponentModel.BackgroundWorker bgwNotify;
		private System.ComponentModel.BackgroundWorker bgwBrowser;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStrip toolStripMain;
		private System.Windows.Forms.ToolStripButton toolStripButtonStart;
		private System.Windows.Forms.ToolStripButton toolStripButtonStop;
		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
		private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.WebBrowser wbsMain;
		private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxKeyword;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxChannel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonChannel;
	}
}