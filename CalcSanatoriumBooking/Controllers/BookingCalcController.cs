

using CalcSanatoriumBooking.Model;

namespace CalcSanatoriumBooking.Controllers
{
    public class BookingCalcController : BookingCalcID
        
    {
        /// <summary>   Данные бронирования.    </summary>
        private BookingDetails? _currentBookingDetails = default;

        /// <summary>   Данные бронирования.    </summary>
        public BookingDetails? CurrentBookingDetails
        {
            get { return _currentBookingDetails; }
            set { _currentBookingDetails = value; }
        }

        /// <summary>   Конструктор расчета бронирования.   </summary>
        private BookingCalcManager? _currentBookingCalcConstructor = default;

        /// <summary>   Конструктор расчета бронирования.   </summary>
        public BookingCalcManager CurrentBookingCalcConstructor
        {
            get { return _currentBookingCalcConstructor!; }
            set { _currentBookingCalcConstructor = value; }
        }


        public BookingCalcController(Int32 calcId)
        {
            СalcId = calcId;
            CurrentBookingDetails = new BookingDetails(calcId);
            CurrentBookingCalcConstructor = new BookingCalcManager(calcId);

        }




    }
}
