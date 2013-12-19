using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SMZDM_Notifier.Properties;

namespace SMZDM_Notifier
{
	public partial class NotifyBox : Form
	{
		private static readonly NotifyBox _instance = new NotifyBox();
		private int staySeconds;
		private DateTime stayBeginTime;
		private NotifyBox()
		{
			InitializeComponent();
		}

		public static NotifyBox GetInstance()
		{
			return _instance;
		}

		private void NotifyBox_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Visible = false;

			//Settings settings = Properties.Settings.Default;
			//settings.NotifyBoxWidth = Width;
			//settings.NotifyBoxHeight = Height;

			//settings.Save();
		}

		public void ShowNotifyBox()
		{
			staySeconds = Properties.Settings.Default.NotifyStayTime;

			Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height);

			this.PointToScreen(p);
			this.Location = p;
			this.Show();

			for (int i = 0; i <= this.Height; i += 10)
			{
				this.Location = new Point(p.X, p.Y - i);
				Thread.Sleep(10);//将线程沉睡时间调的越小升起的越快
			}

			tmrStay.Enabled = true;
			stayBeginTime = DateTime.Now;

		}

		private void NotifyBox_Load(object sender, EventArgs e)
		{
			Settings settings = Properties.Settings.Default;
			string appPath = Application.StartupPath;

			Width = settings.NotifyBoxWidth;
			Height = settings.NotifyBoxHeight;

			//StreamReader streamReader = new StreamReader("NotifyBox.html");

			//string s = streamReader.ReadToEnd();

			//wbsContent.DocumentText = s;

			wbsContent.Navigate(appPath + "\\NotifyBox.html");


		}

		private void tmrStay_Tick(object sender, EventArgs e)
		{
			TimeSpan currentTimeSpan = DateTime.Now - stayBeginTime;

			if (currentTimeSpan.Seconds >= staySeconds)
			{
				this.Visible = false;
				tmrStay.Enabled = false;
			}
		}

		private void wbsContent_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			Feed feed = new Feed("http://feed.smzdm.com");

			Item item = feed.Items[0];

			//wbsContent.DocumentText = wbsContent.DocumentText.Replace("@itemTitle", item.Title)
															 //.Replace("@itemDate", item.PubDate)
															 //.Replace("@itemDescription", item.Description);
		}
	}
}
