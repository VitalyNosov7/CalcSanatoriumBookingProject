using CalcSanatoriumBooking.Data;

namespace CalcSanatoriumBooking.Model
{
	/// <summary>Тестовые данные </summary>
	public class TestData
	{
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

	}
}
