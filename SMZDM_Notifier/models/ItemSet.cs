using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SMZDM_Notifier.models
{
	class ItemSet
	{
		private IList<Item> _items = new List<Item>();

		private string _text;

		public ItemSet()
		{
			//XmlDocument doc = new XmlDocument();



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


		public void Add(Item item)
		{
			_items.Add(item);
		}

		public void Remove(Item item)
		{
			_items.Remove(item);
		}
	}
}
