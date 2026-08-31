using System.Globalization;
using WPFCSB.Resources;

namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о персоне</summary>
	public class Person
	{
		/// <summary>Инициализация персоны с пятью параметрами</summary>
		/// <param name="personId">Идентификатор персоны</param>
		/// <param name="surname">Фамилия персоны</param>
		/// <param name="name">Имя персоны</param>
		/// <param name="patronymic">Отчество персоны</param>
		/// <param name="birthdate">Дата роджения персоны</param>
		/// <param name="gender">Пол персоны</param>
		public Person(Int32 personId
						, String surname
						, String name
						, String patronymic
						, DateTime birthdate
						, Gender gender)
		{
			PersonID = personId;
			Surname = surname;
			Name = name;
			Patronymic = patronymic;
			Birthdate = birthdate;
			Gender = gender;
			FullNamePerson = GetFullName();
		}

		/// <summary>Инициализация персоны с пятью параметрами</summary>
		/// <param name="surname">Фамилия персоны</param>
		/// <param name="name">Имя персоны</param>
		/// <param name="patronymic">Отчество персоны</param>
		/// <param name="birthdate">Дата роджения персоны</param>
		/// <param name="gender">Пол персоны</param>
		public Person(	String surname
						, String name
						, String patronymic
						, DateTime birthdate
						, Gender gender)
		{
			Surname = surname;
			Name = name;
			Patronymic = patronymic;
			Birthdate = birthdate;
			Gender = gender;
			FullNamePerson = GetFullName();
		}

		public Person() { }

		/// <summary>Идентификатор персоны</summary>
		private Int32 _personID = default;
		/// <summary>Идентификатор персоны</summary>
		public Int32 PersonID
		{
			get { return _personID; }
			set { _personID = value; }
		}

		/// <summary>Фамилия персоны</summary>
		private String _surname = String.Empty;
		/// <summary>Фамилия персоны</summary>
		public String Surname
		{
			get { return _surname; }
			set { _surname = value; }
		}

		/// <summary>Имя персоны</summary>
		private String _name = String.Empty;
		/// <summary>Имя персоны</summary>
		public String Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>Отчество персоны</summary>
		private String _patronymic = String.Empty;
		/// <summary>Отчество персоны</summary>
		public String? Patronymic
		{
			get { return _patronymic; }
			set { _patronymic = value!; }
		}

		// TODO: Подумать над целесообразностью этого свойства и поля
		/// <summary>Полная ФИО персоны</summary>
		private String _fullNamePerson = String.Empty;
		/// <summary>Полная ФИО персоны</summary>
		public String FullNamePerson
		{
			get { return _fullNamePerson; }
			set { _fullNamePerson = GetFullName(); }
		}		

		/// <summary>Дата рождения персоны</summary>
		private DateTime _birthdate = default;
		/// <summary>Дата рождения персоны</summary>
		public DateTime Birthdate
		{
			get { return _birthdate; }
			set { _birthdate = value; }
		}

		// TODO: Подумать как будет отображаться в базе данных
		/// <summary>Пол персоны</summary>
		private Gender _gender = default;
		/// <summary>Пол персоны</summary>
		public Gender Gender
		{
			get { return _gender; }
			set { _gender = value; }
		}

		/// <summary>Получить полную ФИО</summary>
		public String GetFullName()
		{
			String returnableFullName = String.Empty;

			if (String.IsNullOrEmpty(Surname))
			{
				return returnableFullName;
			}
			else
			{
				returnableFullName = $"{Surname} {Name} {Patronymic}".Trim();
			}

			return returnableFullName;
		}

		/// <summary>Получить из полного ФИО - сокращенное</summary>
		/// <param name="fullName">Полное ФИО</param>
		/// <returns></returns>
		public String GetSurnameWithInitials(String fullName)
		{
			if (String.IsNullOrWhiteSpace(fullName))
				return String.Empty;

			var parts = fullName
				.Trim()
				.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

			if (parts.Length == 0)
				return String.Empty;

			String surname = parts[0].Trim();
			// Делаем первый символ заглавной буквой
			var culture = CultureInfo.CurrentCulture; 
			surname = culture.TextInfo.ToTitleCase(surname.ToLower());

			if (parts.Length == 1)
				return surname;

			Char firstInitial = Char.ToUpper(parts[1][0]);

			if (parts.Length == 2)
				return $"{surname} {firstInitial}.";

			Char secondInitial = Char.ToUpper(parts[2][0]);
			return $"{surname} {firstInitial}.{secondInitial}.";
		}
	}
}
