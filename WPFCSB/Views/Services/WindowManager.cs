using System.Windows;
using WPFCSB.Views.Interfaces;

namespace WPFCSB.Views.Services
{
	class WindowManager : IWindowManager
	{
		public void ShowOrActivate<TWindow>() where TWindow : Window, new()
		{
			// Проверяем, существует ли открытое окно TWindow
			var existing = Application.Current.Windows.OfType<TWindow>().FirstOrDefault();
			if (existing != null)
			{
				existing.Activate();
				return;
			}

			var window = new TWindow();
			window.Show();
		}
	}
}
