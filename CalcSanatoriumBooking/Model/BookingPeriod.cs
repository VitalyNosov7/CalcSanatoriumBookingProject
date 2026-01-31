

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalcSanatoriumBooking.Model
{
    /// <summary>   Данные бронирования.    </summary>
    public class BookingPeriod : BookingCalc
	{
		/// <summary>   Дата начала периода расчета бронирования. </summary>
		private DateTime _startDatePeriodBookingCalc = default;

		/// <summary>   Дата начала периода расчета бронирования. </summary>
		public DateTime StartDatePeriodBookingCalc
		{
            get { return _startDatePeriodBookingCalc; } 
            set { _startDatePeriodBookingCalc = value; }
        }

		/// <summary>   Дата окончания периода расчета бронирования. </summary>
		private DateTime _endDatePeriodBookingCalc = default;

		/// <summary>   Дата окончания периода расчета бронирования. </summary>
		public DateTime EndDatePeriodBookingCalc
		{
            get { return _endDatePeriodBookingCalc; }
            set { _endDatePeriodBookingCalc = value; }
        }
	}
}
