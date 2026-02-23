

namespace CalcSanatoriumBooking.Model
{
    /// <summary>   Данные бронирования.    </summary>
    public class BookingDetails : BookingCalcID
    {

        public BookingDetails(Int32 calcId)
        {
            СalcId = calcId;
        }

        /// <summary>   Санаторий. </summary>
        private Sanatorium? _currentSanatorium = default;

        /// <summary>   Санаторий. </summary>
        public Sanatorium CurrentSanatorium
        {
            get { return _currentSanatorium!; }
            set { _currentSanatorium = value; }
        }

		/// <summary>Категория номера</summary>
		private RoomCategory? _currentRoomCategory = default;

		/// <summary>Категория номера</summary>
		public RoomCategory CurrentRoomCategory
		{
            get { return _currentRoomCategory!; }
            set { _currentRoomCategory = value; }
        }

		/// <summary>Категория номера</summary>
		private TypeOfAccommodation? _currentTypeOfAccommodation = default;

		/// <summary>Категория номера</summary>
		public TypeOfAccommodation CurrentTypeOfAccommodation
        {
            get { return _currentTypeOfAccommodation!; }
            set { _currentTypeOfAccommodation= value; }
        }

		//  TODO:   Тариф лечения

        private SanatoriumTariff? _currentSanatoriumTariff = default;

        public SanatoriumTariff CurrentSanatoriumTariff
        {
            get { return _currentSanatoriumTariff!; }
            set { _currentSanatoriumTariff= value; }
        }

		/// <summary>   Дата создания бронирования. </summary>
		private DateOnly _dateBookingCreation = default;

        /// <summary>   Дата создания бронирования. </summary>
        public DateOnly DateBookingCreation
        {
            get { return _dateBookingCreation; }
            set { _dateBookingCreation = value; }
        }

        /// <summary>   Дата начала бронирования. </summary>
        private DateOnly _bookingStartDate = default;

        /// <summary>   Дата начала бронирования. </summary>
        public DateOnly BookingStartDate
        {
            get { return _bookingStartDate; }
            set { _bookingStartDate = value; }
        }

        /// <summary>   Дата окончания бронирования. </summary>
        private DateOnly _bookingEndDate = default;

        /// <summary>   Дата окончания бронирования. </summary>
        public DateOnly BookingEndDate
        {
            get { return _bookingEndDate; }
            set { _bookingEndDate = value; }
        }

        /// <summary>   Список гостей. </summary>
        private List<Guest>? _currentGuestList = default;

        /// <summary>   Список гостей. </summary>
        public List<Guest> CurrentGuestList
        {
            get { return _currentGuestList!; }
            set { _currentGuestList = value; }
        }
    }
}
