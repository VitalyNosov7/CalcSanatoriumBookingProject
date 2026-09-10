using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Documents;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;
using WPFCSB.Views.Services;

namespace WPFCSB.ViewModels
{
	/// <summary>Модель представления вкладки с информацией о бронировании</summary>
	public class TabBookingItemViewModel : ViewModelBase
	{
		public TabBookingItemViewModel()
		{
			LoadingListsFromDatabase(); // Загрузка списков из базы данных		
		}

		private OpenWindowsCommands _openWindowsCommands = new OpenWindowsCommands(new WindowManager());

		public OpenWindowsCommands OpenWindowsCommands
		{
			get { return _openWindowsCommands; }
			set { _openWindowsCommands = value; }
		}

		#region ЗАГОЛОВОК

		// TODO: выводить в заголовок информацию о текущем бронировании(ФИО основного гостя)
		/// <summary>Заголовок вкладки.</summary>
		private String? _header;
		/// <summary>Заголовок вкладки.</summary>
		public String Header
		{
			get => _header!;
			set => Set(ref _header, value);
		}
		#endregion ЗАГОЛОВОК

		#region КОНТЕНТ

		// TODO: Подумать над дальнейшем использовании этого свойства
		/// <summary>Контент(это пример, который далее можно удалить или объединить весь контент в это свойство).</summary>
		private String? _content;
		/// <summary>Контент(это пример, который далее можно удалить или объединить весь контент в это свойство).</summary>
		public String Content
		{
			get => _content!;
			set => Set(ref _content, value);
		}

		#region ПЕРСОНА

		///// <summary>Список гостей</summary>
		//private ObservableCollection<Person> _guestList = new ObservableCollection<Person>();
		///// <summary>Список гостей</summary>
		//public ObservableCollection<Person> GuestList
		//{
		//	get { return _guestList; }
		//	set => Set(ref _guestList, value);
		//}

		//// TODO: Тут логично использовать класс User
		///// <summary>Выбранный гость</summary>
		//private Person _selectedGuest = null!;
		///// <summary>Выбранный гость</summary>
		//public Person SelectedGuest
		//{
		//	get { return _selectedGuest; }
		//	set => Set(ref _selectedGuest, value);
		//}


		// Доступ к методам класса Person
		/// <summary>Основной гость</summary>
		private Person _mainGuestPerson = new Person();
		/// <summary>Основной гость</summary>
		public Person MainGuestPerson
		{
			get { return _mainGuestPerson; }
			set { _mainGuestPerson = value; }
		}
		#endregion ПЕРСОНА

		#region ГОСТИ

		/// <summary>Список гостей</summary>
		private ObservableCollection<Guest> _guestList = new ObservableCollection<Guest>();
		/// <summary>Список гостей</summary>
		public ObservableCollection<Guest> GuestList
		{
			get { return _guestList; }
			set => Set(ref _guestList, value);
		}

		/// <summary>Выбранный гость</summary>
		private Guest _selectedGuest = null!;
		/// <summary>Выбранный гость</summary>
		public Guest SelectedGuest
		{
			get { return _selectedGuest; }
			set => Set(ref _selectedGuest, value);
		}

		//// Загрузка списка гостей.
		//private void LoadGuestList()
		//{

		//	// Загрузка списка гостей из базы данных.
		//	using (ApplicationContext db = new ApplicationContext())
		//	{
		//		var guestPersons = db.Persons.Join(db.Guests, // второй набор
		//			p => p.PersonID, // свойство-селектор объекта из первого набора
		//			m => m.GuestPersonID, // свойство-селектор объекта из второго набора
		//			(p, m) => new Guest// результат
		//			{
		//				GuestID = m.GuestID,
		//				GuestPersonID = m.GuestPersonID,
		//				GuestPerson = new Person(p.PersonID, p.Surname, p.Name, p.Patronymic!, p.Birthdate, p.Gender)
		//			});
		//		ManagerList.Clear();
		//		foreach (var guestPerson in guestPersons)
		//		{
		//			GuestList.Add(guestPerson);
		//		}
		//	}
		//}

