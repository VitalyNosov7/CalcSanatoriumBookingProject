using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WPFCSB.Commands;


namespace WPFCSB.ViewModels
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		#region реализация INotifyPropertyChanged
		public event PropertyChangedEventHandler? PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null)
			{ PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
		}

		/// <summary>Заголовок главного окна</summary>
		private String _title = "Главное окно";
		/// <summary>Заголовок главного окна</summary>
		public String Title
		{
			get { return _title; }
			set
			{
				if (Equals(_title, value)) { return; }
				else { _title = value; }
				OnPropertyChanged();
			}
		}
		#endregion реализация INotifyPropertyChanged

		#region Команды

		// команда выхода из програмы
		private RelayCommand exitAppCommand;
		public RelayCommand ExitAppCommand
		{
			get
			{
				return exitAppCommand ??
				  (exitAppCommand = new RelayCommand(obj =>
				  {
					Application.Current.Shutdown();
				  }));
			}
		}

		#endregion Команды

	}
}
