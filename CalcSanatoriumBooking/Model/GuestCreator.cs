namespace CalcSanatoriumBooking.Model
{
    public class GuestCreator 
    {
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
