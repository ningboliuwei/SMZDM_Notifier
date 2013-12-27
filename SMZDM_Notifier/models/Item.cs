using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace SMZDM_Notifier
{
	internal class Item
	{
		/// <summary>
		/// 根据给定的XML文本创建对应的Item对象
		/// </summary>
		/// <param name="xml">给定的XML文本</param>
		public Item(string xml)
		{
			#region 目前用不上
			//InnerXml = xml;
			#endregion

			var doc = new XmlDocument();

			try
			{
				doc.LoadXml(xml);
				#region 目前用不上
				//InnerXml = doc.DocumentElement.InnerXml;
				#endregion
				Title = doc.GetElementsByTagName("title")[0].InnerText;
				Link = doc.GetElementsByTagName("link")[0].InnerText;
				Comments = doc.GetElementsByTagName("comments")[0].InnerText;
				PubDate = DateTime.Parse(doc.GetElementsByTagName("pubDate")[0].InnerText).ToString("yyyy-MM-dd H:mm:ss");
				Description = doc.GetElementsByTagName("description")[0].InnerText;
				ContentEncoded = doc.GetElementsByTagName("content:encoded")[0].InnerText;

				var regImg =
					new Regex(
						@"<img\b[^<>]*?\bsrc[\s\t\r\n]*=[\s\t\r\n]*[""']?[\s\t\r\n]*(?<imgUrl>[^\s\t\r\n""'<>]*)[^<>]*?/?[\s\t\r\n]*>",
						RegexOptions.IgnoreCase);


				foreach (Match m in regImg.Matches(ContentEncoded))
				{
					ImgUrl = m.Groups["imgUrl"].Value;

					#region 目前用不上
					//ContentEncoded = ContentEncoded.Replace(m.Value, "");//去掉正文中的图片链接
					#endregion
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

		#region 目前用不上
		//public string InnerXml { get; set; }
		#endregion
		public string Channel { get; set; }
	}
}