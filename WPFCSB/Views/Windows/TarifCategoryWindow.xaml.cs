using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для TarifCategoryWindow.xaml
	/// </summary>
	public partial class TarifCategoryWindow : Window
	{
		public TarifCategoryWindow()
		{
			InitializeComponent();
			DataContext = new TarifCategoryViewModel(new DialogService());
		}
	}
}
