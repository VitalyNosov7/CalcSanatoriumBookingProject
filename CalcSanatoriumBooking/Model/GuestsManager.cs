namespace CalcSanatoriumBooking.Model
{
	//  В этом классе создается список гостей.
	public class GuestsManager
	{
		/// <summary>   Список гостей. </summary>
		private List<Guest>? _currentGuestList = default;

		/// <summary>   Список гостей. </summary>
		public List<Guest> CurrentGuestList
		{
			get { return _currentGuestList!; }
			set { _currentGuestList = value; }
		}

		//	TODO:	Подумать как и где будет добавляться и редактироваться персона.
		///// <summary>Менеджер Персон(создание, редактирование.)</summary>
		//private PersonManager _currentPersonManager = new PersonManager();

		///// <summary>Менеджер Персон(создание, редактирование.)</summary>
		//public PersonManager CurrentPersonManager
		//{
		//	get { return _currentPersonManager; }
		//	set { _currentPersonManager = value; }
		//}

		/// <summary>	Создать(добавить) гостя в список List<Guest>.	</summary>
		public void CreateGuest(Int32 guestID
								, Person currentPerson
								, DateTime startDateResidence
								, DateTime endDateResidence
								, Sanatorium currentSanatorium
								, RoomCategory currentRoomCategory
								, TypeOfAccommodation currentTypeOfAccommodation
								, SanatoriumTariff currentSanatoriumTariff)
		{
			Guest createdGuest = new Guest(guestID
											, currentPerson
											, startDateResidence
											, endDateResidence
											, currentSanatorium
											, currentRoomCategory
											, currentTypeOfAccommodation
											, currentSanatoriumTariff);

				CurrentGuestList.Add(createdGuest);
		}

		/// <summary>	Прочитать(получиль) гостя из списока List<Guest>.	</summary>
		public void ReadGuest(Int32 guestID)
		{

		}

		/// <summary>	Редактировать(изменить) гостя из списока List<Guest>.	</summary>
		public void UpdateGuest(Int32 guestID)
		{

		}

		/// <summary>	Удалить гостя из списока List<Guest>.	</summary>
		public void DeleteGuest(Int32 guestID)
		{

		}

	}
}
