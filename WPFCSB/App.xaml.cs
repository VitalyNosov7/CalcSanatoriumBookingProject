using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Windows;

namespace WPFCSB
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private MainWindow MainWindow;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var applicationViewModel = new ApplicationViewModel();
            MainWindow = new MainWindow { DataContext = applicationViewModel };
            MainWindow.Show();
        }

    }

}
