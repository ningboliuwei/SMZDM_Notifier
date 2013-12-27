﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
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

		private void toolStripButtonStart_Click(object sender, EventArgs e)
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

				toolStripButtonStart.Visible = false;
				toolStripButtonStop.Visible = true;
			}
		}

		private void toolStripButtonPreferences_Click(object sender, EventArgs e)
		{
			var frmPreferences = new Preferences();

			frmPreferences.ShowDialog();
		}

		private void bgwFetchFeed_DoWork(object sender, DoWorkEventArgs e)
		{
			#region 读取要抓取的频道

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

		private void toolStripButtonStop_Click(object sender, EventArgs e)
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

		public void FetchFeed(string[] urls, int refreshInterval, DoWorkEventArgs e)
		{
			while (true)
			{
				if (bgwFetchFeed.CancellationPending)
				{
					e.Cancel = true;
					return;
				}

				#region 获取所有的Feed并将所有Item添加到ItemSet中去
				List<Feed> feeds = new List<Feed>();

				foreach (string url in urls)
				{
					feeds.Add(new Feed(url.Split('|')[0], url.Split('|')[1]));
				}

				var itemSet = new ItemSet();

				foreach (Feed feed in feeds)
				{
					foreach (Item item in feed.Items)
					{
						itemSet.Add(item);
					}
				}
				#endregion

				#region 对添加到ItemSet中的所有Item按照时间先后排序
				itemSet.Items.Sort(delegate(Item itemA, Item itemB)
				{
					return DateTime.Parse(itemA.PubDate).CompareTo(
						DateTime.Parse(itemB.PubDate));
				});
				#endregion

				int i = 0;

				Thread.Sleep(new TimeSpan(0, 0, 0, refreshInterval));
			}


			//ItemBase itemBase = new ItemBase(itemSet);


			//itemBase.Save();
		}

		public void StopGetting()
		{
		}

		private void toolStripButtonAbout_Click(object sender, EventArgs e)
		{
			var frMyAboutBox = new MyAboutBox();

			frMyAboutBox.ShowDialog();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			BindToolStripComboBoxChannel();
			toolStripComboBoxChannel.SelectedIndex = 0;
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			ShowResult(toolStripComboBoxChannel.Text);


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
			toolStripButtonStart.Visible = true;
			toolStripButtonStop.Visible = false;
		}

		private void bgwBrowser_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void wbsMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{

		}

		//加载频道至工具栏中下拉列表
		private void BindToolStripComboBoxChannel()
		{


			string[] channelAndUrls = Properties.Settings.Default.ChannelUrls.Split(';');

			toolStripComboBoxChannel.Items.Add("全部频道");
			foreach (string channelAndUrl in channelAndUrls)
			{
				toolStripComboBoxChannel.Items.Add(channelAndUrl.Split('|')[0]);
			}


		}

		private void ShowResult(string channel)
		{
			XslCompiledTransform xsl = new XslCompiledTransform();

			xsl.Load(Application.StartupPath + "\\" + Properties.Settings.Default.XSL_FILENAME);

			XPathDocument doc = new XPathDocument(Application.StartupPath + "\\" + Properties.Settings.Default.DATA_FILENAME);
			XPathNavigator navigator = doc.CreateNavigator();

			string xPath = "";

			if (channel == toolStripComboBoxChannel.Items[0].ToString())
			{
				xPath = "items/item";
			}
			else
			{
				xPath = string.Format("items/item[channel='{0}']", channel);
			}

			XPathNodeIterator iterator = navigator.Select(xPath);

			ItemSet set = new ItemSet();

			int count = 0;

			while (iterator.MoveNext())
			{
				Item item = new Item(iterator.Current.OuterXml);
				item.Channel = channel;
				set.Add(item);
				count++;

				if (count == 10)
				{
					break;
				}
			}

			ItemBase resultItemBase = new ItemBase(set, Application.StartupPath + "\\" + Properties.Settings.Default.RESULT_XML_FILENAME, false);

			resultItemBase.AddItems();
			resultItemBase.Save();

			xsl.Transform(Application.StartupPath + "\\" + Properties.Settings.Default.RESULT_XML_FILENAME,
				Application.StartupPath + "\\" + Properties.Settings.Default.RESULT_HTML_FILENAME);
			wbsMain.Navigate(Application.StartupPath + "\\" + Properties.Settings.Default.RESULT_HTML_FILENAME);
		}

		private void toolStripComboBoxChannel_SelectedIndexChanged(object sender, EventArgs e)
		{
			//ShowResult(toolStripComboBoxChannel.Text);
		}
	}
}