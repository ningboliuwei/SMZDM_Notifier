using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SMZDM_Notifier
{
	internal class Feed
	{
		private string _lastBuildDate;
		private string _channel;
		private IList<Item> _items = new List<Item>();
		private string _text;

		public Feed( string channel,string url)
		{
			_channel = channel;
			XmlDocument doc = new XmlDocument();

			try
			{
				doc.Load(url);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}

			_text = doc.OuterXml; //完整的XML代码
			_lastBuildDate = doc.GetElementsByTagName("lastBuildDate")[0].InnerText; //RSS更新时间
			_channel = channel;

			XmlNodeList itemNodes = doc.GetElementsByTagName("item");

			foreach (XmlNode itemNode in itemNodes)
			{
				Item item = new Item(itemNode.OuterXml);

				item.Channel = channel;
				_items.Add(item);
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

		public string Channel
		{
			get { return _channel; }
			set { _channel = value; }
		}
	}
}