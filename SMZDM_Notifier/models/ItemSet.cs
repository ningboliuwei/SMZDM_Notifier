using System.Collections.Generic;

namespace SMZDM_Notifier.models
{
	internal class ItemSet
	{
		private IList<Item> _items = new List<Item>();

		public IList<Item> Items
		{
			get { return _items; }
			set { _items = value; }
		}

		public string Text { get; set; }


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