
using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для SanatoriumWindow.xaml
	/// </summary>
	public partial class SanatoriumWindow : Window
	{
		public SanatoriumWindow()
		{
			InitializeComponent();
			DataContext = new SanatoriumWindowViewModel(new DialogService());
		}
	}
}
