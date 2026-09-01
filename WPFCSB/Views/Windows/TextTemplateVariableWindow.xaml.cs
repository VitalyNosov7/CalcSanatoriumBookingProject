using System.Windows;
using WPFCSB.ViewModels;
using WPFCSB.Views.Services.DialogWindows;

namespace WPFCSB.Views.Windows
{
	/// <summary>
	/// Логика взаимодействия для TextTemplateVariableWindow.xaml
	/// </summary>
	public partial class TextTemplateVariableWindow : Window
	{
		public TextTemplateVariableWindow()
		{
			InitializeComponent();
			DataContext = new TextTemplateVariableViewModel(new DialogService());
		}
	}
}
