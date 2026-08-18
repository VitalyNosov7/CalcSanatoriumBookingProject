namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о менеджере</summary>
	public class Manager
	{
		/// <summary>Инициализация менеджера с двумя параметрами: идентификатор и персона менеджера</summary>
		/// <param name="managerId">Идентификатор менеджера</param>
		/// <param name="person">Личность менеджера</param>
		public Manager(Int32 managerId,  Person person)
		{
			ManagerID = managerId;
			ManagerPersonID = person.PersonID;
			ManagerPerson = person;
		}

		/// <summary>Идентификатор менеджера</summary>
		private Int32 _managerID = default;
		/// <summary>Идентификатор менеджера</summary>
		public Int32 ManagerID
		{
			get { return _managerID; }
			set { _managerID = value; }
		}

		/// <summary>Идентификатор персоны менеджера</summary>
		private Int32 _managerPersonID = default;
		/// <summary>Идентификатор персоны менеджера</summary>
		public Int32 ManagerPersonID
		{
			get { return _managerPersonID; }
			set { _managerPersonID = value; }
		}
		
		/// <summary>Личность менеджера</summary>
		private Person _managerPerson = null!;
		/// <summary>Личность менеджера</summary>		
		public Person ManagerPerson
		{
			get { return _managerPerson; }
			set { _managerPerson = value; }
		}
	}
}