		/// <summary>ФИО основного гостя</summary>
		private String _fullNameMainGuest = String.Empty;
		/// <summary>ФИО основного гостя</summary>
		public String FullNameMainGuest
		{
			get { return _fullNameMainGuest; }
			set
			{
				Set(ref _fullNameMainGuest, value);
				GetTemplameMessageCommand.Execute(null!);
			}
		}

		#endregion ГОСТИ


		#region МЕНЕДЖЕРЫ

		/// <summary>Список менеджеров</summary>
		private ObservableCollection<Manager> _managerList = new ObservableCollection<Manager>();
		/// <summary>Список менеджеров</summary>
		public ObservableCollection<Manager> ManagerList
		{
			get { return _managerList; }
			set => Set(ref _managerList, value);
		}

		/// <summary>Выбранный менеджер</summary>
		private Manager _selectedManager = null!;
		/// <summary>Выбранный менеджер</summary>
		public Manager SelectedManager
		{
			get { return _selectedManager; }
			set => Set(ref _selectedManager, value);
		}

		// Загрузка списка менеджеров.
		private void LoadManagerList()
		{

			// Загрузка списка менеджеров из базы данных.
			using (ApplicationContext db = new ApplicationContext())
			{
				var managerPersons = db.Persons.Join(db.Managers, // второй набор
					p => p.PersonID, // свойство-селектор объекта из первого набора
					m => m.ManagerPersonID, // свойство-селектор объекта из второго набора
					(p, m) => new Manager// результат
					{
						ManagerID = m.ManagerID,
						ManagerPersonID = m.ManagerPersonID,
						ManagerPerson = new Person(p.PersonID, p.Surname, p.Name, p.Patronymic!, p.Birthdate, p.Gender)
					});
				ManagerList.Clear();
				foreach (var managerPerson in managerPersons)
				{
					ManagerList.Add(managerPerson);
				}
			}
		}
		#endregion МЕНЕДЖЕРЫ

		#region САНАТОРИИ

		/// <summary>Список санаториев</summary>
		private ObservableCollection<Sanatorium> _sanatoriumList = new ObservableCollection<Sanatorium>();
		/// <summary>Список санаториев</summary>
		public ObservableCollection<Sanatorium> SanatoriumList
		{
			get { return _sanatoriumList; }
			set => Set(ref _sanatoriumList, value);
		}

		/// <summary>Выбранный санаторий</summary>
		private Sanatorium _selectedSanatorium = null!;
		/// <summary>Выбранный санаторий</summary>
		public Sanatorium SelectedSanatorium
		{
			get { return _selectedSanatorium; }
			set
			{
				Set(ref _selectedSanatorium, value);
				LoadRoomCategoryList();
				LoadAccommodationTypeList();
				LoadTarifCategoryList();
				GetTemplameMessageCommand.Execute(String.Empty);
			}
		}

		/// <summary>Загрузка списка санаториев</summary>
		private void LoadSanatoriumList()
		{

			// Загрузка списка санаториев из базы данных.
			using (ApplicationContext db = new ApplicationContext())
			{
				var sanatoriums = db.Sanatoriums.ToList();
				//	SanatoriumList.Clear();
				foreach (Sanatorium sanatorium in sanatoriums)
				{
					SanatoriumList.Add(sanatorium);
				}
			}
		}

		#endregion САНАТОРИИ

		#region ПЕРИОД БРОНИРОВАНИЯ

		/// <summary>Дата начала периода бронирования</summary>
		private DateTime _startDatePeriodBooking = DateTime.Today;
		/// <summary>Дата начала периода  бронирования</summary>
		public DateTime StartDatePeriodBooking
		{
			get { return _startDatePeriodBooking; }
			set
			{
				Set(ref _startDatePeriodBooking, value);
				DatePeriod currentDatePeriod = new DatePeriod();
				NumberNightsBooked = currentDatePeriod.GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
				NumberDaysUntilBooking = currentDatePeriod.GetTimeInterval(DateTime.Now, StartDatePeriodBooking.AddDays(1)).Days;
				GetTemplameMessageCommand.Execute(null!);
			}
		}

