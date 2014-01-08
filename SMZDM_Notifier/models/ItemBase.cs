using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace SMZDM_Notifier.models
{
	internal class ItemBase
	{
		private readonly ItemSet _itemSet;

		private XmlDocument _doc = new XmlDocument();

		private const string contentNamespaceUrl = "http://purl.org/rss/1.0/modules/content/";

		/// <summary>
		/// 若指定的数据文件不存在，则在指定路径创建该文件
		/// </summary>
		/// <param name="filePath">要创建的数据文件的路径</param>
 
		public void Create(string filePath)
		{
			try
			{
				if (!File.Exists(filePath))
				{
					string FILE_HEADER = string.Format("<?xml version=\"1.0\" encoding=\"UTF-8\" ?><items xmlns:content=\"{0}\"></items>", contentNamespaceUrl);

					_doc.LoadXml(FILE_HEADER);
					_doc.Save(filePath);
				}

			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}
		

		/// <summary>
		/// 将指定路径的数据文件加载到XmlDocument对象中
		/// </summary>
		/// <param name="filePath"></param>
		public void Load(string filePath)
		{
			try
			{
				if (!File.Exists(filePath))
				{
					_doc.Load(filePath);
				}
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}

		/// <summary>
		///将传入的ItemSet中的Item数据作为节点添加到现有doc中
		/// </summary>
		/// <param name="newItemSet">保存有要添加item的ItemSet</param>
		public void AddItems(ItemSet newItemSet)
		{
			XmlNode tempNode = _doc.CreateElement("TEMP");

			if (_doc.DocumentElement.HasChildNodes == false)
			{
				_doc.DocumentElement.AppendChild(tempNode);
			}

			for (int i =1; i < newItemSet.Items.Count; i++)
			{
				Item item = newItemSet.Items[i];
				//item节点
				XmlNode itemNode = _doc.CreateElement("item");

				//channel节点
				XmlNode channelNode = _doc.CreateElement("channel");
				channelNode.InnerText = item.Channel;
				itemNode.AppendChild(channelNode);

				//image节点
				XmlNode imgNode = _doc.CreateElement("image");
				imgNode.InnerText = item.ImgUrl;
				itemNode.AppendChild(imgNode);

				//title节点
				XmlNode titleNode = _doc.CreateElement("title");
				titleNode.InnerText = item.Title;
				itemNode.AppendChild(titleNode);

				//link节点
				XmlNode linkNode = _doc.CreateElement("link");
				linkNode.InnerText = item.Link;
				itemNode.AppendChild(linkNode);

				//comments节点
				XmlNode commentsNode = _doc.CreateElement("comments");
				commentsNode.InnerText = item.Comments;
				itemNode.AppendChild(commentsNode);

				//pubDate节点
				XmlNode pubDateNode = _doc.CreateElement("pubDate");
				pubDateNode.InnerText = item.PubDate;
				itemNode.AppendChild(pubDateNode);

				//description节点
				XmlNode descriptionNode = _doc.CreateElement("description");
				descriptionNode.InnerText = item.Description;
				itemNode.AppendChild(descriptionNode);


				//contentEncoded节点
				XmlNode contentEncodedNode = _doc.CreateElement("content", "encoded", contentNamespaceUrl);
				contentEncodedNode.InnerText = item.ContentEncoded;
				itemNode.AppendChild(contentEncodedNode);

				_doc.DocumentElement.InsertBefore(itemNode, _doc.DocumentElement.FirstChild);
			}

			_doc.DocumentElement.RemoveChild(tempNode);
		}

		/// <summary>
		/// 将XmlDocument中的数据保存到指定路径
		/// </summary>
		/// <param name="filePath">要保存的文件路径</param>
		public void Save(string filePath)
		{
			try
			{
				_doc.Save(filePath);
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}

		//#region 得到当前内存中存储的所有item中最新的item发布时间
		//public DateTime GetLatestPubDate(string channel)
		//{
		//	DateTime currentLatestPubDate = DateTime.MinValue;

		//	foreach (Item item in _itemSet.Items)
		//	{
		//		DateTime pubDate = DateTime.Parse(item.PubDate);

		//		if (item.Channel == channel && pubDate > currentLatestPubDate)
		//		{
		//			currentLatestPubDate = pubDate;
		//		}
		//	}

		//	return currentLatestPubDate;
		//}
		//#endregion
	}
}