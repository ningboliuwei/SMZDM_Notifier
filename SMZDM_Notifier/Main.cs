using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using SMZDM_Notifier.models;
using SMZDM_Notifier.Properties;

namespace SMZDM_Notifier
{
	public partial class Main : Form
	{
		private bool isGetting = false;

		public Main()
		{
			InitializeComponent();
		}

		private void toolStripMenuItemShow_Click(object sender, EventArgs e)
		{
			//点击右键菜单→显示
			this.ShowForm();
		}



		private void ShowForm()
		{
			this.WindowState = FormWindowState.Normal;
			this.TopMost = true;
			this.Show();
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			ShowForm();
		}

		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			//鼠标单击左键时
			if (e.Button == MouseButtons.Left)
			{
				this.ShowForm();
			}
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//鼠标双击左键时
			if (e.Button == MouseButtons.Left)
			{
				this.ShowForm();
			}
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (chkMinimizeWhenClose.Checked == false)
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


		//恢复默认按钮
		private void btnDefault_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "确定恢复为默认设置吗?", "问题", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				Properties.Settings.Default.Reset();//恢复到默认设置

				LoadSettings();
			}


		}

		//应用设置按钮
		private void btnApply_Click(object sender, EventArgs e)
		{
			SaveSettings();
			LoadSettings();
		}

		private void SaveSettings()
		{
			Settings settings = Properties.Settings.Default;

			settings.StartupWithSystem = chkStartupWithSystem.Checked;
			settings.MinimizeWhenClose = chkMinimizeWhenClose.Checked;
			settings.SilentMode = chkSilentMode.Checked;
			settings.KeepMessageAmount = Convert.ToInt32(cmbKeepMessageAmount.Text);
			settings.LocationToShow = cmbLocationToShow.Text;
			settings.NotifyStayTime = Convert.ToInt32(cmbNotifyStayTime.Text);
			settings.RefreshInterval = Convert.ToInt32(txtRefreshInterval.Text);

			settings.Save();
		}

		private void LoadSettings()
		{
			Settings settings = Properties.Settings.Default;

			chkStartupWithSystem.Checked = settings.StartupWithSystem;
			chkMinimizeWhenClose.Checked = settings.MinimizeWhenClose;
			chkSilentMode.Checked = settings.SilentMode;
			cmbKeepMessageAmount.Text = settings.KeepMessageAmount.ToString();
			cmbLocationToShow.Text = settings.LocationToShow.ToString();
			cmbNotifyStayTime.Text = settings.NotifyStayTime.ToString();
			txtRefreshInterval.Text = settings.RefreshInterval.ToString();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			LoadSettings();
		}

		//放弃修改按钮
		private void btnCancel_Click(object sender, EventArgs e)
		{
			//LoadSettings();

			NotifyBox frmNotifyBox = NotifyBox.GetInstance();//Form1为要弹出的窗体（提示框），

			frmNotifyBox.ShowNotifyBox();
		}

		private void bgwGetFeed_DoWork(object sender, DoWorkEventArgs e)
		{




		}

		private void btnGetFeed_Click(object sender, EventArgs e)
		{
			string startText = "开始抓取(&S)";
			string stopText = "停止抓取&S";

			if (btnGetFeed.Text == startText)
			{
				btnGetFeed.Text = stopText;
			}
			else
			{
				btnGetFeed.Text = startText;
			}

			if (!isGetting)
			{

			}

			StartGetting();


		}

		public void StartGetting()
		{
			string[] urls = new string[] { "http://feed.smzdm.com;首页", "http://jy.smzdm.com/feed;发现" };


			while (true)
			{
				IList<Feed> feeds = new List<Feed>();

				foreach (string url in urls)
				{
					feeds.Add(new Feed(url.Split(';')[0], url.Split(';')[1]));
				}


				ItemSet itemSet = new ItemSet();
				ItemBase itemBase = new ItemBase(itemSet);

				DateTime latestItemBasePubDate = itemBase.GetLatestPubDate();

				foreach (Feed feed in feeds)
				{
					foreach (Item item in feed.Items)
					{
						if (DateTime.Parse(item.PubDate) > latestItemBasePubDate)
						{
							itemSet.Add(item);
						}
					}
				}


				itemBase.Save();



				Thread.Sleep(new TimeSpan(0, 0, 1, 30));
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

