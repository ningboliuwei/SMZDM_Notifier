using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using SMZDM_Notifier.Properties;

namespace SMZDM_Notifier
{
	public partial class NotifyBox : Form
	{
		private static readonly NotifyBox _instance = new NotifyBox();
		private DateTime stayBeginTime;
		private int staySeconds;

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
			Visible = false;

			//Settings settings = Properties.Settings.Default;
			//settings.NotifyBoxWidth = Width;
			//settings.NotifyBoxHeight = Height;

			//settings.Save();
		}

		public void ShowNotifyBox()
		{
			staySeconds = Settings.Default.NotifyStayTime;

			var p = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height);

			PointToScreen(p);
			Location = p;
			Show();

			for (int i = 0; i <= Height; i += 10)
			{
				Location = new Point(p.X, p.Y - i);
				Thread.Sleep(10); //将线程沉睡时间调的越小升起的越快
			}

			//tmrStay.Enabled = true;
			stayBeginTime = DateTime.Now;
		}

		private void NotifyBox_Load(object sender, EventArgs e)
		{
			Settings settings = Settings.Default;
			string appPath = Application.StartupPath;

			Width = settings.NotifyBoxWidth;
			Height = settings.NotifyBoxHeight;

			var streamReader = new StreamReader(Properties.Settings.Default.NOTIFY_FILENAME);

			string s = streamReader.ReadToEnd();

			var feed = new Feed("http://feed.smzdm.com", "首页");

			Item item = feed.Items[0];

			s = s.Replace("@title", item.Title)
				.Replace("@link", item.Link)
				.Replace("@pubDate", item.PubDate)
				.Replace("@descriptionEncoded", item.ContentEncoded)
				.Replace("@imgUrl", item.ImgUrl);

			this.wbsNotify.Url = new Uri(appPath + "\\" + Properties.Settings.Default.NOTIFY_FILENAME);
			this.wbsNotify.Document.Write(s);

			//wbsNotify.Navigate(appPath + "\\NotifyBox.html");
		}

		private void tmrStay_Tick(object sender, EventArgs e)
		{
			TimeSpan currentTimeSpan = DateTime.Now - stayBeginTime;

			if (currentTimeSpan.Seconds >= staySeconds)
			{
				Visible = false;
				//tmrStay.Enabled = false;
			}
		}

		private void wbsContent_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
		}
	}
}