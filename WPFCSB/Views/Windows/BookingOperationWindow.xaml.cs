using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для BookingOperationWindow.xaml
	/// </summary>
	public partial class BookingOperationWindow : Window
	{
		public BookingOperationWindow()
		{
			InitializeComponent();
			// TODO: рассмотреть вариант через DI
			DataContext = new BookingOperationWindowViewModel(new DialogService());
		}
	}
}