		/// <summary>Дата окончания периода  бронирования</summary>
		private DateTime _endDatePeriodBooking = DateTime.Now.AddDays(10);
		/// <summary>Дата окончания периода  бронирования</summary>
		public DateTime EndDatePeriodBooking
		{
			get { return _endDatePeriodBooking; }
			set
			{
				Set(ref _endDatePeriodBooking, value);
				DatePeriod currentDatePeriod = new DatePeriod();
				NumberNightsBooked = currentDatePeriod.GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
				NumberDaysUntilBooking = currentDatePeriod.GetTimeInterval(DateTime.Now, StartDatePeriodBooking.AddDays(1)).Days;
			}
		}

		/// <summary>Количество ночей бронирования</summary>
		private Int32 _numberNightsBooked;
		/// <summary>Количество ночей бронирования</summary>
		public Int32 NumberNightsBooked
		{
			get { return _numberNightsBooked; }
			set => Set(ref _numberNightsBooked, value);
		}

		/// <summary>Количество дней до бронирования</summary>
		private Int32 _numberDaysUntilBooking;
		/// <summary>Количество дней до бронирования</summary>
		public Int32 NumberDaysUntilBooking
		{
			get { return _numberDaysUntilBooking; }
			set => Set(ref _numberDaysUntilBooking, value);
		}

		#endregion ПЕРИОД БРОНИРОВАНИЯ


		#region КАТЕГОРИЯ НОМЕРА

		/// <summary>Весь список категорий номера из базы данных</summary>
		private List<RoomCategory> _roomCategoryFullList = new List<RoomCategory>();
		/// <summary>Весь список категорий номера из базы данных</summary>
		private List<RoomCategory> RoomCategoryFullList
		{
			get { return _roomCategoryFullList; }
			set { _roomCategoryFullList = value; }
		}


		/// <summary>Список категорий номера</summary>
		private ObservableCollection<RoomCategory> _roomCategoryList = new ObservableCollection<RoomCategory>();
		/// <summary>Список категорий номера</summary>
		public ObservableCollection<RoomCategory> RoomCategoryList
		{
			get { return _roomCategoryList; }
			set => Set(ref _roomCategoryList, value);
		}

		/// <summary>Выбранная категория номера</summary>
		private RoomCategory _selectedRoomCategory = null!;
		/// <summary>Выбранная категория номера</summary>
		public RoomCategory SelectedRoomCategory
		{
			get { return _selectedRoomCategory; }
			set => Set(ref _selectedRoomCategory, value);
		}


		/// <summary>Загрузка списка категорий номеров</summary>
		private void LoadRoomCategoryFullList()
		{

			// Загрузка всего списка категорий номеров из базы данных.
			using (ApplicationContext db = new ApplicationContext())
			{
				RoomCategoryFullList = db.RoomCategories.ToList();
			}
		}

		/// <summary>Загрузка списка категорий номеров в зависимости от того какой санаторий был выбран</summary>
		private void LoadRoomCategoryList()
		{
			if (SelectedSanatorium != null)
			{
				var filteredRoomCategory = RoomCategoryFullList.Where(x => x.SanatoriumID == SelectedSanatorium.SanatoriumID).ToList();
				RoomCategoryList = new ObservableCollection<RoomCategory>(filteredRoomCategory);
			}
			else { return; }
		}




		#endregion КАТЕГОРИЯ НОМЕРА


		#region ВИД РАЗМЕЩЕНИЯ

		/// <summary>Весь список видов размещения из базы данных</summary>
		private List<AccommodationType> _accommodationTypeFullList = new List<AccommodationType>();
		/// <summary>Весь список видов размещения из базы данных</summary>
		private List<AccommodationType> AccommodationTypeFullList
		{
			get { return _accommodationTypeFullList; }
			set { _accommodationTypeFullList = value; }
		}

