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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyBox));
			this.wbsContent = new System.Windows.Forms.WebBrowser();
			this.tmrStay = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// wbsContent
			// 
			this.wbsContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbsContent.Location = new System.Drawing.Point(0, 0);
			this.wbsContent.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbsContent.Name = "wbsContent";
			this.wbsContent.ScriptErrorsSuppressed = true;
			this.wbsContent.Size = new System.Drawing.Size(384, 261);
			this.wbsContent.TabIndex = 0;
			this.wbsContent.Url = new System.Uri("http://www.smzdm.com", System.UriKind.Absolute);
			this.wbsContent.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbsContent_DocumentCompleted);
			// 
			// tmrStay
			// 
			this.tmrStay.Tick += new System.EventHandler(this.tmrStay_Tick);
			// 
			// NotifyBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.wbsContent);
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

		private System.Windows.Forms.WebBrowser wbsContent;
		private System.Windows.Forms.Timer tmrStay;
	}
}