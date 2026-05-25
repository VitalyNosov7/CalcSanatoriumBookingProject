

using System.Collections.ObjectModel;

namespace WPFCSB.Models
{
	public class TabItemModel
	{

        #region TabItemHeader
        /// <summary>"Элементы заголовка вкладки TabItem</summary>
        private ObservableCollection<Object>? _tabItemHeaderElements;

        /// <summary>"Элементы заголовка вкладки TabItem</summary>
        public ObservableCollection<Object> TabItemHeaderElements
		{
			get { return _tabItemHeaderElements!; }
			set { _tabItemHeaderElements = value; }
		}

        /// <summary>Добавить элемент в заголовок TabItemHeader </summary>
        public void AddTabItemHeaderElement(Object  tabItemHeaderElement)
		{
			if (tabItemHeaderElement != null)
			{
				TabItemHeaderElements.Add(tabItemHeaderElement);
			}
		}

        /// <summary>Удалить элемент из заголовка TabItemHeader </summary>
        public void RemoveTabItemHeaderElement(Int32 indexItem)
        {
            if (TabItemHeaderElements != null || TabItemHeaderElements?.Count > 0)
            {
                TabItemHeaderElements.RemoveAt(indexItem);
            }
        }

        /// <summary>Заменить порядок элементов в заголовке TabItemHeader </summary>
        public void MoveTabItemHeaderElement(Int32 oldIndexItem, Int32 newIndexItem)
        {
            if (TabItemHeaderElements != null || TabItemHeaderElements?.Count >= 2)
            {
                TabItemHeaderElements.Move(oldIndexItem, newIndexItem);
            }
        }
        #endregion TabItemHeader

        #region TabItemContext

        /// <summary>Элементы содержимого вкладки TabItem</summary>
        private ObservableCollection<Object>? _tabItemContentElements;

        /// <summary>Элементы содержимого вкладки TabItem</summary>
        public ObservableCollection<Object> TabItemContentElements
        {
            get { return _tabItemContentElements!; }
            set { _tabItemContentElements = value; }
        }


        /// <summary>Добавить элемент в содержимое вкладки TabItemContent </summary>
        public void AddTabItemContentElement(Object tabItemContentElement)
        {
            if (tabItemContentElement != null)
            {
                TabItemContentElements.Add(tabItemContentElement);
            }
        }

        /// <summary>Удалить элемент из содержимого вкладки TabItemContent</summary>
        public void RemoveTabItemContentElement(Int32 indexItem)
        {
            if (TabItemContentElements != null || TabItemContentElements?.Count > 0)
            {
                TabItemContentElements.RemoveAt(indexItem);
            }
        }

        /// <summary>Заменить порядок элементов в содержимоv вкладки  TabItemContent </summary>
        public void MoveTabItemContentElement(Int32 oldIndexItem, Int32 newIndexItem)
        {
            if (TabItemContentElements != null || TabItemContentElements?.Count >= 2)
            {
                TabItemContentElements.Move(oldIndexItem, newIndexItem);
            }
        }

        #endregion TabItemContext



    }
}
