using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace SMZDM_Notifier
{
	internal class Item
	{
		public Item(string xml)
		{
			InnerXml = xml;

			var doc = new XmlDocument();

			try
			{
				doc.LoadXml(xml);
				InnerXml = doc.DocumentElement.InnerXml;
				Title = doc.GetElementsByTagName("title")[0].InnerText;
				Link = doc.GetElementsByTagName("link")[0].InnerText;
				Comments = doc.GetElementsByTagName("comments")[0].InnerText;
				PubDate = doc.GetElementsByTagName("pubDate")[0].InnerText;
				Description = doc.GetElementsByTagName("description")[0].InnerText;
				ContentEncoded = doc.GetElementsByTagName("content:encoded")[0].InnerText;

				var regImg =
					new Regex(
						@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>",
						RegexOptions.IgnoreCase);


				foreach (Match m in regImg.Matches(ContentEncoded))
				{
					ImgUrl = m.Groups["imgUrl"].Value;
					//ContentEncoded = ContentEncoded.Replace(m.Value, "");//去掉正文中的图片链接
				}
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
		}

		public string Title { get; set; }
		public string Link { get; set; }
		public string Comments { get; set; }
		public string PubDate { get; set; }
		public string Description { get; set; }
		public string ContentEncoded { get; set; }
		public string ImgUrl { get; set; }
		public string InnerXml { get; set; }
		public string Channel { get; set; }
	}
}