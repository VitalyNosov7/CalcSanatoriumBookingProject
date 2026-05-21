using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace WPFCSB.ViewModels
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
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

	}
}
