using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SMZDM_Notifier
{
	public partial class Main : Form
	{
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
			if (MessageBox.Show(this, "确定退出程序吗?", "问题", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				notifyIcon.Visible = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string s = FeedHelper.GetFeed("http://feed.smzdm.com");

			MessageBox.Show(s);
		}
	}
}
