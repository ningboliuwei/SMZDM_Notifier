using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Xml.XPath;
using SMZDM_Notifier.models;
using SMZDM_Notifier.Properties;

namespace SMZDM_Notifier
{
	using System.IO;
	using System.Text;
	using System.Xml;
	using System.Xml.Xsl;

	public partial class Main : Form
	{
		private bool isFetching;

		public Main()
		{
			InitializeComponent();
		}

		private void toolStripStart_Click(object sender, EventArgs e)
		{
			//if (btnGetFeed.text == startText)
			//{
			//	btnGetFeed.text = stopText;
			//}
			//else
			//{
			//	btnGetFeed.text = startText;
			//}

			if (!isFetching)
			{
				bgwFetchFeed.DoWork += bgwFetchFeed_DoWork;
				bgwFetchFeed.RunWorkerAsync();

				isFetching = true;

				toolStripStart.Visible = false;
				toolStripStop.Visible = true;
			}
		}

		private void toolStripPreferences_Click(object sender, EventArgs e)
		{
			var frmPreferences = new Preferences();

			frmPreferences.ShowDialog();
		}

		private void bgwFetchFeed_DoWork(object sender, DoWorkEventArgs e)
		{
			#region 加载复选框数组

			string[] channelAndUrls = Settings.Default.ChannelUrls.Split(';');
			var urls = new string[channelAndUrls.Length];

			for (int i = 0; i < channelAndUrls.Length; i++)
			{
				urls[i] = channelAndUrls[i].Split('|')[0] + "|" + channelAndUrls[i].Split('|')[1];
			}

			#endregion

			FetchFeed(urls, e);
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Settings.Default.MinimizeWhenClose == false)
			{
				if (
					MessageBox.Show(this, "确定退出程序吗?", "问题", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
						MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					e.Cancel = true;
				}
				else
				{
					notifyIcon.Visible = false;
				}
			}
			else
			{
				e.Cancel = true;
				WindowState = FormWindowState.Minimized;
			}
		}

		private void toolStripStop_Click(object sender, EventArgs e)
		{
			if (isFetching)
			{
				isFetching = false;

				bgwFetchFeed.CancelAsync();


			}
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void FetchFeed(string[] urls, DoWorkEventArgs e)
		{
			int refreshInterval = Settings.Default.RefreshInterval;

			while (true)
			{
				if (bgwFetchFeed.CancellationPending)
				{
					e.Cancel = true;
					return;
				}

				IList<Feed> feeds = new List<Feed>();

				foreach (string url in urls)
				{
					feeds.Add(new Feed(url.Split('|')[0], url.Split('|')[1]));
				}

				var itemSet = new ItemSet();
				var itemBase = new ItemBase(itemSet, Properties.Settings.Default.DATA_FILENAME);

				foreach (Feed feed in feeds)
				{
					DateTime latestItemBasePubDate = itemBase.GetLatestPubDate(feed.Channel);

					foreach (Item item in feed.Items)
					{
						if (DateTime.Parse(item.PubDate) > latestItemBasePubDate && item.Channel == feed.Channel)
						{
							itemSet.Add(item);
						}
					}
				}

				itemBase.DataBind();
				itemBase.Save();

				Thread.Sleep(new TimeSpan(0, 0, 0, refreshInterval));
			}


			int i = 1;

			//Thread.Sleep(new TimeSpan(0, 0, 5, 0));

			//ItemSet itemSet = new ItemSet();

			//foreach (Feed feed in feeds)
			//{
			//	foreach (Item item in feed.Items)
			//	{
			//		itemSet.Add(item);
			//	}

			//}

			//ItemBase itemBase = new ItemBase(itemSet);


			//itemBase.Save();
		}

		public void StopGetting()
		{
		}

		private void toolStripAbout_Click(object sender, EventArgs e)
		{
			var frMyAboutBox = new MyAboutBox();

			frMyAboutBox.ShowDialog();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//
		}

		private void toolStripRefresh_Click(object sender, EventArgs e)
		{
			XslCompiledTransform xsl = new XslCompiledTransform();

			xsl.Load(Application.StartupPath + "\\" + Properties.Settings.Default.XSL_FILENAME);
			
			XPathDocument doc = new XPathDocument(Application.StartupPath + "\\" + Properties.Settings.Default.DATA_FILENAME);
			XPathNavigator navigator = doc.CreateNavigator();
			XPathNodeIterator iterator= navigator.Select("items/item[channel='优惠精选']");

			ItemSet set = new ItemSet();

			while (iterator.MoveNext())
			{
				Item item = new Item(iterator.Current.OuterXml);
				item.Channel = "优惠精选";
				set.Add(item);

				
				
			}
			ItemBase resultItemBase = new ItemBase(set, Application.StartupPath + "\\" + "channel.xml");

			resultItemBase.DataBind();
			resultItemBase.Save();

			xsl.Transform(Application.StartupPath + "\\" + "channel.xml", Application.StartupPath + "\\" + "result.html")
			;
			wbsMain.Navigate(Application.StartupPath + "\\" + "result.html");
			int i = 0;


		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripPrevious_Click(object sender, EventArgs e)
		{
			//wbsMain.GoBack();
		}

		private void toolStripNext_Click(object sender, EventArgs e)
		{
			//wbsMain.GoForward();
			NotifyBox frmNotifyBox = NotifyBox.GetInstance();
			frmNotifyBox.Show();
		}

		private void bgwFetchFeed_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			toolStripStart.Visible = true;
			toolStripStop.Visible = false;
		}

		private void bgwBrowser_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void wbsMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}
	}
}