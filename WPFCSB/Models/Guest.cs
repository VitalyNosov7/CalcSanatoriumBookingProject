namespace WPFCSB.Models
{
/// <summary>Класс содержит информацию о госте(клиенте)</summary>
	public class Guest
	{

		/// <summary>Инициализация гостя с двумя параметрами: идентификатор и персона гостя</summary>
		/// <param name="guestID">Идентификатор гостя</param>
		/// <param name="guestPerson">Персона гостя</param>
		public Guest(Int32 guestID, Person guestPerson)
		{
			GuestID = guestID;
			GuestPerson = guestPerson;
		}

		/// <summary>Инициализация гостя с одним параметром: Идентификатор гостя</summary>
		/// <param name="guestID">Идентификатор гостя</param>
		public Guest(Int32 guestID)
		{
			GuestID = guestID;
		}

		/// <summary>Инициализация гостя без параметров</summary>
		public Guest() { }


		/// <summary>Идентификатор гостя</summary>
		private Int32 _guestID;
		/// <summary>Идентификатор гостя</summary>
		public Int32 GuestID
		{
			get { return _guestID; }
			set { _guestID = value; }
		}

		/// <summary>Личность гостя</summary>
		private Person _guestPerson = new Person();
		/// <summary>Личность гостя</summary>
		public Person GuestPerson
		{
			get { return _guestPerson; }
			set { _guestPerson = value; }
		}
	}
}
