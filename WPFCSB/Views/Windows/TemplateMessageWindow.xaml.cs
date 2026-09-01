
using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для TemplateMessageWindow.xaml
	/// </summary>
	public partial class TemplateMessageWindow : Window
	{
		public TemplateMessageWindow()
		{
			InitializeComponent();
			DataContext = new TemplateMessageViewModel(new DialogService());
		}
	}
}
