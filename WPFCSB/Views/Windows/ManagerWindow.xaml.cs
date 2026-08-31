using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для ManagerWindow.xaml
	/// </summary>
	public partial class ManagerWindow : Window
	{
		public ManagerWindow()
		{
			InitializeComponent();
			// TODO: рассмотреть вариант через DI
			DataContext = new ManagerWindowViewModel(new DialogService());
		}
	}
}
