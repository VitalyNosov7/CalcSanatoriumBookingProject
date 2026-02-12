

using CalcSanatoriumBooking.Resources;


namespace CalcSanatoriumBooking.Model
{
    /// <summary>   Информация о госте. </summary>
    public class Guest 
    {
        /// <summary>   Идентификатор гостя.  </summary>
        private Int32 _guestID = default;

        /// <summary>   Идентификатор гостя.  </summary>
        public Int32 GuestID
        {
            get { return _guestID; }
            set { _guestID = value; }
        }

        /// <summary>   Информация о персоне.  </summary>
        private Person? _currentPerson;

        /// <summary>   Информация о персоне.  </summary>
        public Person CurrentPerson
        {
            get { return _currentPerson!; }
            set { _currentPerson = value; }
        }

        /// <summary>   Дата начала проживания. </summary>
        private DateTime _startDateResidence = default;

        /// <summary>   Дата начала проживания. </summary>
        public DateTime StartDateResidence
        {
            get { return _startDateResidence; }
            set { _startDateResidence = value; }
        }

        /// <summary>   Дата окончания проживания. </summary>
        private DateTime _endDateResidence = default;

        /// <summary>   Дата окончания проживания. </summary>
        public DateTime EndDateResidence
        {
            get { return _endDateResidence; }
            set { _endDateResidence = value; }
        }

        /// <summary>  Вид размещения. </summary>
        private TypeAccommodationSanatorium _currentTypeAccomodation = default;

        /// <summary>  Вид размещения. </summary>
        public TypeAccommodationSanatorium CurrentTypeAccomodation
        {
            get { return _currentTypeAccomodation;  }
            set { _currentTypeAccomodation = value; }
        }
    }
}
