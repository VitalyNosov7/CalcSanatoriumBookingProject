

using CalcSanatoriumBooking.Model;

namespace CalcSanatoriumBooking.Controller
{
    public class ControllerBookingCalc : BookingCalcID
        
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
        private BookingCalcConstructor? _currentBookingCalcConstructor = default;

        /// <summary>   Конструктор расчета бронирования.   </summary>
        public BookingCalcConstructor CurrentBookingCalcConstructor
        {
            get { return _currentBookingCalcConstructor!; }
            set { _currentBookingCalcConstructor = value; }
        }


        public ControllerBookingCalc(Int32 calcId)
        {
            СalcId = calcId;
            CurrentBookingDetails = new BookingDetails(calcId);
            CurrentBookingCalcConstructor = new BookingCalcConstructor(calcId);

        }




    }
}
