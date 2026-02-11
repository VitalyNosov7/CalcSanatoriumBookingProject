

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
        public List<Guest> CurrentGuestList
        {
            get { return _currentGuestList!; }
            set { _currentGuestList = value; }
        }

        /// <summary>	Создать(добавить) гостя в список List<Guest>.	</summary>
        public void CreateGuest()
        {
            try
            {
                Guest currentGuest = new Guest();

                //  TODO:  Заполнить экземпляр класса Guest


                CurrentGuestList.Add(currentGuest);
            }
            catch (Exception) { }   
        }

        /// <summary>	Прочитать(получиль) гостя из списока List<Guest>.	</summary>
        public void ReadGuest(Int32 itemNumber)
        {

        }

        /// <summary>	Редактировать(изменить) гостя из списока List<Guest>.	</summary>
        public void UpdateGuest(Int32 itemNumber)
        {

        }

        /// <summary>	Удалить гостя из списока List<Guest>.	</summary>
        public void DeleteGuest(Int32 itemNumber)
        {

        }
    }
}
