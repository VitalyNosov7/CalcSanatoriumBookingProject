using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using WPFCSB.Commands;
using WPFCSB.ViewModels;


namespace WPFCSB.ViewModels
{
	public class MainViewModel : INotifyPropertyChanged
	{

        public MainViewModel()
        {
            //  ИИ Алиса
            //Tabs = new ObservableCollection<TabItemViewModel>();
            //AddTabCommand = new RelayCommand(AddTab);
            // RemoveTabCommand = new RelayCommand(RemoveTab);

            //// Добавляем начальный таб
            //AddTab();
        }

        private ObservableCollection<TabItemViewModel> _tabs = new ObservableCollection<TabItemViewModel>();
        public ObservableCollection<TabItemViewModel> Tabs
        {
            get => _tabs;
            set
            {
                _tabs = value;
                OnPropertyChanged();
            }
        }
        private TabItemViewModel _selectedTab;    

        public TabItemViewModel SelectedTab
        {
            get => _selectedTab;
            set
            {
                _selectedTab = value;
                OnPropertyChanged();
            }
        }

        //  ИИ Алиса
        //public ICommand AddTabCommand { get; }


        //private void AddTab(object parameter = null)
        //{
        //    var newTab = new TabItemViewModel
        //    {
        //        Header = $"Tab {Tabs.Count + 1}",
        //        Content = $"Content of tab {Tabs.Count + 1}"
        //    };
        //    Tabs.Add(newTab);
        //    SelectedTab = newTab;
        //}

        private RelayCommand addTabCommand;
        public RelayCommand AddTabCommand
        {
            get
            {
                return addTabCommand ??
                  (addTabCommand = new RelayCommand(obj =>
                  {
                      var newTab = new TabItemViewModel
                      {
                          Header = $"Tab {Tabs.Count + 1}",
                          Content = $"Content of tab {Tabs.Count + 1}"
                      };
                      Tabs.Add(newTab);
                      SelectedTab = newTab;
                  }));
            }
        }

        //  ИИ Алиса
        //public ICommand RemoveTabCommand { get; }
        //private void RemoveTab(Object tabToRemove)
        //{
        //    if (tabToRemove != null && Tabs.Contains(tabToRemove))
        //    {
        //        int index = Tabs.IndexOf((TabItemViewModel)tabToRemove);
        //        Tabs.Remove((TabItemViewModel)tabToRemove);

        //        // Выбираем предыдущий таб, если текущий удалялся
        //        if (Tabs.Any() && SelectedTab == tabToRemove)
        //        {
        //            int newIndex = Math.Max(0, index - 1);
        //            SelectedTab = Tabs[newIndex];
        //        }
        //    }
        //}

        private RelayCommand removeTabCommand;
        public RelayCommand RemoveTabCommand
        {
            get
            {
                return removeTabCommand ??
                  (removeTabCommand = new RelayCommand(tabToRemove =>
                  {
                      if (tabToRemove != null && Tabs.Contains(tabToRemove))
                      {
                          int index = Tabs.IndexOf((TabItemViewModel)tabToRemove);
                          Tabs.Remove((TabItemViewModel)tabToRemove);

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //#region реализация INotifyPropertyChanged
        //public event PropertyChangedEventHandler? PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        //{
        //	if (PropertyChanged != null)
        //	{ PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        //}

        ///// <summary>Заголовок главного окна</summary>
        //private String _title = "Главное окно";
        ///// <summary>Заголовок главного окна</summary>
        //public String Title
        //{
        //	get { return _title; }
        //	set
        //	{
        //		if (Equals(_title, value)) { return; }
        //		else { _title = value; }
        //		OnPropertyChanged();
        //	}
        //}
        //#endregion реализация INotifyPropertyChanged

        //#region Команды

        //// команда выхода из програмы
        //private RelayCommand exitAppCommand;
        //public RelayCommand ExitAppCommand
        //{
        //	get
        //	{
        //		return exitAppCommand ??
        //		  (exitAppCommand = new RelayCommand(obj =>
        //		  {
        //			Application.Current.Shutdown();
        //		  }));
        //	}
        //}

        //#endregion Команды

    }
}
