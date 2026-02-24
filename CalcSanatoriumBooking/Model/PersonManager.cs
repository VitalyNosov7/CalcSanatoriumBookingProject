

using System;
using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
	//  В этом классе создается и редактируется персона.
	/// <summary>Менеджер Персон(создание, редактирование.)</summary>
	public class PersonManager
	{
		/// <summary>Персона</summary>
		private Person? _currentPerson = default;

		/// <summary>Персона</summary>
		public Person CurrentPerson
		{
			get
			{
				if (_currentPerson == null) { } //	TODO:	Что должно происходить если null?
				return _currentPerson!;
			}
			set { _currentPerson = value; }
		}

		/// <summary>Создать персону</summary>
		public void CreatePerson(Int32 personId
								, String surname
								, String name
								, String patronymic
								, DateTime birthdate
								, Gender gender)
		{
			Person createdPerson = new Person(personId, surname, name, patronymic, birthdate, gender);
			CurrentPerson = createdPerson;
		}

		/// <summary>Прочитать(получить) персону</summary>
		public Person ReadPerson()
		{
			return CurrentPerson;
		}

		/// <summary>Редактировать персону</summary>
		public void UpdatePerson(Int32 personId
								, String surname
								, String name
								, String patronymic
								, DateTime birthdate
								, Gender gender)
		{
			Person editablePerson = CurrentPerson;

			editablePerson.PersonID = personId;
			editablePerson.Surname = surname;
			editablePerson.Name = surname;
			editablePerson.Patronymic = patronymic;
			editablePerson.Birthdate = birthdate;
			editablePerson.Gender = gender;

			CurrentPerson = editablePerson;
		}

	}

}
