using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace SMZDM_Notifier
{
	class Item
	{
		public string Title { get; set; }

		public string Link { get; set; }

		public string Comments { get; set; }

		public string PubDate { get; set; }
		public string Description { get; set; }
		public string ContentEncoded { get; set; }

		public IList<string> ImgUrls { get; set; }

		public string Text { get; set; }

		public string Channel { get; set; }

		public Item(string text)
		{
			Text = text;

			XmlDocument doc = new XmlDocument();

			try
			{
				doc.LoadXml(text);
				Title = doc.GetElementsByTagName("title")[0].InnerText;
				Link = doc.GetElementsByTagName("link")[0].InnerText;
				Comments = doc.GetElementsByTagName("comments")[0].InnerText;
				PubDate = doc.GetElementsByTagName("pubDate")[0].InnerText;
				Description = doc.GetElementsByTagName("description")[0].InnerText;
				ContentEncoded = doc.GetElementsByTagName("content:encoded")[0].InnerText;

				Regex regImg = new Regex(@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>", RegexOptions.IgnoreCase);

				ImgUrls = new List<string>();
				foreach (Match m in regImg.Matches(ContentEncoded))
				{
					ImgUrls.Add(m.Groups["imgUrl"].Value);
					ContentEncoded = ContentEncoded.Replace(m.Value, "");
				}
			}
			catch (Exception exception)
			{

				throw new Exception(exception.Message);
			}
		}
	}
}
