using System.Collections.ObjectModel;
using System.Windows;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
	/// <summary>Модель представления вкладки с информацией о бронировании</summary>
	public class TabBookingItemViewModel : ViewModelBase
	{
		public TabBookingItemViewModel()
		{
			LoadManagerList();  // Загрузка списка менеджеров.
			LoadSanatoriumList(); // Загрузка списка санаториев
			LoadBookingOperationList(); // Загрузка списка операций над бронированием вместе с текстовыми шаблонами
			LoadTemplateVariableDictionary(); // Загрузка переменных шаблона текста сообщений в словарь
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

		#region ГОСТИ

		/// <summary>Список гостей</summary>
		private ObservableCollection<Person> _guestList = new ObservableCollection<Person>();
		/// <summary>Список гостей</summary>
		public ObservableCollection<Person> GuestList
		{
			get { return _guestList; }
			set => Set(ref _guestList, value);
		}

		/// <summary>Выбранный гость</summary>
		private Person _selectedGuest = null!;
		/// <summary>Выбранный гость</summary>
		public Person SelectedGuest
		{
			get { return _selectedGuest; }
			set => Set(ref _selectedGuest, value);
		}

		/// <summary>Основной гость</summary>
		private Person _mainGuest = new Person();
		/// <summary>Основной гость</summary>
		public Person MainGuest
		{
			get { return _mainGuest; }
			set { _mainGuest = value; }
		}

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
		private Sanatorium _selectedSanatorium = new Sanatorium();
		/// <summary>Выбранный санаторий</summary>
		public Sanatorium SelectedSanatorium
		{
			get { return _selectedSanatorium; }
			set
			{
				Set(ref _selectedSanatorium, value);
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

		#endregion КОНТЕНТ

		#region МЕТОДЫ



		#endregion МЕТОДЫ

		#region КОМАНДЫ

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

						  // Динамическая подстановка значений в текстовые переменные
						  TemplateVariableDictionary[EMAIL_SANATORIUM] = SelectedSanatorium.EmailSanatorium;
						  TemplateVariableDictionary[START_DATE_PERIOD_BOOKING] = StartDatePeriodBooking.ToShortDateString();
						  TemplateVariableDictionary[SURNAME_WITH_INITIALS] = MainGuest.GetSurnameWithInitials(FullNameMainGuest);
						  TemplateVariableDictionary[CALC_BOOKING_STRING] = CalcBookingString;
						  TemplateVariableDictionary[CURRENT_DATE] = DateTime.Now.ToShortDateString();
						  TemplateVariableDictionary[DESCRIPTION_BOOKING] = DescriptionBooking;

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
						  // TODO: Необхожимо грамотно обработать исключение!
						  MessageBox.Show("Объект SelectedBookingOperation, в классе TabBookingItemViewModel, равег значению null!");
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
					  String foundPrefix = String.Empty;
					  if (String.IsNullOrWhiteSpace(SelectedBookingOperation.PrefixFileName))
					  {
						  foundPrefix = "";
						  FileName = foundPrefix;
					  }
					  else
					  {
						  foundPrefix = SelectedBookingOperation.PrefixFileName;
						  FileName = foundPrefix + " в санаторий " + SelectedSanatorium.SanatoriumName + " " + MainGuest.GetSurnameWithInitials(FullNameMainGuest);
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
