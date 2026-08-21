using System.Collections.ObjectModel;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
	public class PersonWindowViewModel : ViewModelBase
	{

		private ObservableCollection<Person> _persons = new ObservableCollection<Person>();

		public ObservableCollection<Person> Persons
		{
			get { return _persons; }
			set => Set(ref _persons, value);
		}

	}
}
