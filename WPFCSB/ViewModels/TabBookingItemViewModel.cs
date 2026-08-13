
using System.Collections.ObjectModel;
using System.Windows;
using WPFCSB.Commands;
using WPFCSB.Models;
using WPFCSB.Resources;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
    public class TabBookingItemViewModel : ViewModelBase
    {
        public TabBookingItemViewModel()
        {
            LoadManagerList();
            LoadSanatoriumList();
			LoadTemplateMessageList();
			LoadBookingOperationList();            
            LoadTemplateVariableDictionary();
		}

        #region ЗАГОЛОВОК
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

        /// <summary>Список менеджеров</summary>
        private ObservableCollection<Person> _guestList = new ObservableCollection<Person>();
        /// <summary>Список менеджеров</summary>
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

        //  TODO: разработать загрузку(сортировку) саиска из класса
        private void LoadManagerList()
        {
            ManagerList.Add(new Manager(1, new Person(11, "Боровкова", "Кристина", "Викторовна",new DateTime(1977,01,01), Gender.Female)));

            ManagerList.Add(new Manager(2, new Person(12, "Девочкина", "Юлия", "Владимировна", new DateTime(1975,01,10), Gender.Female)));

            ManagerList.Add(new Manager(3, new Person(13, "Корниенко", "Надежда", "Евгеньевна", new DateTime(1976,12,06), Gender.Female)));
            //ManagerList.Add(new Manager(4, new Person()
            //{
            //    PersonID = 14,
            //    Surname = "Кривошеина",
            //    Name = "Ольга",
            //    Patronymic = "Владимировна"
            //}));
            //ManagerList.Add(new Manager(5, new Person()
            //{
            //    PersonID = 15,
            //    Surname = "Кузнецова",
            //    Name = "Ирина",
            //    Patronymic = "Геннадьевна"
            //}));
            //ManagerList.Add(new Manager(6, new Person()
            //{
            //    PersonID = 16,
            //    Surname = "Огнева",
            //    Name = "Алёна",
            //    Patronymic = "Ивановна"
            //}));
            //ManagerList.Add(new Manager(7, new Person()
            //{
            //    PersonID = 17,
            //    Surname = "Юкнявичус",
            //    Name = "Виолетта",
            //    Patronymic = "Викторовна"
            //}));
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

        /// <summary>Загрузка списка санаториев</summary> // TODO: Разработать загрузку
        private void LoadSanatoriumList()
        {
            SanatoriumList.Add(new Sanatorium(1, "Планета", "olgaakopyan@mail.ru"));
            SanatoriumList.Add(new Sanatorium(2, "Киев", "alushtasankiev-rus@mail.ru"));
            SanatoriumList.Add(new Sanatorium(3, "Озеро Сновидений", "admin@o-snov.com"));
            SanatoriumList.Add(new Sanatorium(4, "Рябинка", "ribinka.buh@inbox.ru"));
            SanatoriumList.Add(new Sanatorium(5, "Сакрополь", "sakropol@yandex.ru"));
            SanatoriumList.Add(new Sanatorium(6, "Узбекистан", "marketing@yalta-uzbekistan.ru"));
            SanatoriumList.Add(new Sanatorium(7, "ТЭС", "teshotel@rambler.ru"));
            SanatoriumList.Add(new Sanatorium(8, "Новый санаторий", ""));
        }

        #endregion САНАТОРИИ

        #region ПЕРИОД БРОНИРОВАНИЯ


        /// <summary>   Дата начала периода бронирования. </summary>
        private DateTime _startDatePeriodBooking = DateTime.Today;
        /// <summary>   Дата начала периода  бронирования. </summary>
        public DateTime StartDatePeriodBooking
        {
            get { return _startDatePeriodBooking; }
            set
            {
                Set(ref _startDatePeriodBooking, value);
                NumberNightsBooked = GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
                NumberDaysUntilBooking = GetTimeInterval(DateTime.Now, StartDatePeriodBooking.AddDays(1)).Days;
				GetTemplameMessageCommand.Execute(null!);

			}
        }

        /// <summary>   Дата окончания периода  бронирования. </summary>
        private DateTime _endDatePeriodBooking = DateTime.Now.AddDays(10);
        /// <summary>   Дата окончания периода  бронирования. </summary>
        public DateTime EndDatePeriodBooking
        {
            get { return _endDatePeriodBooking; }
            set
            {
                Set(ref _endDatePeriodBooking, value);
                NumberNightsBooked = GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
                NumberDaysUntilBooking = GetTimeInterval(DateTime.Now, StartDatePeriodBooking.AddDays(1)).Days;

            }
        }

        /// <summary>   Количество ночей бронирования. </summary>
        private Int32 _numberNightsBooked;
        /// <summary>   Количество ночей бронирования. </summary>
        public Int32 NumberNightsBooked
        {
            get { return _numberNightsBooked; }
            set
            {
                Set(ref _numberNightsBooked, value);
            }
        }

        /// <summary>   Количество дней до бронирования. </summary>
        private Int32 _numberDaysUntilBooking;
        /// <summary>   Количество дней до бронирования. </summary>
        public Int32 NumberDaysUntilBooking
        {
            get { return _numberDaysUntilBooking; }
            set
            {
                Set(ref _numberDaysUntilBooking, value);
            }
        }


        #endregion ПЕРИОД БРОНИРОВАНИЯ

        #region ОПЕРАЦИИ БРОНИРОВАНИЯ

        /// <summary>Список операций бронирования</summary>
        private ObservableCollection<BookingOperation>_bookingOperationList = new ObservableCollection<BookingOperation>();
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

        /// <summary>Загрузка списка операций над бронированием</summary> // TODO: Разработать загрузку
        private void LoadBookingOperationList()
        {
            BookingOperationList.Add(new BookingOperation(1, new TemplateMessage(1, "{EmailSanatorium}\r\nЗаявка на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста заявку.\r\nРасчет брони:{CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."), "Заявка Отправить", "Заявка "));
            BookingOperationList.Add(new BookingOperation(2, new TemplateMessage(2, "Заявка напр.{CurrendDate} на сумму {CalcBookingString}"), "Заявка отправлена"));
            BookingOperationList.Add(new BookingOperation(3, new TemplateMessage(3, "{EmailSanatorium}\r\nКоррекция заявки на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста коррекцию заявки.\r\n{DescriptionBooking}\r\nРасчет брони: {CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."), "Коррекция Заявки Отправить", "Коррекция заявки "));
            BookingOperationList.Add(new BookingOperation(4, new TemplateMessage(4, "{CurrendDate} {DescriptionBooking}\r\nКоррекция Заявки напр. {CurrendDate} на сумму {CalcBookingString}"), "Коррекция Заявки отправлена"));
            BookingOperationList.Add(new BookingOperation(5, new TemplateMessage(5, "Шаблон Путевка Отправить"), "Путевка Отправить", "Путевка "));
            BookingOperationList.Add(new BookingOperation(6, new TemplateMessage(6, "Шаблон Путевка Коррекция Отправить"), "Путевка Коррекция Отправить"));
            BookingOperationList.Add(new BookingOperation(7, new TemplateMessage(7, "Шаблон Путевка отправлена"), "Путевка отправлена"));
            BookingOperationList.Add(new BookingOperation(8, new TemplateMessage(8, "Шаблон Путевка коррекция отправлена"), "Путевка коррекция отправлена"));
            BookingOperationList.Add(new BookingOperation(9, new TemplateMessage(9, "Шаблон Подтверждение оплаты отправить"), "Подтверждение оплаты отправить", "Подтверждение оплаты "));
            BookingOperationList.Add(new BookingOperation(10, new TemplateMessage(10, "Шаблон Подтверждение коррекция отправить"), "Подтверждение коррекция отправить"));
            BookingOperationList.Add(new BookingOperation(11, new TemplateMessage(11, "Шаблон Аннуляция Отправить"), "Аннуляция Отправить", "Аннуляция "));
            BookingOperationList.Add(new BookingOperation(12, new TemplateMessage(12, "Шаблон Аннуляция отправлена "), "Аннуляция отправлена "));
            BookingOperationList.Add(new BookingOperation(13, new TemplateMessage(13, "Шаблон Бронь оплаченная"), "Бронь оплаченная"));
            BookingOperationList.Add(new BookingOperation(14, new TemplateMessage(14, "Шаблон Бронь которую аннулируем"), "Бронь которую аннулируем"));
            BookingOperationList.Add(new BookingOperation(15, new TemplateMessage(15, "Шаблон Счет Отправить"), "Счет Отправить", "Счет "));
            BookingOperationList.Add(new BookingOperation(16, new TemplateMessage(16, "Шаблон Счет на доплату Отправить"), "Счет на доплату Отправить", "Счет на доплату "));
            BookingOperationList.Add(new BookingOperation(17, new TemplateMessage(17, "Шаблон Счет Коррекция Отправить"), "Счет Коррекция Отправить", "Счет коррекция "));
            BookingOperationList.Add(new BookingOperation(18, new TemplateMessage(18, "Шаблон Ссылка на БО"), "Ссылка на БО"));
            BookingOperationList.Add(new BookingOperation(19, new TemplateMessage(19, "Шаблон Рассрочка Т-банк"), "Рассрочка Т-банк"));
            BookingOperationList.Add(new BookingOperation(20, new TemplateMessage(20, "Шаблон Информация об оплате"), "Информация об оплате"));
            BookingOperationList.Add(new BookingOperation(21, new TemplateMessage(21, "Шаблон Информация об оплате отправлена"), "Информация об оплате отправлена"));
            BookingOperationList.Add(new BookingOperation(22, new TemplateMessage(22, "Шаблон Отмена письма"), "Отмена письма"));
            BookingOperationList.Add(new BookingOperation(23, new TemplateMessage(23, "Шаблон РЖМ Заявка Отправить"), "РЖМ Заявка Отправить", "РМЖ заявка "));
            BookingOperationList.Add(new BookingOperation(24, new TemplateMessage(24, "Шаблон РЖМ Заявка отправлена"), "РЖМ Заявка отправлена"));
            BookingOperationList.Add(new BookingOperation(25, new TemplateMessage(25, "Шаблон РЖМ Коррекция Заявки Отправить"), "РЖМ Коррекция Заявки Отправить", "РМЖ Коррекция заявки "));
            BookingOperationList.Add(new BookingOperation(26, new TemplateMessage(26, "Шаблон РЖМ Коррекция Заявки отправлена"), "РЖМ Коррекция Заявки отправлена"));
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

		// TODO: Разработать загрузку
		/// <summary>Загрузка переменных шаблона текста сообщений в словарь</summary> 
		private void LoadTemplateVariableDictionary()
        {
            TemplateVariableDictionary.Add("EmailSanatorium", "Значение ключа EmailSanatorium отсутствует");
            TemplateVariableDictionary.Add("StartDatePeriodBooking", "Значение ключа StartDatePeriodBooking отсутствует");
            TemplateVariableDictionary.Add("SurnameWithInitials", "Значение ключа SurnameWithInitials отсутствует");
            TemplateVariableDictionary.Add("CalcBookingString", "Значение ключа CalcBookingString отсутствует");
			TemplateVariableDictionary.Add("CurrendDate", "Значение ключа CurrendDate отсутствует");
			TemplateVariableDictionary.Add("DescriptionBooking", "Значение ключа DescriptionBooking отсутствует");
		}

		// TODO: Разработать загрузку
		/// <summary>Загрузка списка шаблонов текста сообщений</summary> 
		private void LoadTemplateMessageList()
        {
            TemplateMessageList.Add(new TemplateMessage(1, "{EmailSanatorium}\r\nЗаявка на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста заявку.\r\nРасчет брони:{CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."));
            TemplateMessageList.Add(new TemplateMessage(2, "Заявка напр.{CurrendDate} на сумму {CalcBookingString}"));
            TemplateMessageList.Add(new TemplateMessage(3, "{EmailSanatorium}\r\nКоррекция заявки на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста коррекцию заявки.\r\n{DescriptionBooking}\r\nРасчет брони: {CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."));
            TemplateMessageList.Add(new TemplateMessage(4, "{CurrendDate} {DescriptionBooking}\r\nКоррекция Заявки напр. {CurrendDate} на сумму {CalcBookingString}"));
            TemplateMessageList.Add(new TemplateMessage(5, "Шаблон Путевка Отправить"));
            TemplateMessageList.Add(new TemplateMessage(6, "Шаблон Путевка Коррекция Отправить"));
            TemplateMessageList.Add(new TemplateMessage(7, "Шаблон Путевка отправлена"));
            TemplateMessageList.Add(new TemplateMessage(8, "Шаблон Путевка коррекция отправлена"));
            TemplateMessageList.Add(new TemplateMessage(9, "Шаблон Подтверждение оплаты отправить"));
            TemplateMessageList.Add(new TemplateMessage(10, "Шаблон Подтверждение коррекция отправить"));
            TemplateMessageList.Add(new TemplateMessage(11, "Шаблон Аннуляция Отправить"));
            TemplateMessageList.Add(new TemplateMessage(12, "Шаблон Аннуляция отправлена "));
            TemplateMessageList.Add(new TemplateMessage(13, "Шаблон Бронь оплаченная"));
            TemplateMessageList.Add(new TemplateMessage(14, "Шаблон Бронь которую аннулируем"));
            TemplateMessageList.Add(new TemplateMessage(15, "Шаблон Счет Отправить"));
            TemplateMessageList.Add(new TemplateMessage(16, "Шаблон Счет на доплату Отправить"));
            TemplateMessageList.Add(new TemplateMessage(17, "Шаблон Счет Коррекция Отправить"));
            TemplateMessageList.Add(new TemplateMessage(18, "Шаблон Ссылка на БО"));
            TemplateMessageList.Add(new TemplateMessage(19, "Шаблон Рассрочка Т-банк"));
            TemplateMessageList.Add(new TemplateMessage(20, "Шаблон Информация об оплате"));
            TemplateMessageList.Add(new TemplateMessage(21, "Шаблон Информация об оплате отправлена"));
            TemplateMessageList.Add(new TemplateMessage(22, "Шаблон Отмена письма"));
            TemplateMessageList.Add(new TemplateMessage(23, "Шаблон РЖМ Заявка Отправить"));
            TemplateMessageList.Add(new TemplateMessage(24, "Шаблон РЖМ Заявка отправлена"));
            TemplateMessageList.Add(new TemplateMessage(25, "Шаблон РЖМ Коррекция Заявки Отправить"));
            TemplateMessageList.Add(new TemplateMessage(26, "Шаблон РЖМ Коррекция Заявки отправлена"));
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
        // TODO: ВЫнести этот метод в класс BookingPeriod
        /// <summary>Получить интервал времени</summary>
        /// <param name="startDatePeriodBooking">Дата начала периода бронирования</param>
        /// <param name="endDatePeriodBooking">Дата окончания периода  бронирования</param>
        /// <returns>Интервал времени</returns>
        public TimeSpan GetTimeInterval(DateTime startDatePeriodBooking, DateTime endDatePeriodBooking)
        {
            TimeSpan timeInterval = default;

            timeInterval = endDatePeriodBooking - startDatePeriodBooking;

            return timeInterval;

        }

        /// <summary>Получить из полного ФИО - сокращенное</summary>
        /// <param name="fullName">Полное ФИО</param>
        /// <returns></returns>
        public String GetSurnameWithInitials(String fullName)
        {
            if (String.IsNullOrWhiteSpace(fullName))
                return String.Empty;

            var parts = fullName
                .Trim()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0)
                return String.Empty;

            String surname = parts[0].Trim();

            if (parts.Length == 1)
                return surname;

            Char firstInitial = Char.ToUpper(parts[1][0]);

            if (parts.Length == 2)
                return $"{surname} {firstInitial}.";

            Char secondInitial = Char.ToUpper(parts[2][0]);
            return $"{surname} {firstInitial}.{secondInitial}.";
        }

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
						  String resultMessage = SelectedBookingOperation.CurrentTemplateMessage.TemplateMessageText;
                          // TODO: вынести словарь в класс BookingOperation
                          TemplateVariableDictionary["EmailSanatorium"] = SelectedSanatorium.EmailSanatorium;
                          TemplateVariableDictionary["StartDatePeriodBooking"] = StartDatePeriodBooking.ToShortDateString();
                          TemplateVariableDictionary["SurnameWithInitials"] = GetSurnameWithInitials(FullNameMainGuest);
                          TemplateVariableDictionary["CalcBookingString"] = CalcBookingString;
                          TemplateVariableDictionary["CurrendDate"] = DateTime.Now.ToShortDateString();
                          TemplateVariableDictionary["DescriptionBooking"] = DescriptionBooking;

                          foreach (var item in TemplateVariableDictionary)
                          {
                              resultMessage = resultMessage.Replace($"{{{item.Key}}}", item.Value.ToString());
                          }

                          ResultTemplate = resultMessage;
						  CreateFileNameCommand.Execute("");
					  }


					  // Старый код:
					  //               Int32 textTemplateID = 0;

					  //// 1. Определить какой шаблон выбран из списка шаблонов.
					  //// 1.1. Получаем ижентификатор шаблона из выбранной операции бронирования		
					  //if (SelectedBookingOperation != null)	
					  //               {
					  //  textTemplateID = SelectedBookingOperation.TextTemplateID;
					  //}


					  //               // TODO: Обработать условие, если не выбрана операция бронирования из скиска(например выделить и переместить курсор в нужную область)
					  //               // 1.2. Находим, по полученному идентификатору, текстовый шаблон
					  //               if (textTemplateID <= 0)
					  //               {
					  //                   //MessageBox.Show("Необходимо выбрать операцию!");
					  //               }
					  //               else
					  //               {
					  //                   if (TemplateMessageList != null)
					  //                   {
					  //                       SelectedTemplateMessage = TemplateMessageList.FirstOrDefault(textTemplate => textTemplate.TemplateMessageID == textTemplateID);
					  //                       CreateFileNameCommand.Execute("");

					  //  String templateMessage = SelectedTemplateMessage!.TemplateMessageText;
					  //  String resultMessage = templateMessage;

					  //  TemplateVariableDictionary["EmailSanatorium"] = SelectedSanatorium.EmailSanatorium;
					  //  TemplateVariableDictionary["StartDatePeriodBooking"] = StartDatePeriodBooking.ToShortDateString();
					  //  TemplateVariableDictionary["SurnameWithInitials"] = GetSurnameWithInitials(FullNameMainGuest);
					  //  TemplateVariableDictionary["CalcBookingString"] = CalcBookingString;
					  //  TemplateVariableDictionary["CurrendDate"] = DateTime.Now.ToShortDateString();
					  //  TemplateVariableDictionary["DescriptionBooking"] = DescriptionBooking;


					  //  foreach (var item in TemplateVariableDictionary)
					  //  {
					  //	  resultMessage = resultMessage.Replace($"{{{item.Key}}}", item.Value.ToString());
					  //  }

					  //  ResultTemplate = resultMessage;
					  // }
					  //                   else
					  //                   {
					  //                       // TODO: обработать исключение!
					  //                       MessageBox.Show("Отсутствует список шаблонов сообщения! Класс TabBookingItemViewModel");
					  //                   }
					  //}
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
                      foundPrefix = SelectedBookingOperation.PrefixFileName;
                      if (String.IsNullOrWhiteSpace(foundPrefix))
                      {
                          FileName = foundPrefix;
                      }
                      else 
                      {
                        
							  FileName = foundPrefix + " в санаторий " + SelectedSanatorium.SanatoriumName + " " + GetSurnameWithInitials(FullNameMainGuest);                          
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
