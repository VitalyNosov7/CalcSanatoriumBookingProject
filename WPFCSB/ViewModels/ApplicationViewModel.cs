using System.Collections.ObjectModel;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;
using WPFCSB.Views.Interfaces;
using WPFCSB.Views.Windows;

namespace WPFCSB.ViewModels
{
	public class ApplicationViewModel : ViewModelBase
	{



		private readonly IWindowManager _windowManager;

		public ApplicationViewModel(IWindowManager windowManager)
		{
			_windowManager = windowManager;		
		}

		
		private ObservableCollection<TabBookingItemViewModel> _tabItems = new ObservableCollection<TabBookingItemViewModel>();
		public ObservableCollection<TabBookingItemViewModel> TabItems
		{
			get => _tabItems;
			set
			{
				_tabItems = value;
			}
		}

		// Активный TabItem
		private TabBookingItemViewModel? _selectedTab;
		public TabBookingItemViewModel SelectedTab
		{
			get => _selectedTab!;
			set => Set(ref _selectedTab, value);
		}

		#region КОМАНДЫ
		// Добавление вкладки
		private RelayCommand? addTabCommand;
		public RelayCommand AddTabCommand
		{
			get
			{
				return addTabCommand ??
				  (addTabCommand = new RelayCommand(obj =>
				  {
					  var newTab = new TabBookingItemViewModel();
					  {
						  newTab.Header = $"Tab {TabItems.Count + 1}";
						  newTab.Content = $"Content of tab {TabItems.Count + 1}";
						  newTab.SelectedManager = null!;
						  newTab.SelectedSanatorium = new Sanatorium();
						  DatePeriod currentDatePeriod = new DatePeriod();
						  newTab.NumberNightsBooked = currentDatePeriod.GetTimeInterval(newTab.StartDatePeriodBooking, newTab.EndDatePeriodBooking).Days;						 
						  // TODO: Необходимо реализовать инициализацию данных
						  newTab.SelectedBookingOperation = null!;
					  }
					  ;
					  TabItems.Add(newTab);
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
					  if (tabToRemove != null && TabItems.Contains(tabToRemove))
					  {
						  int index = TabItems.IndexOf((TabBookingItemViewModel)tabToRemove);
						  TabItems.Remove((TabBookingItemViewModel)tabToRemove);

						  // Выбираем предыдущий таб, если текущий удалялся
						  if (TabItems.Any() && SelectedTab == tabToRemove)
						  {
							  int newIndex = Math.Max(0, index - 1);
							  SelectedTab = TabItems[newIndex];
						  }
					  }
				  }));
			}
		}

		// Окно для работы с данными Person из базы данных 
		private RelayCommand? openPersonWindomCommand;
		public RelayCommand OpenPersonWindomCommand
		{
			get
			{
				return openPersonWindomCommand ??
				  (openPersonWindomCommand = new RelayCommand((o) =>
				  {
					 // App.OpenSingleInstancePersonWindow();
					  _windowManager.ShowOrActivate<PersonWindow>();
				  }));
			}
		}

		// Окно для работы с данными Manager из базы данных 
		private RelayCommand? openManagerWindomCommand;
		public RelayCommand OpenManagerWindomCommand
		{
			get
			{
				return openManagerWindomCommand ??
				  (openManagerWindomCommand = new RelayCommand((o) =>
				  {
					  // App.OpenSingleInstancePersonWindow();
					  _windowManager.ShowOrActivate<ManagerWindow>();
				  }));
			}
		}

		// Окно для работы с данными Sanatorium из базы данных 
		private RelayCommand? openSanatoriumWindomCommand;
		public RelayCommand OpenSanatoriumWindomCommand
		{
			get
			{
				return openSanatoriumWindomCommand ??
				  (openSanatoriumWindomCommand = new RelayCommand((o) =>
				  {
					  // App.OpenSingleInstancePersonWindow();
					  _windowManager.ShowOrActivate<SanatoriumWindow>();
				  }));
			}
		}

		// Окно для работы с данными TemplateMessage из базы данных 
		private RelayCommand? openTemplateMessageWindomCommand;
		public RelayCommand OpenTemplateMessageWindomCommand
		{
			get
			{
				return openTemplateMessageWindomCommand ??
				  (openTemplateMessageWindomCommand = new RelayCommand((o) =>
				  {
					  _windowManager.ShowOrActivate<TemplateMessageWindow>();
				  }));
			}
		}

		#endregion КОМАНДЫ

	}
}
