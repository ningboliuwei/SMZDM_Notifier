using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SMZDM_Notifier
{
	using System.Diagnostics;

	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			#region 只允许运行一个实例
			Process pr = Process.GetCurrentProcess();
			Process[] prlist = Process.GetProcessesByName(pr.ProcessName);
			
			if (prlist.Length >= 2)
			{
				return;
			}
			#endregion

			Application.Run(new Main());
		}
	}
}
