using System.Windows;
using WPFCSB.ViewModels;
namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для PersonWindow.xaml
	/// </summary>
	public partial class PersonWindow : Window
	{
		public PersonWindow()
		{
			InitializeComponent();
			// TODO: рассмотреть вариант через DI
			DataContext = new PersonWindowViewModel();
		}
	}
}
