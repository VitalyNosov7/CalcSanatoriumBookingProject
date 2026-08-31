
using System.Windows;

namespace WPFCSB.Views.Interfaces
{
	public interface IWindowManager
	{
		void ShowOrActivate<TWindow>() where TWindow : Window, new();
	}
}
