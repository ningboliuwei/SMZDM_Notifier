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
	public partial class Preferences : Form
	{
		private bool isFetching = false;

		public Preferences()
		{
			InitializeComponent();
		}

		private void toolStripMenuItemShow_Click(object sender, EventArgs e)
		{
			//点击右键菜单→显示
			this.ShowForm();
		}



		//显示窗体
		private void ShowForm()
		{
			this.WindowState = FormWindowState.Normal;
			this.TopMost = true;
			this.Show();
		}

		//双击通知栏图标
		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			ShowForm();
		}

		//鼠标点击通知栏图标
		private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
		{
			//鼠标单击左键时
			if (e.Button == MouseButtons.Left)
			{
				this.ShowForm();
			}
		}

		//鼠标双击通知栏图标
		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//鼠标双击左键时
			if (e.Button == MouseButtons.Left)
			{
				this.ShowForm();
			}
		}

		//关闭窗体
		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{

		}


		//恢复默认按钮
		private void btnDefault_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "确定恢复为默认设置吗?", "问题", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{//恢复到默认设置
				Properties.Settings.Default.Reset();
				LoadSettings();
			}


		}

		//应用设置按钮
		private void btnOK_Click(object sender, EventArgs e)
		{
			SaveSettings();
			//LoadSettings();
			this.Close();
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
			settings.RefreshInterval = Convert.ToInt32(cmbRefreshInterval.Text);
			settings.MinimizeWhenStartup = chkMinimizeWhenStartup.Checked;
			settings.AutoStartFetching = chkAutoStartFetching.Checked;


			#region 保存频道复选框选中状态
			string[] channelAndUrls = settings.ChannelUrls.Split(';');

			for (int i = 0; i < channelAndUrls.Length; i++)
			{
				string channel = channelAndUrls[i].Split('|')[0];
				string url = channelAndUrls[i].Split('|')[1];
				bool checkedStatus = bool.Parse(channelAndUrls[i].Split('|')[2]);


				#region 稳妥的方式
				//foreach (Control control in tableLayoutPanel4.Controls)
				//{
				//	CheckBox checkBox = control as CheckBox;

				//	if (channel == checkBox.text)
				//	{
				//		checkedStatus = checkBox.Checked;
				//		break;
				//	}
				//}
				#endregion

				checkedStatus = (tableLayoutPanel4.Controls[i] as CheckBox).Checked;
				channelAndUrls[i] = channel + "|" + url + "|" + checkedStatus;

			}
			Properties.Settings.Default.ChannelUrls = string.Join(";", channelAndUrls);
			#endregion

			settings.Save();
		}

		private void LoadSettings()
		{
			Settings settings = Properties.Settings.Default;

			chkStartupWithSystem.Checked = settings.StartupWithSystem;
			chkMinimizeWhenClose.Checked = settings.MinimizeWhenClose;
			chkMinimizeWhenStartup.Checked = settings.MinimizeWhenStartup;
			chkAutoStartFetching.Checked = settings.AutoStartFetching;
			chkSilentMode.Checked = settings.SilentMode;
			chkMinimizeWhenStartup.Checked = settings.MinimizeWhenStartup;
			chkAutoStartFetching.Checked = settings.AutoStartFetching;
			cmbKeepMessageAmount.Text = settings.KeepMessageAmount.ToString();
			cmbLocationToShow.Text = settings.LocationToShow.ToString();
			cmbNotifyStayTime.Text = settings.NotifyStayTime.ToString();
			cmbRefreshInterval.Text = settings.RefreshInterval.ToString();


			#region 加载复选框数组
			string[] channelAndUrls = settings.ChannelUrls.Split(';');

			tableLayoutPanel4.Controls.Clear();
			foreach (string channelAndUrl in channelAndUrls)
			{
				string channel = channelAndUrl.Split('|')[0];
				string url = channelAndUrl.Split('|')[1];
				bool checkedStatus = bool.Parse(channelAndUrl.Split('|')[2]);

				CheckBox checkBox = new CheckBox();
				checkBox.Text = channel;
				checkBox.Dock = DockStyle.Fill;
				checkBox.Checked = checkedStatus;

				tableLayoutPanel4.Controls.Add(checkBox);
			}
			#endregion

		}

		private void Main_Load(object sender, EventArgs e)
		{
			LoadSettings();
		}

		//放弃修改按钮
		private void btnCancel_Click(object sender, EventArgs e)
		{
			//LoadSettings();

			//NotifyBox frmNotifyBox = NotifyBox.GetInstance();//Form1为要弹出的窗体（提示框），

			//frmNotifyBox.ShowNotifyBox();

			this.Close();
		}









		private void cmbNotifyStayTime_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}

