

namespace CalcSanatoriumBooking.Model
{
    public abstract class BookingCalcID
    {
		/// <summary>	
		///		Идентификатор расчета бронирования.
		///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
		///	</summary>
		private Int32 _calcId = default;

		/// <summary>	
		///		Идентификатор расчета бронирования.
		///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
		///	</summary>
		public Int32 СalcId
		{
			get => _calcId;
			set => _calcId = value;
		}
	}
}
