using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SMZDM_Notifier.models
{
	class ItemBase
	{

		private const string FILE_NAME = "ItemBase.xml";

		private string FILE_HEADER = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?><items></items>";

		private string filePath = Application.StartupPath + "\\" + FILE_NAME;

		private ItemSet _itemSet;

		private XmlDocument doc;

	

		public ItemBase(ItemSet itemSet)
		{
			_itemSet = itemSet;
			doc = new XmlDocument();

			try
			{
				if (File.Exists(filePath))
				{
					doc.Load(filePath);
				}
				else
				{
					doc.LoadXml(FILE_HEADER);
				}
				//

				foreach (Item item in _itemSet.Items)
				{
					XmlNode itemNode = doc.CreateElement("item");
					itemNode.InnerXml = item.InnerXml;

					XmlNode channelNode = doc.CreateElement("channel");
					channelNode.InnerText = item.Channel;

					itemNode.InsertBefore(channelNode, itemNode.FirstChild);
					doc.DocumentElement.AppendChild(itemNode);
				}
				
				


			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}

			//XmlNodeList itemNodes = doc.GetElementsByTagName("item");

			//foreach (XmlNode itemNode in itemNodes)
			//{
			//	_itemSet.Add(new Item(itemNode.OuterXml));
			//}
		}

		public void DataBind()
		{

			foreach (Item item in _itemSet.Items)
			{
				
				
				XmlNode channelNode = doc.CreateElement("channel");
				channelNode.InnerText = item.Channel;

				XmlNode itemNode = doc.CreateElement("item");
				

				
				doc.DocumentElement.AppendChild(itemNode);
			}
		}


		public void Save()
		{
			try
			{
				doc.Save(filePath);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}

		}

		public DateTime GetLatestPubDate()
		{
			DateTime currentLatestPubDate = DateTime.MinValue;

			foreach (Item item in _itemSet.Items)
			{
				DateTime pubDate = DateTime.Parse(item.PubDate);

				if (pubDate > currentLatestPubDate)
				{
					currentLatestPubDate = pubDate;
				}

				
			}

			return currentLatestPubDate;
		}

	}
}