		/// <summary>Список видов размещения</summary>
		private ObservableCollection<AccommodationType> _accommodationTypeList = new ObservableCollection<AccommodationType>();
		/// <summary>Список видов размещения</summary>
		public ObservableCollection<AccommodationType> AccommodationTypeList
		{
			get { return _accommodationTypeList; }
			set => Set(ref _accommodationTypeList, value);
		}

		/// <summary>Выбранный вид размещения</summary>
		private AccommodationType _selectedAccommodationType = null!;
		/// <summary>Выбранный вид размещения</summary>
		public AccommodationType SelectedAccommodationType
		{
			get { return _selectedAccommodationType; }
			set => Set(ref _selectedAccommodationType, value);
		}

		/// <summary>Загрузка списка видов размещения</summary>
		private void LoadAccommodationTypeFullList()
		{

			// Загрузка всего списка видов размещения из базы данных.
			using (ApplicationContext db = new ApplicationContext())
			{
				AccommodationTypeFullList = db.AccommodationTypes.ToList();
			}
		}


		/// <summary>Загрузка списка видов размещения в зависимости от того какой санаторий был выбран</summary>
		private void LoadAccommodationTypeList()
		{
			if (SelectedSanatorium != null)
			{
				var filteredAccommodationType = AccommodationTypeFullList.Where(x => x.SanatoriumID == SelectedSanatorium.SanatoriumID).ToList();
				AccommodationTypeList = new ObservableCollection<AccommodationType>(filteredAccommodationType);
			}
			else { return; }
		}

		#endregion ВИД РАЗМЕЩЕНИЯ


		#region КАТЕГОРИЯ ТАРИФА

		/// <summary>Весь список категорий тарифов из базы данных</summary>
		private List<TarifCategory> _tarifCategoryFullList = new List<TarifCategory>();
		/// <summary>Весь список категорий тарифов из базы данных</summary>
		private List<TarifCategory> TarifCategoryFullList
		{
			get { return _tarifCategoryFullList; }
			set { _tarifCategoryFullList = value; }
		}

		/// <summary>Список категорий тарифов</summary>
		private ObservableCollection<TarifCategory> _tarifCategoryList = new ObservableCollection<TarifCategory>();
		/// <summary>Список категорий тарифов</summary>
		public ObservableCollection<TarifCategory> TarifCategoryList
		{
			get { return _tarifCategoryList; }
			set => Set(ref _tarifCategoryList, value);
		}

		/// <summary>Выбранная  категория тарифа</summary>
		private TarifCategory _selectedTarifCategory = null!;
		/// <summary>Выбранная  категория тарифа</summary>
		public TarifCategory SelectedTarifCategory
		{
			get { return _selectedTarifCategory; }
			set => Set(ref _selectedTarifCategory, value);
		}

		/// <summary>Загрузка списка категорий тарифов</summary>
		private void LoadTarifCategoryFullList()
		{

			// Загрузка всего списка категорий тарифов из базы данных.
			using (ApplicationContext db = new ApplicationContext())
			{
				TarifCategoryFullList = db.TarifCategories.ToList();
			}
		}

		/// <summary>Загрузка списка  категорий тарифов в зависимости от того какой санаторий был выбран</summary>
		private void LoadTarifCategoryList()
		{
			if (SelectedSanatorium != null)
			{
				var filteredTarifCategory = TarifCategoryFullList.Where(x => x.SanatoriumID == SelectedSanatorium.SanatoriumID).ToList();
				TarifCategoryList = new ObservableCollection<TarifCategory>(filteredTarifCategory);
			}
			else { return; }
		}

		#endregion КАТЕГОРИЯ ТАРИФА

		#region ОПЕРАЦИИ БРОНИРОВАНИЯ

