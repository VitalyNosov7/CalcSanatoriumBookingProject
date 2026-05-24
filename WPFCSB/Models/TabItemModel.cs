

using System.Collections.ObjectModel;

namespace WPFCSB.Models
{
	public class TabItemModel
	{
		/// <summary>Заголовок вкладки</summary>
		private ObservableCollection<Object>? _tabItemHeader;

		/// <summary>Заголовок вкладки</summary>
		public ObservableCollection<Object> TabItemHeader
		{
			get { return _tabItemHeader!; }
			set { _tabItemHeader = value; }
		}

		/// <summary>Заголовок содержимого вкладки</summary>
		private ObservableCollection<Object>? _tabItemContent;

		/// <summary>Заголовок содержимого вкладки</summary>
		public ObservableCollection<Object>? TabItemContent
		{
			get { return _tabItemContent!; }
			set { _tabItemContent = value; }
		}

		public void AddTabItemHeader(Object  tabItemHeader)
		{
			
		}

	}
}
