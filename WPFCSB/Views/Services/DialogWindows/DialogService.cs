using System.Windows;
using WPFCSB.Views.Interfaces;

namespace WPFCSB.Views.Services.DialogWindows
{
	public class DialogService : IDialogService
	{
		public bool? Confirm(String title, String message)
		{
			return MessageBox.Show(message, title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
		}
	}
}