		/// <summary>Список операций бронирования</summary>
		private ObservableCollection<BookingOperation> _bookingOperationList = new ObservableCollection<BookingOperation>();
		/// <summary>Список операций бронирования</summary>
		public ObservableCollection<BookingOperation> BookingOperationList
		{
			get { return _bookingOperationList; }
			set => Set(ref _bookingOperationList, value);
		}

		/// <summary>Выбранная операция бронирования</summary>
		private BookingOperation _selectedBookingOperation = null!;
		/// <summary>Выбранная операция бронирования</summary>
		public BookingOperation SelectedBookingOperation
		{
			get { return _selectedBookingOperation; }
			set
			{
				Set(ref _selectedBookingOperation, value);
				GetTemplameMessageCommand.Execute(null!);
			}
		}

		/// <summary>Загрузка списка операций над бронированием вместе с текстовыми шаблонами</summary>
		private void LoadBookingOperationList()
		{
			// Загрузка списка операций над бронированием вместе с текстовыми шаблонами из базы данных
			using (ApplicationContext db = new ApplicationContext())
			{
				var bookingOperations = db.TemplateMessages.Join(db.BookingOperations, // второй набор
					t => t.TemplateMessageID, // свойство-селектор объекта из первого набора
					b => b.TextTemplateID, // свойство-селектор объекта из второго набора
					(t, b) => new BookingOperation// результат
					{
						BookingOperationID = b.BookingOperationID,
						BookingOperationName = b.BookingOperationName,
						TextTemplateID = b.TextTemplateID,
						TemplateMessageBookingOperation = new TemplateMessage(t.TemplateMessageID, t.TemplateMessageText),
						PrefixFileName = b.PrefixFileName
					});
				BookingOperationList.Clear();
				foreach (var bookingOperation in bookingOperations)
				{
					BookingOperationList.Add(bookingOperation);
				}
			}
		}

		#endregion ОПЕРАЦИИ БРОНИРОВАНИЯ

		#region РАСЧЕТ БРОНИРОВАНИЯ

		/// <summary>Расчет бронирования строковое представление</summary>
		private String _calcBookingString = String.Empty;
		/// <summary>Расчет бронирования строковое представление</summary>
		public String CalcBookingString
		{
			get { return _calcBookingString; }
			set
			{
				Set(ref _calcBookingString, value);
				GetTemplameMessageCommand.Execute(null!);
			}
		}


		#endregion РАСЧЕТ БРОНИРОВАНИЯ

		#region ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ БРНИРОВАНИЯ

		/// <summary>Описание бронирования(дополнительная информация для формирования шаблона)</summary>
		private String _descriptionBooking = String.Empty;
		/// <summary>Описание бронирования(дополнительная информация для формирования шаблона)</summary>
		public String DescriptionBooking
		{
			get { return _descriptionBooking; }
			set
			{
				Set(ref _descriptionBooking, value);
				GetTemplameMessageCommand.Execute(null!);
			}
		}


		#endregion ДОПОЛНИТЕЛЬНАЯ ИНФОРМАЦИЯ БРНИРОВАНИЯ

		#region ШАБЛОНЫ

		/// <summary>Список шаблонов текста сообщений</summary>
		private ObservableCollection<TemplateMessage> _templateMessageList = new ObservableCollection<TemplateMessage>();
		/// <summary>Список шаблонов текста сообщений</summary>
		public ObservableCollection<TemplateMessage> TemplateMessageList
		{
			get { return _templateMessageList; }
			set => Set(ref _templateMessageList, value);
		}

		/// <summary>Выбранный шаблон текста сообщений</summary>
		private TemplateMessage _selectedTemplateMessage = null!;
		/// <summary>Выбранный шаблон текста сообщений</summary>
		public TemplateMessage? SelectedTemplateMessage
		{
			get { return _selectedTemplateMessage; }
			set => Set(ref _selectedTemplateMessage!, value);
		}

		/// <summary>Сформированный шаблон</summary>
		private String _resultTemplate = String.Empty;
		/// <summary>Сформированный шаблон</summary>
		public String ResultTemplate
		{
			get { return _resultTemplate; }
			set => Set(ref _resultTemplate!, value);
		}


