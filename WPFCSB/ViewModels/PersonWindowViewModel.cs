using System.Collections.ObjectModel;
using System.Windows;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.Resources;
using WPFCSB.ViewModels.Base;
using WPFCSB.Views.Interfaces;

namespace WPFCSB.ViewModels
{
	public class PersonWindowViewModel : ViewModelBase
	{

		public PersonWindowViewModel(IDialogService dialogService)
		{
			ExtractDataPersonFromDBCommand.Execute(null!);
			_dialogService = dialogService;
		}

		private readonly IDialogService _dialogService;


		#region СВОЙСТВА ПЕРСОНЫ

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
			get { return _selectedPerson!; }
			set
			{
				Set(ref _selectedPerson, value);
				FillPropertyPerson();
			}
		}

		/// <summary>Идентификатор персоны</summary>
		private Int32 _personID = default;
		/// <summary>Идентификатор персоны</summary>
		public Int32 PersonID
		{
			get { return _personID; }
			set => Set(ref _personID, value);
		}

		/// <summary>Фамилия персоны</summary>
		private String _surname = String.Empty;
		/// <summary>Фамилия персоны</summary>
		public String Surname
		{
			get { return _surname; }
			set => Set(ref _surname, value);
		}

		/// <summary>Имя персоны</summary>
		private String _name = String.Empty;
		/// <summary>Имя персоны</summary>
		public String Name
		{
			get { return _name; }
			set => Set(ref _name, value);
		}

		/// <summary>Отчество персоны</summary>
		private String _patronymic = String.Empty;
		/// <summary>Отчество персоны</summary>
		public String? Patronymic
		{
			get { return _patronymic; }
			set => Set(ref _patronymic!, value);
		}


		/// <summary>Дата рождения персоны</summary>
		private DateTime _birthdate = DateTime.Today;
		/// <summary>Дата рождения персоны</summary>
		public DateTime Birthdate
		{
			get { return _birthdate; }
			set => Set(ref _birthdate, value);
		}

		// TODO: Подумать как будет отображаться в базе данных
		/// <summary>Пол персоны</summary>
		private Gender _gender = default;
		/// <summary>Пол персоны</summary>
		public Gender Gender
		{
			get { return _gender; }
			set => Set(ref _gender, value);
		}

		#endregion СВОЙСТВА ПЕРСОНЫ

		#region КОМАНДЫ

		// TODO: Перенести в метод?
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
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  List<Person> listPersons = db.Persons.ToList();
						  Persons.Clear();
						  foreach (Person person in listPersons)
						  {
							  Persons.Add(person);
						  }

