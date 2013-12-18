using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SMZDM_Notifier
{
	class Item
	{
		public string Title { get; set; }

		public string Link { get; set; }

		public string Comments { get; set; }

		public string PubDate { get; set; }
		public string Description { get; set; }
		public string ContentEncoded { get; set; }

		public Item(string text)
		{
			XmlDocument doc = new XmlDocument();

			try
			{
				doc.LoadXml(text);
				Title = doc.GetElementsByTagName("title")[0].InnerText;
				Link = doc.GetElementsByTagName("link")[0].InnerText;
				Comments = doc.GetElementsByTagName("comments")[0].InnerText;
				PubDate = doc.GetElementsByTagName("pubDate")[0].InnerText;
				Description = doc.GetElementsByTagName("description")[0].InnerText;
				ContentEncoded = doc.GetElementsByTagName("content:encoded")[0].InnerText;
			}
			catch (Exception exception)
			{

				throw new Exception(exception.Message);
			}
		}
	}
}