		/// <summary>Словарь переменных для шаблона</summary>
		private Dictionary<String, String> _templateVariableDictionary = new Dictionary<String, String>();
		/// <summary>Словарь переменных для шаблона</summary>
		public Dictionary<String, String> TemplateVariableDictionary
		{
			get { return _templateVariableDictionary; }
			set => Set(ref _templateVariableDictionary!, value);
		}

		// TODO: подумать как избавиться от констант? Переменные должны быть только динамическими? Плюсы: константы защитят от нежелательных изменений в БД.
		// Константы ключей словаря TemplateVariableDictionary:
		const String EMAIL_SANATORIUM = "EmailSanatorium";
		const String START_DATE_PERIOD_BOOKING = "StartDatePeriodBooking";
		const String SURNAME_WITH_INITIALS = "SurnameWithInitials";
		const String CALC_BOOKING_STRING = "CalcBookingString";
		const String CURRENT_DATE = "CurrentDate";
		const String DESCRIPTION_BOOKING = "DescriptionBooking";

		/// <summary>Загрузка переменных шаблона текста сообщений в словарь</summary> 
		private void LoadTemplateVariableDictionary()
		{

			using (ApplicationContext db = new ApplicationContext())
			{
				// Загрузка переменных текстового шаблона из базы данных
				var textTemplateVariables = db.TextTemplateVariables.ToList();

				foreach (TextTemplateVariable t in textTemplateVariables)
				{
					TemplateVariableDictionary.Clear();
					TemplateVariableDictionary.Add(t.KeyTextTemlateVariable, t.ValueTextTemplateVariable);
				}
			}
		}

		#endregion ШАБЛОНЫ

		#region ФОРМИРОВАНИЕ ИМЕНИ ФАЙЛА

		/// <summary>Имя файла документа</summary>
		private String _fileName = String.Empty;
		/// <summary>Имя файла документа</summary>
		public String FileName
		{
			get { return _fileName; }
			set => Set(ref _fileName!, value);
		}


		#endregion ФОРМИРОВАНИЕ ИМЕНИ ФАЙЛА

		#endregion КОНЕЦ КОНТЕНТ

		#region МЕТОДЫ

		/// <summary>Загрузка списков из базы данных</summary>
		private void LoadingListsFromDatabase()
		{
			CleanFields(); // Очищаем поля
			LoadManagerList();  // Загрузка списка менеджеров.
			LoadSanatoriumList(); // Загрузка списка санаториев
			LoadRoomCategoryFullList(); // Загрузка всех категорий номеров
			LoadAccommodationTypeFullList(); // Загрузка всех видов размещения
			LoadTarifCategoryFullList(); // Загрузка всех категорий тарифов
			LoadBookingOperationList(); // Загрузка списка операций над бронированием вместе с текстовыми шаблонами
			LoadTemplateVariableDictionary(); // Загрузка переменных шаблона текста сообщений в словарь
		}

		/// <summary>Очистить поля</summary>
		private void CleanFields()
		{
			ResultTemplate = String.Empty;
			FileName = String.Empty;
			ManagerList.Clear();
			SanatoriumList.Clear();
			RoomCategoryList.Clear();
			AccommodationTypeList.Clear();
			TarifCategoryList.Clear();
		}

		// TODO : возможно метод не понадобится.
		//private void LoadTemplameMessage()
		//{
		//	using (ApplicationContext db = new ApplicationContext())
		//	{

		//	}
		//}

		#endregion МЕТОДЫ

		#region КОМАНДЫ


		// Загрузка списка санаториев из базы данных
		private RelayCommand? _loadingSanatoriumListFromDatabaseCommand;
		public RelayCommand LoadingSanatoriumListFromDatabaseCommand
		{
			get
			{
				return _loadingSanatoriumListFromDatabaseCommand ??
				  (_loadingSanatoriumListFromDatabaseCommand = new RelayCommand(obj =>
				  {
					  SanatoriumList.Clear();
					  RoomCategoryList.Clear();
					  AccommodationTypeList.Clear();
					  TarifCategoryList.Clear();
					  LoadSanatoriumList();
				  }));
			}
		}


