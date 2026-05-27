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

        private ObservableCollection<TabItemViewModel> _tabs;
        private TabItemViewModel _selectedTab;

        public MainViewModel()
        {
            Tabs = new ObservableCollection<TabItemViewModel>();
            AddTabCommand = new RelayCommand(AddTab);
            RemoveTabCommand = new RelayCommand(RemoveTab);

            // Добавляем начальный таб
            AddTab();
        }

        public ObservableCollection<TabItemViewModel> Tabs
        {
            get => _tabs;
            set
            {
                _tabs = value;
                OnPropertyChanged();
            }
        }

        public TabItemViewModel SelectedTab
        {
            get => _selectedTab;
            set
            {
                _selectedTab = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddTabCommand { get; }
        public ICommand RemoveTabCommand { get; }

        private void AddTab(object parameter = null)
        {
            var newTab = new TabItemViewModel
            {
                Header = $"Tab {Tabs.Count + 1}",
                Content = $"Content of tab {Tabs.Count + 1}"
            };
            Tabs.Add(newTab);
            SelectedTab = newTab;
        }

        private void RemoveTab(Object tabToRemove)
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