						  SelectedPerson = null!;
						  ClearPropertyPerson();
					  }

				  }));
			}
		}

		// Добавление данных о персоне из базу данных
		private RelayCommand? addPersonToDBCommand;
		// Добавление данных о персоне из базу данных
		public RelayCommand AddPersonToDBCommand
		{
			get
			{
				return addPersonToDBCommand ??
				  (addPersonToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  Person newPerson = CreateNewPerson();
						  db.Persons.Add(newPerson);
						  db.SaveChanges();

						  // TODO: Подумать как еще можно обновлять данные
						  ExtractDataPersonFromDBCommand.Execute(null!);
					  }
				  }));
			}
		}

		// Редактирование данных о персоне в базе данных
		private RelayCommand? editPersonToDBCommand;
		// Редактирование данных о персоне в базе данных
		public RelayCommand EditPersonToDBCommand
		{
			get
			{
				return editPersonToDBCommand ??
				  (editPersonToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedPerson != null)
						  {
							  Person? selectedPerson = SelectedPerson;
							  // Person editedPerson = new Person(Surname, Name, Patronymic!, Birthdate, Gender);
							  Person editedPerson = CreateNewPerson();
							  Person? foundEditedPerson = db.Persons.Find(selectedPerson.PersonID);

							  if (foundEditedPerson != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение редактирования", $"Вы действительно хотите редактировать дынне персоны c ID «{foundEditedPerson.PersonID}» - «{foundEditedPerson.FullNamePerson}»?");

								  if (confirmed == true) // Если подтверждаем редактирования
								  {
									  // TODO: Подумать как можно сдклать валидатор
									  if (foundEditedPerson.Surname != editedPerson.Surname)
									  { foundEditedPerson.Surname = editedPerson.Surname; }
									  if (foundEditedPerson.Name != editedPerson.Name)
									  { foundEditedPerson.Name = editedPerson.Name; }
									  if (foundEditedPerson.Patronymic != editedPerson.Patronymic)
									  { foundEditedPerson.Patronymic = editedPerson.Patronymic; }
									  if (foundEditedPerson.Birthdate != editedPerson.Birthdate)
									  { foundEditedPerson.Birthdate = editedPerson.Birthdate; }
									  if (foundEditedPerson.Gender != editedPerson.Gender)
									  { foundEditedPerson.Gender = editedPerson.Gender; }
									  if (foundEditedPerson.FullNamePerson != editedPerson.FullNamePerson)
									  { foundEditedPerson.FullNamePerson = editedPerson.FullNamePerson; }
									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataPersonFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем редактирования
							  }
						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать персону из списка");
							  return;
						  }
					  }
				  }));
			}
		}


		// Удаление персоны из базы данных
		private RelayCommand? deletePersonToDBCommand;
		// Удаление персоны из базы данных
		public RelayCommand DeletePersonToDBCommand
		{
			get
			{
				return deletePersonToDBCommand ??
				  (deletePersonToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedPerson != null)
						  {
							  Person selectedPerson = SelectedPerson;
							  Person? foundDeletedPerson = db.Persons.Find(selectedPerson.PersonID);
							  if (foundDeletedPerson != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение удаления", $"Вы действительно хотите удалить персону c ID «{foundDeletedPerson.PersonID}» -  «{foundDeletedPerson.FullNamePerson}»?");

								  if (confirmed == true) // Если подтверждаем удаление
								  {
									  db.Persons.Remove(foundDeletedPerson!);
									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataPersonFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем удаление

							  }

						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать персону из списка");
							  return;
						  }

					  }

				  }));
			}
		}


		// Снять выделение персоны
		private RelayCommand? deselectPersonCommand;
		// Снять выделение персоны
		public RelayCommand DeselectPersonCommand
		{
			get
			{
				return deselectPersonCommand ??
				  (deselectPersonCommand = new RelayCommand(obj =>
				  {

					  SelectedPerson = null!;
					  ClearPropertyPerson();

				  }));
			}
		}

		// Обновление данных о персонах из базы данных
		private RelayCommand? updateDataPersonFromDBCommand;
		// Обновление данных о персонах из базы данных
		public RelayCommand UpdateDataPersonFromDBCommand
		{
			get
			{
				return updateDataPersonFromDBCommand ??
				  (updateDataPersonFromDBCommand = new RelayCommand(obj =>
				  {
					  ExtractDataPersonFromDBCommand.Execute(null!);
				  }));
			}
		}

		// TODO: Добавить команду, которая будет очищать поля в форме

		#endregion КОМАНДЫ

		#region МЕТОДЫ

		/// <summary>Заполнить свойства персоны</summary>
		private void FillPropertyPerson()
		{
			if (SelectedPerson != null)
			{
				PersonID = SelectedPerson.PersonID;
				Surname = SelectedPerson.Surname;
				Name = SelectedPerson.Name;
				Patronymic = SelectedPerson.Patronymic;
				Birthdate = SelectedPerson.Birthdate;
				Gender = SelectedPerson.Gender;
			}
			else
			{
				return;
			}
		}

		/// <summary>Очистить свойства персоны</summary>
		private void ClearPropertyPerson()
		{
			PersonID = default;
			Surname = String.Empty;
			Name = String.Empty;
			Patronymic = String.Empty;
			Birthdate = DateTime.Today;
			Gender = default;
		}

		// TODO: доработать метод - нужно проверять на одинаковые PersonID из БД
		/// <summary>Создаем экземпляр Person в конструкторе без PersonID()</summary>
		private Person CreateNewPerson()
		{
			// TODO: разработать валидатор - 1. первые символы ФИО заглавными буквами, 2. Проверка даты рождения
			Person CreatedNewPerson = new Person(Surname, Name, Patronymic!, Birthdate, Gender);
			return CreatedNewPerson;
		}

		// TODO: добавить метод поиска в базе одинакового PersonID

		// TODO: добавить метод получения в базе последнего PersonID

		#endregion МЕТОДЫ

	}
}
