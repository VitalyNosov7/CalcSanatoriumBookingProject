
namespace CalcSanatoriumBooking.Data
{
	/// <summary>Стоимость бронирования</summary>
	public class PriceBooking
	{
		/// <summary>Дата актуальности стоимости бронирования</summary>
		private DateOnly _datePriceActual = default;

		/// <summary>Дата актуальности стоимости бронирования</summary>
		public DateOnly DatePriceActual
		{
			get { return _datePriceActual; }
			set { _datePriceActual = value; }
		}

		/// <summary>Дата начала действия стоимости бронирования</summary>
		private DateOnly _startDatePrice = default;

		/// <summary>Дата начала действия стоимости бронирования</summary>
		public DateOnly StartDatePrice
		{
			get { return _startDatePrice; }
			set { _startDatePrice = value; }
		}

		/// <summary>Дата окончания действия стоимости бронирования</summary>
		private DateOnly _endDatePrice = default;

		/// <summary>Дата окончания действия стоимости бронирования</summary>
		public DateOnly EndDatePrice
		{
			get { return _endDatePrice; }
			set { _endDatePrice = value; }
		}

		/// <summary>Cтоимость бронирования</summary>
		private Int32 _currentPriceBooking = default;

		/// <summary>Cтоимость бронирования</summary>
		public Int32 CurrentPriceBooking
		{
			get { return _currentPriceBooking; }
			set { _currentPriceBooking = value; }
		}

		/// <summary>Индекс расчета бронирования(индекс: санатория; категория номера, вид размещения)</summary>
		private String _indexBookingCategory = String.Empty;

		/// <summary>Индекс расчета бронирования</summary>
		public String IndexBookingCategory
		{
			get { return _indexBookingCategory; }
			set { _indexBookingCategory = value; }
		}

		/// <summary>Стоимость бронирования</summary>
		/// <param name="indexBookingCategory">Индекс расчета бронирования(индекс: санатория; категория номера, вид размещения, лечение)</param>
		/// <param name="datePriceActual">Дата актуальности стоимости бронирования</param>
		/// <param name="startDatePrice">Дата начала действия стоимости бронирования</param>
		/// <param name="endDatePrice">Дата окончания действия стоимости бронирования</param>
		/// <param name="currentPriceBooking">Cтоимость бронирования</param>
		public PriceBooking(String indexBookingCategory,
							DateOnly datePriceActual,
							DateOnly startDatePrice,
							DateOnly endDatePrice,
							Int32 currentPriceBooking)
		{
			IndexBookingCategory = indexBookingCategory;
			DatePriceActual = datePriceActual;
			StartDatePrice = startDatePrice;
			EndDatePrice = endDatePrice;
			CurrentPriceBooking = currentPriceBooking;
		}
	}
}
