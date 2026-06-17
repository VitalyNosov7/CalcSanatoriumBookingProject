

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using WPFCSB.Commands;

namespace WPFCSB.ViewModels
{
    internal class ApplicationViewModel : INotifyPropertyChanged
    {
        #region РЕАЛИЗАЦИЯ INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
        #endregion РЕАЛИЗАЦИЯ INotifyPropertyChanged

        private ObservableCollection<TabBookingItemViewModel> _tabs = new ObservableCollection<TabBookingItemViewModel>();
        public ObservableCollection<TabBookingItemViewModel> Tabs
        {
            get => _tabs;
            set
            {
                _tabs = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<TabItem> _tabItems = new ObservableCollection<TabItem>();
        public ObservableCollection<TabItem> TabItems
        {
            get => _tabItems;
            set
            {
                _tabItems = value;
                OnPropertyChanged();
            }
        }

        private TabBookingItemViewModel? _selectedTab;

        public TabBookingItemViewModel SelectedTab
        {
            get => _selectedTab!;
            set
            {
                _selectedTab = value;
                OnPropertyChanged();
            }
        }

        private TabItem? _selectedTabItem;

        public TabItem SelectedTabItem
        {
            get => _selectedTabItem!;
            set
            {
                _selectedTabItem = value;
                OnPropertyChanged();
            }
        }

        #region КОМАНДЫ
        //  Добавление вкладки
        private RelayCommand? addTabCommand;
        public RelayCommand AddTabCommand
        {
            get
            {
                return addTabCommand ??
                  (addTabCommand = new RelayCommand(obj =>
                  {
                      var newTab = new TabBookingItemViewModel
                      {
                          Header = $"Tab {Tabs.Count + 1}",
                          Content = $"Content of tab {Tabs.Count + 1}"
                      };
                      Tabs.Add(newTab);
                      SelectedTab = newTab;
                  }));
            }
        }

        //  Добавление вкладки еще вариант
        private RelayCommand? _addTabItemCommand;
        public RelayCommand AddTabItemCommand
        {
            get
            {
                return _addTabItemCommand ??
                  (addTabCommand = new RelayCommand(obj =>
                  {


                      var newTabItem = new TabBookingItemViewModel()
                      {
                          Header = $"Tab {Tabs.Count + 1}",
                          Content = $"Content of tab {Tabs.Count + 1}"
                      };
                      //newTabItem.MyTabItem = newTabItem.CreateTabItem();
                      Tabs.Add(newTabItem);
                      SelectedTab = newTabItem;
                  }));
            }
        }

        //  Удаление вкладки
        private RelayCommand? removeTabCommand;
        public RelayCommand RemoveTabCommand
        {
            get
            {
                return removeTabCommand ??
                  (removeTabCommand = new RelayCommand(tabToRemove =>
                  {
                      if (tabToRemove != null && Tabs.Contains(tabToRemove))
                      {
                          int index = Tabs.IndexOf((TabBookingItemViewModel)tabToRemove);
                          Tabs.Remove((TabBookingItemViewModel)tabToRemove);

                          // Выбираем предыдущий таб, если текущий удалялся
                          if (Tabs.Any() && SelectedTab == tabToRemove)
                          {
                              int newIndex = Math.Max(0, index - 1);
                              SelectedTab = Tabs[newIndex];
                          }
                      }
                  }));
            }
        }

        #endregion КОМАНДЫ

    }
}
