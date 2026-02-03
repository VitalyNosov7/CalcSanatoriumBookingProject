

namespace CalcSanatoriumBooking.Model
{
    /// <summary>   Информация о госте. </summary>
    public class Guest : Person
    {
        /// <summary>   Идентификатор персоны.  </summary>
        private Int32 _guestID = default;

        /// <summary>   Идентификатор персоны.  </summary>
        public Int32 GuestID
        {
            get { return _guestID; }
            set { _guestID = value; }
        }
    }
}
