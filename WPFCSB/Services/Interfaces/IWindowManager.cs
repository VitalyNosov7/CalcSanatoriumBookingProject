
using System.Windows;

namespace WPFCSB.Services.Interfaces
{
	public interface IWindowManager
	{
		void ShowOrActivate<TWindow>() where TWindow : Window, new();
	}
}
