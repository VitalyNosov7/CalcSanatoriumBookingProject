using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Data
{
	/// <summary>Тестовые данные </summary>
	public class TestData
	{
        #region Стоимость бронирования
        /// <summary>Список стоиместей бронирования </summary>
        private List<PriceBooking>? _priceBookingList = default;

		/// <summary>Список стоиместей бронирования </summary>
		public List<PriceBooking> PriceBookingList
		{
			get { return _priceBookingList!; }
			set { _priceBookingList = value; }
		}

		public TestData()
		{
			LoadPriceBookingList();

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

			currentPriceBooking.IndexBookingCategory = "1-1-1-1";
			currentPriceBooking.DatePriceActual = DateOnly.Parse("2025,11,17");
			currentPriceBooking.StartDatePrice = DateOnly.Parse("2026, 11, 01");
			currentPriceBooking.EndDatePrice = DateOnly.Parse("2026, 12, 31");
			currentPriceBooking.CurrentPriceBooking = 5600;

			PriceBookingList.Add(currentPriceBooking);

			currentPriceBooking.IndexBookingCategory = "1-1-1-1";
			currentPriceBooking.DatePriceActual = DateOnly.Parse("2026,08,01");
			currentPriceBooking.StartDatePrice = DateOnly.Parse("2026, 10, 01");
			currentPriceBooking.EndDatePrice = DateOnly.Parse("2026, 10, 31");
			currentPriceBooking.CurrentPriceBooking = 5490;

			PriceBookingList.Add(currentPriceBooking);

			currentPriceBooking.IndexBookingCategory = "1-1-1-1";
			currentPriceBooking.DatePriceActual = DateOnly.Parse("2026,08,01");
			currentPriceBooking.StartDatePrice = DateOnly.Parse("2026, 11, 01");
			currentPriceBooking.EndDatePrice = DateOnly.Parse("2026, 12, 31");
			currentPriceBooking.CurrentPriceBooking = 4870;

			PriceBookingList.Add(currentPriceBooking);
		}
		#endregion Стоимость бронирования

		#region Персоны

		Person personIvanovII = new Person(1, "Иванов", "Иван", "Иванович", new DateTime(1977, 12, 06), Gender.Male);
        Person personIvanovaMI = new Person(1, "Иванова", "Мария", "Ивановна", new DateTime(1980, 12, 06), Gender.Female);
        Person personIvanovaEI = new Person(1, "Иванова", "Елена", "Ивановна", new DateTime(2012, 06, 06), Gender.Female);
        Person personPetrovPS = new Person(1, "Петров", "Петр", "Степанович", new DateTime(1946, 09, 06), Gender.Male);
        Person personPetrovaLG = new Person(1, "Петрова", "Людмила", "Георгиевна", new DateTime(1947, 08, 01), Gender.Female);
        Person personPetrovDS = new Person(1, "Петров", "Денис", "Сергеевич", new DateTime(2021, 05, 01), Gender.Male);

        #endregion Персоны

    }
}
