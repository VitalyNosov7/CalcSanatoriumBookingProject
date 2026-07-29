using System.Timers;
using System.Windows;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.Models
{
    /// <summary>   Данные периода бронирования.    </summary>
    public class BookingPeriod : ViewModelBase
    {
        public BookingPeriod(DateTime startDatePeriodBooking, DateTime endDatePeriodBooking)
        {
            StartDatePeriodBooking = startDatePeriodBooking;
            EndDatePeriodBooking = endDatePeriodBooking;
            //NumberNightsBooked = GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
        }

        public BookingPeriod() { }

        /// <summary>   Дата начала периода бронирования. </summary>
        private DateTime _startDatePeriodBooking = DateTime.Now;

        /// <summary>   Дата начала периода  бронирования. </summary>
        public DateTime StartDatePeriodBooking
        {
            get { return _startDatePeriodBooking; }
            set 
            {
                //NumberNightsBooked = GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
                Set(ref _startDatePeriodBooking, value);
                NumberNightsBooked = GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
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
                //NumberNightsBooked = GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
                Set(ref _endDatePeriodBooking, value);
                NumberNightsBooked = GetTimeInterval(StartDatePeriodBooking, EndDatePeriodBooking).Days;
            }
        }

        /// <summary>   Количество ночей бронирования. </summary>
        private Int32 _numberNightsBooked;
        /// <summary>   Количество ночей бронирования. </summary>
        public Int32 NumberNightsBooked
        {
            get { return _numberNightsBooked; }
            set {
                Set(ref _numberNightsBooked, value);  /* MessageBox.Show("Свойство NumberNightsBooked!");*/
            }
        }


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
    }
}
