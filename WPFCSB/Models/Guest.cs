using System.ComponentModel.DataAnnotations.Schema;

namespace WPFCSB.Models
{
/// <summary>Класс содержит информацию о госте(клиенте)</summary>
	public class Guest
	{
		/// <summary>Инициализация гостя с двумя параметрами: идентификатор и персона гостя</summary>
		/// <param name="guestID">Идентификатор гостя</param>
		/// <param name="person">Персона гостя</param>
		public Guest(Int32 guestID, Person person)
		{
			GuestID = guestID;
			GuestPersonID = person.PersonID;
			GuestPerson = person;
		}

		/// <summary>Идентификатор гостя</summary>
		private Int32 _guestID;
		/// <summary>Идентификатор гостя</summary>
		public Int32 GuestID
		{
			get { return _guestID; }
			set { _guestID = value; }
		}

		/// <summary>Идентификатор персоны гостя</summary>
		private Int32 _guestPersonID;
		/// <summary>Идентификатор персоны гостя</summary>
		public Int32 GuestPersonID
		{
			get { return _guestPersonID; }
			set { _guestPersonID = value; }
		}

		/// <summary>Личность гостя</summary>
		private Person _guestPerson = null!;
		/// <summary>Личность гостя</summary>
		[NotMapped]
		public Person GuestPerson
		{
			get { return _guestPerson; }
			set { _guestPerson = value; }
		}
	}
}
