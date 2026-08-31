using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services;
using WPFCSB.Views.Windows;

namespace WPFCSB
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		private new MainWindow MainWindow = new MainWindow();

		private void Application_Startup(object sender, StartupEventArgs e)
        {
            var applicationViewModel = new ApplicationViewModel(new WindowManager());
           MainWindow.DataContext = applicationViewModel;
            MainWindow.Show();
        }
	}
}
