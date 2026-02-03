

using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
    /// <summary>   Информация о персоне.   </summary>
    public class Person
    {
        /// <summary>   Идентификатор персоны.  </summary>
        private Int32 _personID = default;

        /// <summary>   Идентификатор персоны.  </summary>
        public Int32 PersonID
        {
            get { return _personID; }
            set { _personID = value; }
        }

        /// <summary>   Фамилия персоны </summary>
        private String _surname = String.Empty;

        /// <summary>   Фамилия персоны </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        /// <summary>   Имя персоны </summary>
        private String _name = String.Empty;

        /// <summary>   Имя персоны </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>   Отчество персоны </summary>
        private String _patronymic = String.Empty;

        /// <summary>   Отчество персоны </summary>
        public String Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = value; }
        }

        /// <summary>   Дата рождения персоны.  </summary>
        private DateTime _birthdate = default;
        /// <summary>   Дата рождения персоны.  </summary>
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        /// <summary>   Пол персоны.  </summary>
        private Gender _gender = default;

        /// <summary>   Пол персоны.  </summary>
        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
