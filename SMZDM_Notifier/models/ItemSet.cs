using System.Collections.Generic;

namespace SMZDM_Notifier.models
{
	internal class ItemSet
	{
		private List<Item> _items = new List<Item>();

		public List<Item> Items
		{
			get { return _items; }
			#region 目前用不上
			//set { _items = value; }
			#endregion
		}

		#region 目前用不上
		//public string Text { get; set; }
		#endregion

		/// <summary>
		/// 添加一个新的Item到当前ItemSet中
		/// </summary>
		/// <param name="item">要添加的Item对象</param>
		public void Add(Item item)
		{
			_items.Add(item);
		}

		#region 目前用不上
		//public void Remove(Item item)
		//{
		//	_items.Remove(item);
		//}
		#endregion
	}
}