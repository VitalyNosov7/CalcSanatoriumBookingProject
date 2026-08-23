using System.Collections.ObjectModel;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
	public class PersonWindowViewModel : ViewModelBase
	{

		public PersonWindowViewModel()
		{
			ExtractDataPersonFromDBCommand.Execute(null!);
		}

		/// <summary>Список персон</summary>
		private ObservableCollection<Person> _persons = new ObservableCollection<Person>();
		/// <summary>Список персон</summary>
		public ObservableCollection<Person> Persons
		{
			get { return _persons; }
			set => Set(ref _persons, value);
		}

		/// <summary>Выбранная персона</summary>
		private Person _selectedPerson = null!;
		/// <summary>Выбранная персона</summary>
		public Person SelectedPerson
		{
			get { return _selectedPerson; }
			set => Set(ref _selectedPerson, value);
		}

		// Получение данных о персонах из базы данных
		private RelayCommand? extractDataPersonFromDBCommand;
		// Получение данных о персонах из базы данных
		public RelayCommand ExtractDataPersonFromDBCommand
		{
			get
			{
				return extractDataPersonFromDBCommand ??
				  (extractDataPersonFromDBCommand = new RelayCommand(obj =>
				  {
					  using var db = new ApplicationContext();
					  List<Person> listPersons = db.Persons.ToList(); // можно добавить .OrderBy(p => p.Name) и т.п.
					  Persons.Clear();
					  foreach (var person in listPersons)
					  {
						  Persons.Add(person);
					  }
				  }));
			}
		}

	}
}
