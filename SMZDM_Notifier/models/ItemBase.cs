using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SMZDM_Notifier.models
{
	internal class ItemBase
	{
		private readonly ItemSet _itemSet;
		private string _dataFilePath;
		private XmlDocument doc;
		private const string contentNamespaceUrl = "http://purl.org/rss/1.0/modules/content/";

		#region 读取已有数据文件或新建数据文件
		public ItemBase(ItemSet itemSet, string dataFilePath)
		{

			string FILE_HEADER = string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" ?><items xmlns:content=\"{0}\"></items>", contentNamespaceUrl);
			_dataFilePath = dataFilePath;
			_itemSet = itemSet;

			//NameTable nameTable = new NameTable();
			//XmlNamespaceManager manager = new XmlNamespaceManager(nameTable);
			//manager.AddNamespace("content", "http://purl.org/rss/1.0/modules/content/");
			doc = new XmlDocument();

			try
			{
				if (File.Exists(_dataFilePath))
				{
					doc.Load(this._dataFilePath);
				}
				else
				{
					doc.LoadXml(FILE_HEADER);
				}
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}
		#endregion

		#region 将传入的ItemSet中的Item数据作为节点添加
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
				XmlNode contentEncodedNode = doc.CreateElement("content", "encoded", contentNamespaceUrl);
				contentEncodedNode.InnerText = item.ContentEncoded;
				itemNode.AppendChild(contentEncodedNode);

				doc.DocumentElement.AppendChild(itemNode);
			}
		}
		#endregion


		#region 将内存中的数据保存到磁盘中
		public void Save()
		{
			try
			{
				doc.Save(_dataFilePath);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}
		#endregion

		#region 得到指定频道中最新的item发布时间
		public DateTime GetLatestPubDate(string channel)
		{
			DateTime currentLatestPubDate = DateTime.MinValue;

			foreach (Item item in _itemSet.Items)
			{
				DateTime pubDate = DateTime.Parse(item.PubDate);

				if (item.Channel == channel && pubDate > currentLatestPubDate)
				{
					currentLatestPubDate = pubDate;
				}
			}

			return currentLatestPubDate;
		}
		#endregion
	}
}