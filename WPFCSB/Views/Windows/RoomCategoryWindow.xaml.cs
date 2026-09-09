using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для RoomCategoryWindow.xaml
	/// </summary>
	public partial class RoomCategoryWindow : Window
	{
		public RoomCategoryWindow()
		{
			InitializeComponent();
			DataContext = new RoomCategoryViewModel(new DialogService());
		}
	}
}
