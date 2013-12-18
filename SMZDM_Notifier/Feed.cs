using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SMZDM_Notifier
{
	class Feed
	{
		private string _lastBuildDate;
		private IList<Item> _items = new List<Item>();
		private string _text;

		public Feed(string url)
		{
			XmlDocument doc = new XmlDocument();

			try
			{
				doc.Load(url);

				_text = doc.OuterXml;//完整的XML代码
				_lastBuildDate = doc.GetElementsByTagName("lastBuildDate")[0].InnerText;//RSS更新时间

				XmlNodeList itemNodes = doc.GetElementsByTagName("item");

				foreach (XmlNode itemNode in itemNodes)
				{
					_items.Add(new Item(itemNode.OuterXml));
				}

			}
			catch (Exception)
			{

				throw;
			}
		}


		public string LastBuildDate
		{
			get { return _lastBuildDate; }
			set { _lastBuildDate = value; }
		}

		public IList<Item> Items
		{
			get { return _items; }
			set { _items = value; }
		}

		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}
	}
}
