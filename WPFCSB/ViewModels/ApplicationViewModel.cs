

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
