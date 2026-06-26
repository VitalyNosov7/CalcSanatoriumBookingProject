
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
    internal class TabBookingItemViewModel : ViewModelBase
    {


        private String? _header;
        public String Header
        {
            get => _header!;
            set => Set(ref _header, value);
        }


        private String? _content;
        public String Content
        {
            get => _content!;
            set => Set(ref _content, value);
        }

        private TabBookingItemViewModel? _selectedTab;

        public TabBookingItemViewModel SelectedTab
        {
            get => _selectedTab!;
            set => Set(ref _selectedTab, value);
        }




        #region КОМАНДЫ
        //  Добавление вкладки
        //private RelayCommand? addTabCommand;
        //public RelayCommand AddTabCommand
        //{
        //    get
        //    {
        //        return addTabCommand ??
        //          (addTabCommand = new RelayCommand(obj =>
        //          {
        //              var newTab = new TabBookingItemViewModel
        //              {
        //                  Header = $"Tab {Tabs.Count + 1}",
        //                  Content = $"Content of tab {Tabs.Count + 1}"
        //              };
        //              Tabs.Add(newTab);
        //              SelectedTab = newTab;
        //          }));
        //    }
        //}

        //  Добавление вкладки еще вариант
        //private RelayCommand? _addTabItemCommand;
        //public RelayCommand AddTabItemCommand
        //{
        //    get
        //    {
        //        return _addTabItemCommand ??
        //          (addTabCommand = new RelayCommand(obj =>
        //          {


        //              var newTabItem = new TabBookingItemViewModel()
        //              {
        //                  Header = $"Tab {Tabs.Count + 1}",
        //                  Content = $"Content of tab {Tabs.Count + 1}"
        //              };
        //              //newTabItem.MyTabItem = newTabItem.CreateTabItem();
        //              Tabs.Add(newTabItem);
        //              SelectedTab = newTabItem;
        //          }));
        //    }
        //}

        ////  Удаление вкладки
        //private RelayCommand? removeTabCommand;
        //public RelayCommand RemoveTabCommand
        //{
        //    get
        //    {
        //        return removeTabCommand ??
        //          (removeTabCommand = new RelayCommand(tabToRemove =>
        //          {
        //              if (tabToRemove != null && Tabs.Contains(tabToRemove))
        //              {
        //                  int index = Tabs.IndexOf((TabBookingItemViewModel)tabToRemove);
        //                  Tabs.Remove((TabBookingItemViewModel)tabToRemove);

        //                  // Выбираем предыдущий таб, если текущий удалялся
        //                  if (Tabs.Any() && SelectedTab == tabToRemove)
        //                  {
        //                      int newIndex = Math.Max(0, index - 1);
        //                      SelectedTab = Tabs[newIndex];
        //                  }
        //              }
        //          }));
        //    }
        //}

        #endregion КОМАНДЫ

    }
}
