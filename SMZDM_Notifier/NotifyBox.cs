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
		private string fileText = "";

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

		#region 显示提示框
		public void ShowNotifyBox()
		{
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
			staySeconds = Settings.Default.NotifyStayTime;//停留时间
			Thread.Sleep(staySeconds * 1000);
			Close();
		}
		#endregion

		private void NotifyBox_Load(object sender, EventArgs e)
		{
			Width = Properties.Settings.Default.NotifyBoxWidth;
			Height = Properties.Settings.Default.NotifyBoxHeight;

			var streamReader = new StreamReader(Properties.Settings.Default.NOTIFY_FILENAME);

			fileText = streamReader.ReadToEnd();

			var feed = new Feed("首页","http://feed.smzdm.com");

			Item item = feed.Items[0];

			fileText = fileText.Replace("@title", item.Title)
				.Replace("@link", item.Link)
				.Replace("@pubDate", item.PubDate)
				.Replace("@descriptionEncoded", item.ContentEncoded)
				.Replace("@imgUrl", item.ImgUrl);

			wbsNotify.Navigate("abount:blank");
			

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

		private void wbsNotify_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			wbsNotify.Document.Write(fileText);
		}
	}
}