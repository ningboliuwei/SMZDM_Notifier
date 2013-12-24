using System;
using System.Collections.Generic;
using System.Text;

namespace SMZDM_Notifier
{
	using SMZDM_Notifier.Properties;

	class SettingHelper
	{
		private static Settings settings = Properties.Settings.Default;
		//public static string GetSettingValue(string name)
		//{
		//	return settings.
		//}



		public static void Reset()
		{
			settings.Reset();
		}
	}
}
