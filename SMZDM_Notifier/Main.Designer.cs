﻿namespace SMZDM_Notifier
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolStripStart = new System.Windows.Forms.ToolStripButton();
			this.toolStripStop = new System.Windows.Forms.ToolStripButton();
			this.toolStripPreferences = new System.Windows.Forms.ToolStripButton();
			this.toolStripAbout = new System.Windows.Forms.ToolStripButton();
			this.bgwFetchFeed = new System.ComponentModel.BackgroundWorker();
			this.notifyIconMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSilentMode = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.bgwNotify = new System.ComponentModel.BackgroundWorker();
			this.tableLayoutPanel1.SuspendLayout();
			this.toolStripMain.SuspendLayout();
			this.notifyIconMenuStrip.SuspendLayout();
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
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.toolStripMain, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 618);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(3, 40);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(778, 575);
			this.webBrowser1.TabIndex = 0;
			// 
			// toolStripMain
			// 
			this.toolStripMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStart,
            this.toolStripStop,
            this.toolStripPreferences,
            this.toolStripAbout});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(784, 37);
			this.toolStripMain.TabIndex = 1;
			this.toolStripMain.Text = "toolStrip1";
			// 
			// toolStripStart
			// 
			this.toolStripStart.AutoSize = false;
			this.toolStripStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStart.Image")));
			this.toolStripStart.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripStart.Name = "toolStripStart";
			this.toolStripStart.Size = new System.Drawing.Size(34, 34);
			this.toolStripStart.Text = "toolStripButton2";
			this.toolStripStart.Click += new System.EventHandler(this.toolStripStart_Click);
			// 
			// toolStripStop
			// 
			this.toolStripStop.AutoSize = false;
			this.toolStripStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStop.Image")));
			this.toolStripStop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripStop.Name = "toolStripStop";
			this.toolStripStop.Size = new System.Drawing.Size(34, 34);
			this.toolStripStop.Text = "toolStripButton1";
			this.toolStripStop.Visible = false;
			this.toolStripStop.Click += new System.EventHandler(this.toolStripStop_Click);
			// 
			// toolStripPreferences
			// 
			this.toolStripPreferences.AutoSize = false;
			this.toolStripPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripPreferences.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPreferences.Image")));
			this.toolStripPreferences.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripPreferences.Name = "toolStripPreferences";
			this.toolStripPreferences.Size = new System.Drawing.Size(34, 34);
			this.toolStripPreferences.Text = "toolStripButton3";
			this.toolStripPreferences.Click += new System.EventHandler(this.toolStripPreferences_Click);
			// 
			// toolStripAbout
			// 
			this.toolStripAbout.AutoSize = false;
			this.toolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAbout.Image")));
			this.toolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripAbout.Name = "toolStripAbout";
			this.toolStripAbout.Size = new System.Drawing.Size(34, 34);
			this.toolStripAbout.Text = "toolStripButton2";
			// 
			// bgwFetchFeed
			// 
			this.bgwFetchFeed.WorkerSupportsCancellation = true;
			this.bgwFetchFeed.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFetchFeed_DoWork);
			// 
			// notifyIconMenuStrip
			// 
			this.notifyIconMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShow,
            this.toolStripMenuItemSilentMode,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
			this.notifyIconMenuStrip.Name = "notifyIconMenuStrip";
			this.notifyIconMenuStrip.Size = new System.Drawing.Size(153, 98);
			// 
			// toolStripMenuItemShow
			// 
			this.toolStripMenuItemShow.Name = "toolStripMenuItemShow";
			this.toolStripMenuItemShow.Size = new System.Drawing.Size(136, 22);
			this.toolStripMenuItemShow.Text = "显示(&S)";
			// 
			// toolStripMenuItemSilentMode
			// 
			this.toolStripMenuItemSilentMode.CheckOnClick = true;
			this.toolStripMenuItemSilentMode.Name = "toolStripMenuItemSilentMode";
			this.toolStripMenuItemSilentMode.Size = new System.Drawing.Size(136, 22);
			this.toolStripMenuItemSilentMode.Text = "安静模式(&L)";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(152, 22);
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
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.notifyIconMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.ToolStrip toolStripMain;
		private System.Windows.Forms.ToolStripButton toolStripStart;
		private System.Windows.Forms.ToolStripButton toolStripStop;
		private System.Windows.Forms.ToolStripButton toolStripPreferences;
		private System.Windows.Forms.ToolStripButton toolStripAbout;
		private System.ComponentModel.BackgroundWorker bgwFetchFeed;
		private System.Windows.Forms.ContextMenuStrip notifyIconMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShow;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSilentMode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.ComponentModel.BackgroundWorker bgwNotify;
	}
}