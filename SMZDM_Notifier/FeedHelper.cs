using System;
using System.Collections.Generic;
using System.Text;

namespace SMZDM_Notifier
{
	using System.Xml;

	class FeedHelper
	{
		public static string GetFeed(string url)
		{
			XmlDocument doc = new XmlDocument();

			try
			{
				doc.Load(url);
			
				return doc.OuterXml;
			}
			catch (Exception exception)
			{

				throw new Exception(exception.Message);
			}
		}
	}
}
