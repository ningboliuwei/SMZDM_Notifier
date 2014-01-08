using System;
using System.Collections.Generic;
using System.Xml;

namespace SMZDM_Notifier
{
	internal class Feed
	{
		private List<Item> _items = new List<Item>();
		private XmlDocument doc;

		/// <summary>
		/// 根据给定的url获取Feed并生成Feed对象
		/// </summary>
		/// <param name="channel">频道名</param>
		/// <param name="url">Feed的URL</param>
		public Feed(string channel, string url)
		{
			Channel = channel;
			doc = new XmlDocument();
			//backup
			//var doc = new XmlDocument();
			//backup-end

			try
			{
				doc.Load(url);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}

			//backup
			//LastBuildDate = doc.GetElementsByTagName("lastBuildDate")[0].InnerText; //RSS更新时间
			//Channel = channel;//将传入的Feed名称赋值给Feed.Channel属性
			#endregion

			//XmlNodeList itemNodes = doc.GetElementsByTagName("item");

			//foreach (XmlNode itemNode in itemNodes)
			//{
			//	var item = new Item(itemNode.OuterXml);

			//	item.Channel = channel;//指定该item所属的channel
			//	_items.Add(item);
			//}
			//backup-end
		}
		#endregion

		#region 目前用不上
		//public string LastBuildDate { get; set; }
		#endregion

		public List<Item> Items
		{
			get { return _items; }
		}

		public string Channel { get; set; }

		//add
		public void Save(string path)
		{
			doc.Save(path);
		}

		//add-end
	}
}