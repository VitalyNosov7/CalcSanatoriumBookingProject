namespace WPFCSB.Models
{
	// TODO: Подумать над дальнейшем использовании этого класса

	/// <summary>Класс содержит информацию о периоде</summary>
	public class DatePeriod
    {
        public DatePeriod(DateTime startDatePeriod, DateTime endDatePeriod)
        {
            StartDatePeriod = startDatePeriod;
			EndDatePeriod = endDatePeriod;
			CountDaysPeriod = GetTimeInterval(StartDatePeriod, EndDatePeriod).Days;
        }

        public DatePeriod() { }

        /// <summary>Дата начала периода</summary>
        private DateTime _startDatePeriod = DateTime.Now;
		/// <summary>Дата начала периода</summary>
		public DateTime StartDatePeriod
        {
            get { return _startDatePeriod; }
            set { _startDatePeriod = value; }
        }

        /// <summary>Дата окончания периода</summary>
        private DateTime _endDatePeriod = DateTime.Now.AddDays(10);
		/// <summary>Дата окончания периода</summary>
		public DateTime EndDatePeriod
        {
            get { return _endDatePeriod; }
            set { _endDatePeriod = value; }
        }

        /// <summary>Количество дней в периоде</summary>
        private Int32 _countDaysPeriod;
		/// <summary>Количество дней в периоде</summary>
		public Int32 CountDaysPeriod
        {
            get { return _countDaysPeriod; }
            set { _countDaysPeriod = value; }
        }

		/// <summary>Получить интервал времени</summary>
		/// <param name="startDatePeriod">Дата начала периода</param>
		/// <param name="endDatePeriod">Дата окончания периода</param>
		/// <returns>Интервал времени</returns>
		public TimeSpan GetTimeInterval(DateTime startDatePeriod, DateTime endDatePeriod)
        {
            TimeSpan timeInterval = default;
            timeInterval = endDatePeriod - startDatePeriod;
            return timeInterval;
        }
    }
}
