using CalcSanatoriumBooking.Model;
using CalcSanatoriumBooking.Resources;


namespace CalcSanatoriumBooking.Data
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
		private Person? _currentPerson = default;

		/// <summary>   Информация о персоне.  </summary>
		public Person CurrentPerson
		{
			get
			{
				if (_currentPerson == null) { } //	TODO:	Что должно происходить если null?
				return _currentPerson!;
			}
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

		/// <summary>  Санаторий </summary>
		private Sanatorium? _currentSanatorium = default;

		/// <summary>  Санаторий </summary>
		public Sanatorium CurrentSanatorium
		{
			get { return _currentSanatorium!; }
			set { _currentSanatorium = value; }

		}

		/// <summary>  Категория номера </summary>
		private RoomCategory? _currentRoomCategory = default;

		/// <summary>  Категория номера </summary>
		public RoomCategory CurrentRoomCategory
		{
			get { return _currentRoomCategory!; }
			set { _currentRoomCategory = value; }
		}

		/// <summary>  Вид размещения. </summary>
		private TypeOfAccommodation? _currentTypeOfAccommodation = default;

		/// <summary>  Вид размещения. </summary>
		public TypeOfAccommodation CurrentTypeOfAccommodation
		{
			get { return _currentTypeOfAccommodation!; }
			set { _currentTypeOfAccommodation = value; }
		}

		/// <summary>Тариф санатория(с лечением, без лечения, климатолечение, оздоровление)</summary>
		private SanatoriumTariff? _currentSanatoriumTariff = default;

		/// <summary>Тариф санатория(с лечением, без лечения, климатолечение, оздоровление)</summary>
		public SanatoriumTariff CurrentSanatoriumTariff
		{
			get { return _currentSanatoriumTariff!; }
			set { _currentSanatoriumTariff = value; }
		}

		public Guest(Int32 guestID
					, Person currentPerson
					, DateTime startDateResidence
					, DateTime endDateResidence
					, Sanatorium currentSanatorium
					, RoomCategory currentRoomCategory
					, TypeOfAccommodation currentTypeOfAccommodation
					, SanatoriumTariff currentSanatoriumTariff)
		{
			GuestID = guestID;
			CurrentPerson = currentPerson;
			StartDateResidence = startDateResidence;
			EndDateResidence = endDateResidence;
			CurrentSanatorium = currentSanatorium;
			CurrentRoomCategory = currentRoomCategory;
			CurrentTypeOfAccommodation = currentTypeOfAccommodation;
			CurrentSanatoriumTariff = currentSanatoriumTariff;
		}
	}
}
