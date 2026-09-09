using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для AccommodationTypeWindow.xaml
	/// </summary>
	public partial class AccommodationTypeWindow : Window
	{
		public AccommodationTypeWindow()
		{
			InitializeComponent();
			DataContext = new AccommodationTypeViewModel(new DialogService());
		}
	}
}
