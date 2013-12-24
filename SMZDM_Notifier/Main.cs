using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMZDM_Notifier
{
	using System.Threading;

	using SMZDM_Notifier.models;

	public partial class Main : Form
	{
		private bool isFetching = false;
		public Main()
		{
			InitializeComponent();
		}

		private void toolStripStart_Click(object sender, EventArgs e)
		{
			//if (btnGetFeed.Text == startText)
			//{
			//	btnGetFeed.Text = stopText;
			//}
			//else
			//{
			//	btnGetFeed.Text = startText;
			//}

			if (!this.isFetching)
			{
				this.bgwFetchFeed.DoWork += new DoWorkEventHandler(this.bgwFetchFeed_DoWork);
				bgwFetchFeed.RunWorkerAsync();

				isFetching = true;

				toolStripStart.Visible = false;
				toolStripStop.Visible = true;
			}


		}

		private void toolStripPreferences_Click(object sender, EventArgs e)
		{
			Preferences frmPreferences = new Preferences();

			frmPreferences.ShowDialog();
		}

		private void bgwFetchFeed_DoWork(object sender, DoWorkEventArgs e)
		{
			string[] urls = new string[] { "http://feed.smzdm.com;首页", "http://fx.smzdm.com/feed;发现频道" };

			this.FetchFeed(urls);

		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Properties.Settings.Default.MinimizeWhenClose == false)
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

				toolStripStart.Visible = true;
				toolStripStop.Visible = false;
			}
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		public void FetchFeed(string[] urls)
		{
			while (true)
			{

				IList<Feed> feeds = new List<Feed>();

				foreach (string url in urls)
				{
					feeds.Add(new Feed(url.Split(';')[0], url.Split(';')[1]));
				}

				ItemSet itemSet = new ItemSet();
				ItemBase itemBase = new ItemBase(itemSet);

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



				Thread.Sleep(new TimeSpan(0, 0, 0, 30));
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

	}
}
