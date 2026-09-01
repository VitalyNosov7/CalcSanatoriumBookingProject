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
	public class ManagerWindowViewModel : ViewModelBase
	{

		public ManagerWindowViewModel(IDialogService dialogService)
		{
			ExtractDataManagerFromDBCommand.Execute(null!);
			_dialogService = dialogService;
		}

		private readonly IDialogService _dialogService;

		/// <summary>Список персон</summary>
		private ObservableCollection<Manager> _managers = new ObservableCollection<Manager>();
		/// <summary>Список персон</summary>
		public ObservableCollection<Manager> Managers
		{
			get { return _managers; }
			set => Set(ref _managers, value);
		}

		/// <summary>Выбранная персона</summary>
		private Manager _selectedManager = null!;
		/// <summary>Выбранная персона</summary>
		public Manager SelectedManager
		{
			get { return _selectedManager!; }
			set
			{
				Set(ref _selectedManager, value);
				FillPropertyManager();
			}
		}

		/// <summary>Идентификатор менеджера</summary>
		private Int32 _managerID = default;
		/// <summary>Идентификатор менеджера</summary>
		public Int32 ManagerID
		{
			get { return _managerID; }
			set => Set(ref _managerID, value);
		}

		/// <summary>Идентификатор персоны менеджера(Внешний ключ)</summary>
		private Int32 _managerPersonID = default;
		/// <summary>Идентификатор персоны менеджера(Внешний ключ)</summary>
		public Int32 ManagerPersonID
		{
			get { return _managerPersonID; }
			set => Set(ref _managerPersonID, value);
		}

		/// <summary>Личность менеджера</summary>
		private Person _managerPerson = null!;
		/// <summary>Личность менеджера</summary>		
		public Person ManagerPerson
		{
			get { return _managerPerson; }
			set => Set(ref _managerPerson, value);
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


		// Получение данных о менеджерах из базы данных
		private RelayCommand? extractDataManagerFromDBCommand;
		// Получение данных о менеджерах из базы данных
		public RelayCommand ExtractDataManagerFromDBCommand
		{
			get
			{
				return extractDataManagerFromDBCommand ??
				  (extractDataManagerFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  List<Manager> listManagers = db.Managers.ToList();
						  Managers.Clear();
						  foreach (Manager manager in listManagers)
						  {
							  Person? foundManagerPerson = db.Persons.Find(manager.ManagerPersonID);
							  if(foundManagerPerson != null)
							  {
								  Person createdNewPerson = new Person
								  {
									  PersonID = foundManagerPerson.PersonID,
									  Surname = foundManagerPerson.Surname,
									  Name = foundManagerPerson.Name,
									  Patronymic = foundManagerPerson.Patronymic!,
									  Birthdate = foundManagerPerson.Birthdate,
									  Gender = foundManagerPerson.Gender,
									  FullNamePerson = foundManagerPerson.FullNamePerson
								  };
								  manager.ManagerPerson = createdNewPerson;
								  Managers.Add(manager);
							  }
							  else
							  {
								  MessageBox.Show("Данные о менеджере не найдены в базе данных!");
								  return;
							  }
							 
						  }

						  SelectedManager = null!;
						  ClearPropertyManager();						  
					  }

				  }));
			}
		}

		// Добавление данных о менеджерах в базу данных
		private RelayCommand? addManagerFromDBCommand;
		// Добавление данных о менеджерах в базу данных
		public RelayCommand AddManagerFromDBCommand
		{
			get
			{
				return addManagerFromDBCommand ??
				  (addManagerFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  Person newPerson = CreateNewPerson();
						  //db.Persons.Add(newPerson);

						  db.Persons.Add(newPerson);
						  db.SaveChanges();

						  Int32 newPersonID = newPerson.PersonID;

						  Manager newManager = new Manager();
						  newManager.ManagerPersonID = newPersonID;
						  db.Managers.Add(newManager);
						  db.SaveChanges();

						  // TODO: Подумать как еще можно обновлять данные
						  ExtractDataManagerFromDBCommand.Execute(null!);
					  }

				  }));
			}
		}


		// Редактирование данных о менеджере в базе данных
		private RelayCommand? editManagerToDBCommand;
		// Редактирование данных о менеджере в базе данных
		public RelayCommand EditManagerToDBCommand
		{
			get
			{
				return editManagerToDBCommand ??
				  (editManagerToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedManager != null)
						  {
							  Manager? selectedManager = SelectedManager;
							  Manager? foundEditedManager = db.Managers.Find(selectedManager.ManagerID);
							  Person editedPerson = CreateNewPerson();
							  Person? foundEditedPerson = db.Persons.Find(selectedManager.ManagerPersonID);

							  if (foundEditedPerson != null && foundEditedManager != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение редактирования", $"Вы действительно хотите редактировать дынне менеджера c ID «{foundEditedManager.ManagerID}» персоны c ID «{foundEditedPerson.PersonID}» - «{foundEditedPerson.FullNamePerson}»?");

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
									  ExtractDataManagerFromDBCommand.Execute(null!);									  
								  }
								  else { return; } // Если не подтверждаем редактирования
							  }
						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать менеджера из списка");
							  return;
						  }
					  }
				  }));
			}
		}


		// Удаление менеджера(персоны) из базы данных
		private RelayCommand? deleteManagerToDBCommand;
		// Удаление менеджера(персоны) из базы данных
		public RelayCommand DeleteManagerToDBCommand
		{
			get
			{
				return deleteManagerToDBCommand ??
				  (deleteManagerToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedManager != null)
						  {
							  Manager selectedManager = SelectedManager;
							  Manager? foundDeletedManager = db.Managers.Find(selectedManager.ManagerID);
							  Person? foundDeletedPerson = db.Persons.Find(selectedManager.ManagerPersonID);					 
							  

							  if (foundDeletedManager != null && foundDeletedPerson != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение удаления", $"Вы действительно хотите удалить персону менеджера c ID «{foundDeletedManager.ManagerID}» персоны c ID «{foundDeletedPerson.PersonID}» -  «{foundDeletedPerson.FullNamePerson}»?");

								  if (confirmed == true) // Если подтверждаем удаление
								  {
									  db.Persons.Remove(foundDeletedPerson!);
									  db.Managers.Remove(foundDeletedManager!);
									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataManagerFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем удаление

							  }

						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать менеджера из списка");
							  return;
						  }

					  }

				  }));
			}
		}

		// Обновление данных о менеджерах из базы данных
		private RelayCommand? updateDataЬManagerFromDBCommand;
		// Обновление данных о менеджерах из базы данных
		public RelayCommand UpdateDataЬManagerFromDBCommand
		{
			get
			{
				return updateDataЬManagerFromDBCommand ??
				  (updateDataЬManagerFromDBCommand = new RelayCommand(obj =>
				  {
					  ExtractDataManagerFromDBCommand.Execute(null!);
				  }));
			}
		}

		// Снять выделение менеджера
		private RelayCommand? deselectManagerCommand;
		// Снять выделение менеджера
		public RelayCommand DeselectManagerCommand
		{
			get
			{
				return deselectManagerCommand ??
				  (deselectManagerCommand = new RelayCommand(obj =>
				  {
					  SelectedManager = null!;
					  ClearPropertyManager();
				  }));
			}
		}

		/// <summary>Заполнить свойства персоны</summary>
		private void FillPropertyManager()
		{
			if (SelectedManager != null)
			{
				ManagerID = SelectedManager.ManagerID;
				ManagerPersonID = SelectedManager.ManagerPerson.PersonID;
				Surname = SelectedManager.ManagerPerson.Surname;
				Name = SelectedManager.ManagerPerson.Name;
				Patronymic = SelectedManager.ManagerPerson.Patronymic;
				Birthdate = SelectedManager.ManagerPerson.Birthdate;
				Gender = SelectedManager.ManagerPerson.Gender;
			}
			else
			{
				return;
			}
		}

		/// <summary>Очистить свойства персоны</summary>
		private void ClearPropertyManager()
		{
			ManagerID = default;
			ManagerPersonID = default;
			Surname = String.Empty;
			Name = String.Empty;
			Patronymic = String.Empty;
			Birthdate = DateTime.Today;
			Gender = default;
		}

		private Person CreateNewPerson()
		{
			// TODO: разработать валидатор - 1. первые символы ФИО заглавными буквами, 2. Проверка даты рождения
			Person CreatedNewPerson = new Person(Surname, Name, Patronymic!, Birthdate, Gender);
			return CreatedNewPerson;
		}
	}
}
