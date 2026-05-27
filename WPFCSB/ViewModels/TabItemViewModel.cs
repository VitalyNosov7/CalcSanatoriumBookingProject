
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using WPFCSB.Commands;
using WPFCSB.Models;


namespace WPFCSB.ViewModels
{
    public class TabItemViewModel : INotifyPropertyChanged
    {

        private string _header;
        private string _content;

        public string Header
        {
            get => _header;
            set
            {
                _header = value;
                OnPropertyChanged();
            }
        }

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        #region КОД НЕ РАБОЧИЙ

        //private ObservableCollection<TabItem>? _tabItems = new ObservableCollection<TabItem>();
        ///// <summary>Коллекция вкладок TabItem</summary>
        //public ObservableCollection<TabItem> TabItems 
        //{
        //    get { return _tabItems!; }
        //    set
        //    {
        //        _tabItems = value;
        //        OnPropertyChanged();
        //    }

        //}

        ///// <summary>Выбранная вкладка TabItem</summary>
        //private TabItem? _selectedTabItem;
        ///// <summary>Выбранная вкладка TabItem</summary>
        //public TabItem SelectedTabItem
        //{
        //    get { return _selectedTabItem!; }
        //    set
        //    {
        //        _selectedTabItem = value;
        //        OnPropertyChanged("SelectedTabItem");
        //    }
        //}

        //// Добавление TabItem в коллекцию TabItems
        //private void AddTabItemsElement (TabItem addedTabItem)
        //{
        //    if(addedTabItem !=null)
        //    {
        //        TabItems!.Add(addedTabItem);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Отсутствует элемент TabItem в коллекции TabItems");
        //    }
        //}

        ///// <summary>Текущий TabItem</summary>
        //private TabItem? _currentTabItem = default;

        ///// <summary>Текущий TabItem</summary>
        //public TabItem CurrentTabItem
        //{
        //    get { return _currentTabItem!; }
        //    set { _currentTabItem = value; }
        //}

        ///// <summary>Текущая модель TabItem</summary>
        //private TabItemModel? _currentTabItemModel = default;
        ///// <summary>Текущая модель TabItem</summary>
        //public TabItemModel CurrentTabItemModel
        //{
        //    get { return _currentTabItemModel!; }
        //    set 
        //    {
        //        _currentTabItemModel = value; 
        //    }
        //}

        ///// <summary>"Элементы заголовка вкладки TabItem</summary>
        //private ObservableCollection<Object>? _tabItemHeaderElements = new ObservableCollection<Object>();

        ///// <summary>"Элементы заголовка вкладки TabItem</summary>
        //public ObservableCollection<Object> TabItemHeaderElements
        //{
        //    get { return _tabItemHeaderElements!; }
        //    set 
        //    {
        //        _tabItemHeaderElements = value;
        //        OnPropertyChanged("TabItemHeaderElements");
        //    }
        //}

        ///// <summary>Добавить элемент в заголовок TabItemHeader </summary>
        //private void AddTabItemHeaderElement(Object tabItemHeaderElement)
        //{
        //    if (tabItemHeaderElement != null)
        //    {
        //        TabItemHeaderElements.Add(tabItemHeaderElement);
        //    }
        //}

        ///// <summary>Элементы содержимого вкладки TabItem</summary>
        //private ObservableCollection<Object>? _tabItemContentElements = new ObservableCollection<Object>();

        ///// <summary>Элементы содержимого вкладки TabItem</summary>
        //public ObservableCollection<Object> TabItemContentElements
        //{
        //    get { return _tabItemContentElements!; }
        //    set
        //    { 
        //        _tabItemContentElements = value;
        //        OnPropertyChanged("TabItemContentElements");
        //    }
        //}





        //public event PropertyChangedEventHandler? PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName ));
        //}



        //// Заволнить заголовок TabItemHeader
        //private void FillTabItemHeader()
        //{
        //    //  Текст заголовка Header
        //    AddTabItemHeaderElement(new TextBlock { Text = "Бронь" });
        //    AddTabItemHeaderElement(new Ellipse() {Width=10,Height=10,Fill=new SolidColorBrush(Colors.Red) });
        //}

        ///// <summary>Добавить элемент в содержимое вкладки TabItemContent </summary>
        //private void AddTabItemContentElement(Object tabItemContentElement)
        //{
        //    if (tabItemContentElement != null)
        //    {
        //        TabItemContentElements.Add(tabItemContentElement);
        //    }
        //}

        //// Заволнить контент TabItemHeader
        //private void FillTabItemContent()
        //{
        //    AddTabItemContentElement(new TextBlock() { Text="Тестовое содержимое контекста TabItem", FontSize = 14 });

        //}

        //#region Команды

        //// команда добавления нового объекта
        //private RelayCommand? addBookingTabItemCommand;
        //public RelayCommand AddBookingTabItemCommand
        //{
        //    get
        //    {
        //        return addBookingTabItemCommand ??
        //          (addBookingTabItemCommand = new RelayCommand(obj =>
        //          {
        //              FillTabItemHeader();
        //              FillTabItemContent();

        //              CurrentTabItemModel = new TabItemModel(TabItemHeaderElements, TabItemContentElements);
        //              TabItem createdTabItem = new TabItem();
        //              StackPanel stackPanelHeader = new StackPanel();
        //              StackPanel stackPanelContent = new StackPanel();

        //              //  Заполняем Header в TabItem
        //              if (TabItemHeaderElements.Count != 0 || TabItemHeaderElements != null)
        //              {
        //                  foreach (Object headerElement in TabItemHeaderElements)
        //                  {
        //                      stackPanelHeader.Children.Add((UIElement)headerElement);
        //                  }
        //                  createdTabItem.Header = stackPanelHeader;
        //              }
        //              else { MessageBox.Show("Отсутствуют элементы заголовка в коллекции TabItemHeaderElements!"); }

        //              //  Заполняем Content в TabItem
        //              if (TabItemContentElements.Count != 0 || TabItemContentElements != null)
        //              {
        //                  foreach (Object contentElement in TabItemContentElements)
        //                  {
        //                      stackPanelContent.Children.Add((UIElement)contentElement);
        //                  }
        //                  createdTabItem.Content = stackPanelContent;
        //              }
        //              else { MessageBox.Show("Отсутствуют элементы контента в коллекции TabItemContentElements!"); }

        //              CurrentTabItem = createdTabItem;
        //              AddTabItemsElement(CurrentTabItem);

        //          }));
        //    }
        //}

        //#endregion Команды

        #endregion КОД НЕ РАБОЧИЙ

    }
}
