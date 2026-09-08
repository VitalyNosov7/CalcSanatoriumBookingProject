namespace CalcSanatoriumBooking.Data
{
	/// <summary>Информация о госте</summary>
	public class Guest
	{
		/// <summary>Инициализация гостя с двумя параметрами: идентификатор и персона гостя</summary>
		/// <param name="_guestID">Идентификатор гостя</param>
		/// <param name="person">Личность гостя</param>
		public Guest(Int32 _guestID, Person person)
		{
			GuestID = _guestID;
			GuestPersonID = person.PersonID;
			GuestPerson = person;
		}

		public Guest() { }
		/// <summary>Идентификатор гостя</summary>
		private Int32 _guestID = default;

		/// <summary>Идентификатор гостя</summary>
		public Int32 GuestID
		{
			get { return _guestID; }
			set { _guestID = value; }
		}

		/// <summary>Идентификатор персоны гостя(Внешний ключ)</summary>
		private Int32 _guestPersonID = default;
		/// <summary>Идентификатор персоны гостя(Внешний ключ)</summary>
		public Int32 GuestPersonID
		{
			get { return _guestPersonID; }
			set { _guestPersonID = value; }
		}

		/// <summary>Личность гостя</summary>
		private Person _guestPerson = null!;
		/// <summary>Личность гостя</summary>		
		public Person GuestPerson
		{
			get { return _guestPerson; }
			set { _guestPerson = value; }
		}
	}
}
