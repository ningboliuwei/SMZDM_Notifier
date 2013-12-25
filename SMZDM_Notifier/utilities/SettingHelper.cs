using SMZDM_Notifier.Properties;

namespace SMZDM_Notifier
{
	internal class SettingHelper
	{
		private static readonly Settings settings = Settings.Default;
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