		// Загрузка списка менеджеров из базы данных
		private RelayCommand? _loadingManagerListFromDatabaseCommand;
		public RelayCommand LoadingManagerListFromDatabaseCommand
		{
			get
			{
				return _loadingManagerListFromDatabaseCommand ??
				  (_loadingManagerListFromDatabaseCommand = new RelayCommand(obj =>
				  {
					  ManagerList.Clear();
					  LoadManagerList();
				  }));
			}
		}

		// Загрузка списка категорий номеров из базы данных
		private RelayCommand? _loadingRoomCategoryListFromDatabaseCommand;
		public RelayCommand LoadingRoomCategoryListFromDatabaseCommand
		{
			get
			{
				return _loadingRoomCategoryListFromDatabaseCommand ??
				  (_loadingRoomCategoryListFromDatabaseCommand = new RelayCommand(obj =>
				  {
					  LoadRoomCategoryFullList();
					  LoadRoomCategoryList();
				  }));
			}
		}

		// Загрузка списка видах размещения из базы данных
		private RelayCommand? _loadingAccommodationTypeListFromDatabaseCommand;
		public RelayCommand LoadingAccommodationTypeListFromDatabaseCommand
		{
			get
			{
				return _loadingAccommodationTypeListFromDatabaseCommand ??
				  (_loadingAccommodationTypeListFromDatabaseCommand = new RelayCommand(obj =>
				  {
					  LoadAccommodationTypeFullList();
					  LoadAccommodationTypeList();
				  }));
			}
		}

		// Загрузка списка категория тарифа из базы данных
		private RelayCommand? _loadingTarifCategoryListFromDatabaseCommand;
		public RelayCommand LoadingTarifCategoryListFromDatabaseCommand
		{
			get
			{
				return _loadingTarifCategoryListFromDatabaseCommand ??
				  (_loadingTarifCategoryListFromDatabaseCommand = new RelayCommand(obj =>
				  {
					  LoadTarifCategoryFullList();
					  LoadTarifCategoryList();
				  }));
			}
		}

		// Загрузка списка операций бронирования из базы данных
		private RelayCommand? _loadingBookingOperationListFromDatabaseCommand;
		public RelayCommand LoadingBookingOperationListFromDatabaseCommand
		{
			get
			{
				return _loadingBookingOperationListFromDatabaseCommand ??
				  (_loadingBookingOperationListFromDatabaseCommand = new RelayCommand(obj =>
				  {
					  LoadBookingOperationList();
				  }));
			}
		}

		// Загрузка списков из базы данных
		private RelayCommand? _loadingListsFromDatabaseCommand;
		public RelayCommand LoadingListsFromDatabaseCommand
		{
			get
			{
				return _loadingListsFromDatabaseCommand ??
				  (_loadingListsFromDatabaseCommand = new RelayCommand(obj =>
				  {
					  LoadingListsFromDatabase();
				  }));
			}
		}

