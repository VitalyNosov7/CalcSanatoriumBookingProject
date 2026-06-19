

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WPFCSB.Models
{
    public class TabItemModel
    {
        /// <summary>Текущий TabItem</summary>
        private TabItem? _currentTabItem = default;

        /// <summary>Текущий TabItem</summary>
        public TabItem CurrentTabItem
        {
            get { return _currentTabItem!; }
            set { _currentTabItem = value; }
        }

        /// <summary>Создать вкладку TabItem</summary>
        public void CreateTabItem()
        {
            TabItem createdTabItem = new TabItem();
            StackPanel stackPanelHeader = new StackPanel();
            StackPanel stackPanelContent = new StackPanel();

            //  Заполняем Header в TabItem
            if (TabItemHeaderElements.Count !=0 || TabItemHeaderElements != null)
            {
                foreach(TabItem headerElement in TabItemHeaderElements)
                {
                    stackPanelHeader.Children.Add(headerElement);
                }
                createdTabItem.Header = stackPanelHeader;
            }
            else { MessageBox.Show("Отсутствуют элементы заголовка в коллекции TabItemHeaderElements!"); }

            //  Заполняем Content в TabItem
            if (TabItemContentElements.Count != 0 || TabItemContentElements != null)
            {
                foreach (TabItem contentElement in TabItemContentElements)
                {
                    stackPanelContent.Children.Add(contentElement);
                }
                createdTabItem.Content = stackPanelContent;
            }
            else { MessageBox.Show("Отсутствуют элементы контента в коллекции TabItemContentElements!"); }

            CurrentTabItem = createdTabItem;         
        }

        public TabItemModel(ObservableCollection<Object> tabItemHeaderElements, ObservableCollection<Object> tabItemContentElements)
        {
            TabItemHeaderElements = tabItemHeaderElements;
            TabItemContentElements = tabItemContentElements;           
        }


        #region TabItemHeader
        /// <summary>"Элементы заголовка вкладки TabItem</summary>
        private ObservableCollection<Object>? _tabItemHeaderElements;

        /// <summary>"Элементы заголовка вкладки TabItem</summary>
        public  ObservableCollection<Object> TabItemHeaderElements
        {
            get { return _tabItemHeaderElements!; }
            set { _tabItemHeaderElements = value; }
        }

        /// <summary>Добавить элемент в заголовок TabItemHeader </summary>
        public  void AddTabItemHeaderElement(Object tabItemHeaderElement)
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
