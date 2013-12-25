using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SMZDM_Notifier.models
{
	internal class ItemBase
	{
		private readonly ItemSet _itemSet;
		private string dataFilePath;
		private XmlDocument doc;

		public ItemBase(ItemSet itemSet)
		{
			string FILE_HEADER =string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" ?><?xml-stylesheet type=\"text/xsl\" href=\"{0}\"?><items></items>",Properties.Settings.Default.XSL_FILENAME);
			this.dataFilePath = Application.StartupPath + "\\" + Properties.Settings.Default.DATA_FILENAME;
			_itemSet = itemSet;
			doc = new XmlDocument();

			try
			{
				if (File.Exists(this.dataFilePath))
				{
					doc.Load(this.dataFilePath);
				}
				else
				{
					doc.LoadXml(FILE_HEADER);
				}
				//
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
				//item节点
				XmlNode itemNode = doc.CreateElement("item");

				//channel节点
				XmlNode channelNode = doc.CreateElement("channel");
				channelNode.InnerText = item.Channel;
				itemNode.AppendChild(channelNode);

				//image节点
				XmlNode imgNode = doc.CreateElement("image");
				imgNode.InnerText = item.ImgUrl;
				itemNode.AppendChild(imgNode);

				//title节点
				XmlNode titleNode = doc.CreateElement("title");
				titleNode.InnerText = item.Title;
				itemNode.AppendChild(titleNode);

				//link节点
				XmlNode linkNode = doc.CreateElement("link");
				linkNode.InnerText = item.Link;
				itemNode.AppendChild(linkNode);

				//comments节点
				XmlNode commentsNode = doc.CreateElement("comments");
				commentsNode.InnerText = item.Comments;
				itemNode.AppendChild(commentsNode);

				//pubDate节点
				XmlNode pubDateNode = doc.CreateElement("pubDate");
				pubDateNode.InnerText = item.PubDate;
				itemNode.AppendChild(pubDateNode);

				//description节点
				XmlNode descriptionNode = doc.CreateElement("description");
				descriptionNode.InnerText = item.Description;
				itemNode.AppendChild(descriptionNode);

				//contentEncoded节点
				XmlNode contentEncodedNode = doc.CreateElement("contentEncoded");
				contentEncodedNode.InnerText = item.ContentEncoded;
				itemNode.AppendChild(contentEncodedNode);

				doc.DocumentElement.AppendChild(itemNode);
			}
		}


		public void Save()
		{
			try
			{
				
				doc.Save(this.dataFilePath);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}

		public DateTime GetLatestPubDate(string channel)
		{
			DateTime currentLatestPubDate = DateTime.MinValue;

			foreach (Item item in _itemSet.Items)
			{
				DateTime pubDate = DateTime.Parse(item.PubDate);

				if (pubDate > currentLatestPubDate && item.Channel == channel)
				{
					currentLatestPubDate = pubDate;
				}
			}

			return currentLatestPubDate;
		}
	}
}