		// Получить шаблон текстового сообщения
		private RelayCommand? getTemplameMessageCommand;
		public RelayCommand GetTemplameMessageCommand
		{
			get
			{
				return getTemplameMessageCommand ??
				  (getTemplameMessageCommand = new RelayCommand(obj =>
				  {

					  if (SelectedBookingOperation != null)
					  {

						  // Получаем текстовый шаблон, который содержит(или не содержит) текстовые переменные для динамической подстановки данных
						  String resultMessage = SelectedBookingOperation.TemplateMessageBookingOperation.TemplateMessageText;
						  // TODO: ОШИБКА при вызове метода  LoadingListsFromDatabase(); Если проверить SelectedSanatorium на null и выкитуть из метода(команды) то программа продолжает работать
						  // Динамическая подстановка значений в текстовые переменные
						  if (SelectedSanatorium != null)
						  {
							  TemplateVariableDictionary[EMAIL_SANATORIUM] = SelectedSanatorium.EmailSanatorium;
							  TemplateVariableDictionary[START_DATE_PERIOD_BOOKING] = StartDatePeriodBooking.ToShortDateString();
							  TemplateVariableDictionary[SURNAME_WITH_INITIALS] = MainGuestPerson.GetSurnameWithInitials(FullNameMainGuest);
							  TemplateVariableDictionary[CALC_BOOKING_STRING] = CalcBookingString;
							  TemplateVariableDictionary[CURRENT_DATE] = DateTime.Now.ToShortDateString();
							  TemplateVariableDictionary[DESCRIPTION_BOOKING] = DescriptionBooking;
						  }
						  else
						  {
							  //MessageBox.Show("Необходимо выбрать санаторий");
							  return;
						  }

						  // Подстановка значений из текстовых переменных в текстовый шаблон 
						  foreach (var item in TemplateVariableDictionary)
						  {
							  resultMessage = resultMessage.Replace($"{{{item.Key}}}", item.Value.ToString());
						  }

						  ResultTemplate = resultMessage;
						  // Формируем название файла
						  CreateFileNameCommand.Execute("");
					  }
				  }));
			}
		}

		// Скопировать шаблон текстового сообщения
		private RelayCommand? copyTemplameMessageCommand;
		public RelayCommand CopyTemplameMessageCommand
		{
			get
			{
				return copyTemplameMessageCommand ??
				  (copyTemplameMessageCommand = new RelayCommand(obj =>
				  {
					  // 1. Скопировать в буфер сформированный шаблон.
					  if (SelectedBookingOperation != null)
					  {
						  Clipboard.SetText(ResultTemplate);
					  }
					  else
					  {
						  //MessageBox.Show("Необходимо выбрать операцию пронирования");
						  return;
					  }
				  }));
			}
		}

		// Сформировать имя файла
		private RelayCommand? createFileNameCommand;
		public RelayCommand CreateFileNameCommand
		{
			get
			{
				return createFileNameCommand ??
				  (createFileNameCommand = new RelayCommand(obj =>
				  {
					  // TODO : ошибка null при вызове команды, если не выбрана операция
					  if (SelectedBookingOperation != null)
					  {
						  String foundPrefix = String.Empty;
						  if (String.IsNullOrWhiteSpace(SelectedBookingOperation.PrefixFileName))
						  {
							  foundPrefix = "";
							  FileName = foundPrefix;
						  }
						  else
						  {
							  foundPrefix = SelectedBookingOperation.PrefixFileName;
							  if (SelectedSanatorium != null)
							  {
								  FileName = foundPrefix + " в санаторий " + SelectedSanatorium.SanatoriumName + " " + MainGuestPerson.GetSurnameWithInitials(FullNameMainGuest);
							  }
							  else
							  {
								  FileName = foundPrefix + MainGuestPerson.GetSurnameWithInitials(FullNameMainGuest);
							  }
						  }
					  }
					  else
					  {
						  // MessageBox.Show("Необходимо выбрать операцию бронирования!");
						  return;
					  }

				  }));
			}
		}

		// Скопировать имя файлв
		private RelayCommand? copyFileNameCommand;
		public RelayCommand CopyFileNameCommand
		{
			get
			{
				return copyFileNameCommand ??
				  (copyFileNameCommand = new RelayCommand(obj =>
				  {
					  // 1. Скопировать в буфер сформированный шаблон.
					  if (FileName != null)
					  {
						  Clipboard.SetText(FileName);
					  }
					  else
					  {
						  // TODO: Необхожимо грамотно обработать исключение!
						  MessageBox.Show("Объект FileName, в классе TabBookingItemViewModel, равег значению null!");
					  }
				  }));
			}
		}

		#endregion КОМАНДЫ

	}
}
