namespace WPFCSB.Models
{
    /// <summary>   Данные периода бронирования.    </summary>
    public class BookingPeriod
	{
		public BookingPeriod(DateTime startDatePeriodBooking, DateTime endDatePeriodBooking)
		{
			StartDatePeriodBooking = startDatePeriodBooking;
			EndDatePeriodBooking = endDatePeriodBooking;
		}

		public BookingPeriod(){}

		/// <summary>   Дата начала периода бронирования. </summary>
		private DateTime _startDatePeriodBooking = DateTime.Now;

		/// <summary>   Дата начала периода  бронирования. </summary>
		public DateTime StartDatePeriodBooking
		{
            get { return _startDatePeriodBooking; } 
            set { _startDatePeriodBooking = value; }
        }

		/// <summary>   Дата окончания периода  бронирования. </summary>
		private DateTime _endDatePeriodBooking = DateTime.Now.AddDays(10);

		/// <summary>   Дата окончания периода  бронирования. </summary>
		public DateTime EndDatePeriodBooking
		{
            get { return _endDatePeriodBooking; }
            set { _endDatePeriodBooking = value; }
        }
	}
}
