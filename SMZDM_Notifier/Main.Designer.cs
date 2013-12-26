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
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.bgwFetchFeed = new System.ComponentModel.BackgroundWorker();
			this.notifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSilentMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.bgwNotify = new System.ComponentModel.BackgroundWorker();
			this.bgwBrowser = new System.ComponentModel.BackgroundWorker();
			this.wbsMain = new System.Windows.Forms.WebBrowser();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
			this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
			this.toolStripNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripStart = new System.Windows.Forms.ToolStripButton();
			this.toolStripStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripPreferences = new System.Windows.Forms.ToolStripButton();
			this.toolStripAbout = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.notifyIconMenuStrip.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStripMain
			// 
			this.statusStripMain.Location = new System.Drawing.Point(0, 618);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Size = new System.Drawing.Size(784, 22);
			this.statusStripMain.TabIndex = 1;
			this.statusStripMain.Text = "statusStrip1";
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
			// wbsMain
			// 
			this.wbsMain.AllowNavigation = false;
			this.wbsMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbsMain.Location = new System.Drawing.Point(3, 60);
			this.wbsMain.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbsMain.Name = "wbsMain";
			this.wbsMain.ScriptErrorsSuppressed = true;
			this.wbsMain.Size = new System.Drawing.Size(778, 555);
			this.wbsMain.TabIndex = 2;
			this.wbsMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbsMain_DocumentCompleted);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.wbsMain, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 618);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// BottomToolStripPanel
			// 
			this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.BottomToolStripPanel.Name = "BottomToolStripPanel";
			this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// TopToolStripPanel
			// 
			this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.TopToolStripPanel.Name = "TopToolStripPanel";
			this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// RightToolStripPanel
			// 
			this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.RightToolStripPanel.Name = "RightToolStripPanel";
			this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// LeftToolStripPanel
			// 
			this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftToolStripPanel.Name = "LeftToolStripPanel";
			this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
			// 
			// ContentPanel
			// 
			this.ContentPanel.Size = new System.Drawing.Size(150, 6);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(544, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(234, 25);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripMain
			// 
			this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPrevious,
            this.toolStripNext,
            this.toolStripStart,
            this.toolStripStop,
            this.toolStripRefresh,
            this.toolStripPreferences,
            this.toolStripAbout,
            this.toolStripSeparator2,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripButton1});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(544, 39);
			this.toolStripMain.TabIndex = 5;
			this.toolStripMain.Text = "toolStrip1";
			// 
			// toolStripPrevious
			// 
			this.toolStripPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrevious.Image")));
			this.toolStripPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripPrevious.Name = "toolStripPrevious";
			this.toolStripPrevious.Size = new System.Drawing.Size(36, 36);
			this.toolStripPrevious.Text = "toolStripButton1";
			// 
			// toolStripNext
			// 
			this.toolStripNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNext.Image")));
			this.toolStripNext.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripNext.Name = "toolStripNext";
			this.toolStripNext.Size = new System.Drawing.Size(36, 36);
			this.toolStripNext.Text = "toolStripButton1";
			// 
			// toolStripStart
			// 
			this.toolStripStart.AutoSize = false;
			this.toolStripStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStart.Image")));
			this.toolStripStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripStart.Name = "toolStripStart";
			this.toolStripStart.Size = new System.Drawing.Size(34, 34);
			this.toolStripStart.Text = "开始抓取";
			// 
			// toolStripStop
			// 
			this.toolStripStop.AutoSize = false;
			this.toolStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStop.Image")));
			this.toolStripStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripStop.Name = "toolStripStop";
			this.toolStripStop.Size = new System.Drawing.Size(34, 34);
			this.toolStripStop.Text = "停止抓取";
			this.toolStripStop.Visible = false;
			// 
			// toolStripRefresh
			// 
			this.toolStripRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRefresh.Image")));
			this.toolStripRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripRefresh.Name = "toolStripRefresh";
			this.toolStripRefresh.Size = new System.Drawing.Size(36, 36);
			this.toolStripRefresh.Text = "刷新";
			// 
			// toolStripPreferences
			// 
			this.toolStripPreferences.AutoSize = false;
			this.toolStripPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripPreferences.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPreferences.Image")));
			this.toolStripPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripPreferences.Name = "toolStripPreferences";
			this.toolStripPreferences.Size = new System.Drawing.Size(34, 34);
			this.toolStripPreferences.Text = "偏好设置";
			// 
			// toolStripAbout
			// 
			this.toolStripAbout.AutoSize = false;
			this.toolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAbout.Image")));
			this.toolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripAbout.Name = "toolStripAbout";
			this.toolStripAbout.Size = new System.Drawing.Size(34, 34);
			this.toolStripAbout.Text = "关于";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "45"});
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(121, 39);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 39);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
			this.toolStripButton1.Text = "toolStripButton1";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanel2.Controls.Add(this.toolStripMain, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 31);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 640);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStripMain);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Main";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.notifyIconMenuStrip.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.ComponentModel.BackgroundWorker bgwFetchFeed;
		private System.Windows.Forms.ContextMenuStrip notifyIconMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSilentMode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.ComponentModel.BackgroundWorker bgwNotify;
		private System.ComponentModel.BackgroundWorker bgwBrowser;
		private System.Windows.Forms.WebBrowser wbsMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ToolStrip toolStripMain;
		private System.Windows.Forms.ToolStripButton toolStripPrevious;
		private System.Windows.Forms.ToolStripButton toolStripNext;
		private System.Windows.Forms.ToolStripButton toolStripStart;
		private System.Windows.Forms.ToolStripButton toolStripStop;
		private System.Windows.Forms.ToolStripButton toolStripRefresh;
		private System.Windows.Forms.ToolStripButton toolStripPreferences;
		private System.Windows.Forms.ToolStripButton toolStripAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
		private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
		private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
		private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
		private System.Windows.Forms.ToolStripContentPanel ContentPanel;
	}
}