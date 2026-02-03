

namespace CalcSanatoriumBooking.Model
{
    /// <summary>   Данные бронирования.    </summary>
    public class BookingDetails : BookingCalcID
    {
        //  Санаторий

        /// <summary>   Дата создания бронирования. </summary>
        private DateTime _dateBookingCreation = default;

        /// <summary>   Дата создания бронирования. </summary>
        public DateTime DateBookingCreation
        {
            get { return _dateBookingCreation; }
            set { _dateBookingCreation = value; }
        }

        /// <summary>   Дата начала бронирования. </summary>
        private DateTime _bookingStartDate = default;

        /// <summary>   Дата начала бронирования. </summary>
        public DateTime BookingStartDate
        {
            get { return _bookingStartDate; }
            set { _bookingStartDate = value; }
        }

        /// <summary>   Дата окончания бронирования. </summary>
        private DateTime _bookingEndDate = default;

        /// <summary>   Дата окончания бронирования. </summary>
        public DateTime BookingEndDate 
        {
            get { return _bookingEndDate; }
            set { _bookingEndDate = value; }
        }

        /// <summary>   Список гостей. </summary>
        private List<Guest>? _currentGuestList = default;

        /// <summary>   Список гостей. </summary>
        public List<Guest>? CurrentGuestList
        {
            get { return _currentGuestList; }
            set { _currentGuestList = value; }
        }
        }
    }
