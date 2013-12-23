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

		private string filePath = Application.StartupPath + "\\" + FILE_NAME;

		private ItemSet _itemSet;

		private XmlDocument doc;

		private string XML_DECLARATION = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";

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
					doc.LoadXml(XML_DECLARATION);
				}

				XmlNode itemsNode = doc.GetElementsByTagName("items")[0];
				
				


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

	}
}
