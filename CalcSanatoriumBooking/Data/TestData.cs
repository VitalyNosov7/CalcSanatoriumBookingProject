

using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Data
{
	/// <summary>Тестовые данные </summary>
	public class TestData
	{
		public TestData(DateTime startBooking, DateTime endBooking)
		{
			StartBooking = startBooking;
			EndBooking = endBooking;
			LoadPriceBookingList();			
			LoadSanatoriumList();
			LoadRoomCategoryList();
			LoalSanatoriumTariffList();
			LoadPersonList();
			LoadGuestsList();
		}

		#region Параметры бронирования

		/// <summary>Начало бронирования</summary>
		private DateTime _startBooking;

		/// <summary>Начало бронирования</summary>
		public DateTime StartBooking
		{
			get { return _startBooking; }
			set { _startBooking = value; }
		}

		/// <summary>Конец бронирования</summary>
		private DateTime _endBooking;

		/// <summary>Конец бронирования</summary>
		public DateTime EndBooking
		{
			get { return _endBooking; }
			set { _endBooking = value; }
		}

		#endregion Параметры бронирования

		#region Санатории

		/// <summary>Список санаториев </summary>
		private List<Sanatorium>? _sanatoriumList;

		/// <summary>Список санаториев </summary>
		public List<Sanatorium> SanatoriumList
		{
			get { return _sanatoriumList!; }
			set { _sanatoriumList = value; }
		}


		public void LoadSanatoriumList()
		{
			Sanatorium sanatoriumSacropol = new Sanatorium(1, "Сакрополь");
			Sanatorium sanatoriumPlaneta = new Sanatorium(2, "Планета");
			Sanatorium sanatoriumKiev = new Sanatorium(3, "Киев");

			SanatoriumList.Add(sanatoriumSacropol);
			SanatoriumList.Add(sanatoriumPlaneta);
			SanatoriumList.Add(sanatoriumKiev);
		}

		#endregion Санатории

		#region Категория номера

		/// <summary>Список Категорий номеров </summary>
		private List<RoomCategory>? _roomCategoryList;

		/// <summary>Список Категорий номеров </summary>
		public List<RoomCategory> RoomCategoryList
		{
			get { return _roomCategoryList!; }
			set { _roomCategoryList = value; }
		}

		public void LoadRoomCategoryList()
		{
			RoomCategory roomCategory_1 = new RoomCategory(1, 1, "Двухместный «комфорт»");
			RoomCategory roomCategory_2 = new RoomCategory(2, 1, "Одноместный «Престиж»");
			RoomCategory roomCategory_3 = new RoomCategory(3, 1, "Двухместный «Престиж»");
			RoomCategory roomCategory_4 = new RoomCategory(4, 1, "Одноместный «Престиж+»");
			RoomCategory roomCategory_5 = new RoomCategory(5, 1, "Двухместный «Престиж+»");
			RoomCategory roomCategory_6 = new RoomCategory(6, 1, "Двухместный 2-х комнатный «Люкс»");
			RoomCategory roomCategory_7 = new RoomCategory(7, 1, "Двухместный 3-х комнатный «Люкс-VIP»");

			RoomCategoryList.Add(roomCategory_1);
			RoomCategoryList.Add(roomCategory_2);
			RoomCategoryList.Add(roomCategory_3);
			RoomCategoryList.Add(roomCategory_4);
			RoomCategoryList.Add(roomCategory_5);
			RoomCategoryList.Add(roomCategory_6);
			RoomCategoryList.Add(roomCategory_7);
		}


		#endregion Категория номера

		#region Вид размещения

		/// <summary>Список видов размещения </summary>
		private List<AccommodationType>? _accommodationTypeList;

		/// <summary>Список видов размещения </summary>
		public List<AccommodationType> AccommodationTypeList
		{
			get { return _accommodationTypeList!; }
			set { _accommodationTypeList = value; }
		}

		public void LoadAccommodationTypeList()
		{
			AccommodationType accommodation_1 = new AccommodationType(1, 1, "Подселение");
			AccommodationType accommodation_2 = new AccommodationType(2, 1, "Одноместное");
			AccommodationType accommodation_3 = new AccommodationType(3, 1, "Двухместное");
			AccommodationType accommodation_4 = new AccommodationType(4, 1, "Доп. место (взр.)");
		}


		#endregion Вид размещения

		#region Тариф санатория

		/// <summary>Тариф санатория(с лечением, без лечения, климатолечение, оздоровление)</summary>
		private List<SanatoriumTariff>? _sanatoriumTariffList;

		/// <summary>Тариф санатория(с лечением, без лечения, климатолечение, оздоровление)</summary>
		public List<SanatoriumTariff> SanatoriumTariffList
		{
			get { return _sanatoriumTariffList!; }
			set { _sanatoriumTariffList = value; }
		}

		public void LoalSanatoriumTariffList()
		{
			SanatoriumTariff sanatoriumTariff_1 = new SanatoriumTariff(1, 1, "С лечением");
			SanatoriumTariff sanatoriumTariff_2 = new SanatoriumTariff(2, 1, "Без лечения");
			SanatoriumTariff sanatoriumTariff_3 = new SanatoriumTariff(3, 1, "Климатолечение");

			SanatoriumTariffList.Add(sanatoriumTariff_1);
			SanatoriumTariffList.Add(sanatoriumTariff_2);
			SanatoriumTariffList.Add(sanatoriumTariff_3);
		}


		#endregion Тариф санатория

		#region Стоимость бронирования
		/// <summary>Список стоиместей бронирования </summary>
		private List<PriceBooking>? _priceBookingList = default;

		/// <summary>Список стоиместей бронирования </summary>
		public List<PriceBooking> PriceBookingList
		{
			get { return _priceBookingList!; }
			set { _priceBookingList = value; }
		}


		/// <summary>Заполнить список стоиместей бронирования </summary>
		public void LoadPriceBookingList()
		{
			PriceBooking currentPriceBooking = new PriceBooking("1-1-1-1",
																DateOnly.Parse("2025,11,17"),
																DateOnly.Parse("2026, 10, 01"),
																DateOnly.Parse("2026, 10, 31"),
																6315);
			PriceBookingList.Add(currentPriceBooking);

			currentPriceBooking.BookingCategoryPriceIndex = "1-1-1-1";
			currentPriceBooking.DatePriceActual = DateOnly.Parse("2025,11,17");
			currentPriceBooking.StartDatePrice = DateOnly.Parse("2026, 11, 01");
			currentPriceBooking.EndDatePrice = DateOnly.Parse("2026, 12, 31");
			currentPriceBooking.CurrentPriceBooking = 5600;

			PriceBookingList.Add(currentPriceBooking);

			currentPriceBooking.BookingCategoryPriceIndex = "1-1-1-1";
			currentPriceBooking.DatePriceActual = DateOnly.Parse("2026,08,01");
			currentPriceBooking.StartDatePrice = DateOnly.Parse("2026, 10, 01");
			currentPriceBooking.EndDatePrice = DateOnly.Parse("2026, 10, 31");
			currentPriceBooking.CurrentPriceBooking = 5490;

			PriceBookingList.Add(currentPriceBooking);

			currentPriceBooking.BookingCategoryPriceIndex = "1-1-1-1";
			currentPriceBooking.DatePriceActual = DateOnly.Parse("2026,08,01");
			currentPriceBooking.StartDatePrice = DateOnly.Parse("2026, 11, 01");
			currentPriceBooking.EndDatePrice = DateOnly.Parse("2026, 12, 31");
			currentPriceBooking.CurrentPriceBooking = 4870;

			PriceBookingList.Add(currentPriceBooking);
		}
		#endregion Стоимость бронирования

		#region Персоны

		/// <summary>Список персон </summary>
		private List<Person>? _personList = default;

		/// <summary>Список персон </summary>
		public List<Person> PersonList
		{
			get { return _personList!; }
			set { _personList = value; }
		}


		public void LoadPersonList()
		{

			Person personIvanovII = new Person(1, "Иванов", "Иван", "Иванович", new DateTime(1977, 12, 06), Gender.Male);
			Person personIvanovaMI = new Person(2, "Иванова", "Мария", "Ивановна", new DateTime(1980, 12, 06), Gender.Female);
			Person personIvanovaEI = new Person(3, "Иванова", "Елена", "Ивановна", new DateTime(2012, 06, 06), Gender.Female);
			Person personPetrovPS = new Person(4, "Петров", "Петр", "Степанович", new DateTime(1946, 09, 06), Gender.Male);
			Person personPetrovaLG = new Person(5, "Петрова", "Людмила", "Георгиевна", new DateTime(1947, 08, 01), Gender.Female);
			Person personPetrovDS = new Person(6, "Петров", "Денис", "Сергеевич", new DateTime(2021, 05, 01), Gender.Male);

			PersonList.Add(personIvanovII);
			PersonList.Add(personIvanovaMI);
			PersonList.Add(personIvanovaEI);
			PersonList.Add(personPetrovPS);
			PersonList.Add(personPetrovaLG);
			PersonList.Add(personPetrovDS);
		}

		#endregion Персоны

		#region Гости
		public void LoadGuestsList()
		{
			Guest guestIvanovII = new Guest(11
											, PersonList[0]
											, StartBooking
											, EndBooking
											, SanatoriumList[0]
											, RoomCategoryList[0]
											, AccommodationTypeList[0]
											, SanatoriumTariffList[0]);
		}
		#endregion Гости

	}
}
