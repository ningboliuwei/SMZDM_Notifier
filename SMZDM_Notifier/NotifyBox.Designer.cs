namespace SMZDM_Notifier
{
	partial class NotifyBox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyBox));
			this.wbsNotify = new System.Windows.Forms.WebBrowser();
			this.SuspendLayout();
			// 
			// wbsNotify
			// 
			this.wbsNotify.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbsNotify.Location = new System.Drawing.Point(0, 0);
			this.wbsNotify.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbsNotify.Name = "wbsNotify";
			this.wbsNotify.ScriptErrorsSuppressed = true;
			this.wbsNotify.Size = new System.Drawing.Size(384, 261);
			this.wbsNotify.TabIndex = 0;
			this.wbsNotify.Url = new System.Uri("http://www.smzdm.com", System.UriKind.Absolute);
			this.wbsNotify.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbsContent_DocumentCompleted);
			// 
			// NotifyBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.wbsNotify);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NotifyBox";
			this.ShowInTaskbar = false;
			this.Text = "NotifyBox";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotifyBox_FormClosing);
			this.Load += new System.EventHandler(this.NotifyBox_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser wbsNotify;
	}
}