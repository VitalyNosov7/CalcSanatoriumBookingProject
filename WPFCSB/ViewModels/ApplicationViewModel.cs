using System.Collections.ObjectModel;
using WPFCSB.Commands;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
	public class ApplicationViewModel : ViewModelBase
	{
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
						  newTab.SelectedManager = new Manager();
						  newTab.SelectedSanatorium = new Sanatorium();
						  newTab.NumberNightsBooked = newTab.GetTimeInterval(newTab.StartDatePeriodBooking, newTab.EndDatePeriodBooking).Days;
						  // TODO: Необходимо реализовать инициализацию данных
						  newTab.SelectedBookingOperation = newTab.BookingOperationList.FirstOrDefault(bookingOperation => bookingOperation.BookingOperationID == 15);
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

		#endregion КОМАНДЫ

	}
}
