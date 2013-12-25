using System;
using System.Collections.Generic;
using System.Xml;

namespace SMZDM_Notifier
{
	internal class Feed
	{
		private IList<Item> _items = new List<Item>();

		public Feed(string channel, string url)
		{
			Channel = channel;
			var doc = new XmlDocument();

			try
			{
				doc.Load(url);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}

			Text = doc.OuterXml; //完整的XML代码
			LastBuildDate = doc.GetElementsByTagName("lastBuildDate")[0].InnerText; //RSS更新时间
			Channel = channel;

			XmlNodeList itemNodes = doc.GetElementsByTagName("item");

			foreach (XmlNode itemNode in itemNodes)
			{
				var item = new Item(itemNode.OuterXml);

				item.Channel = channel;
				_items.Add(item);
			}
		}


		public string LastBuildDate { get; set; }

		public IList<Item> Items
		{
			get { return _items; }
			set { _items = value; }
		}

		public string Text { get; set; }

		public string Channel { get; set; }
	}
}