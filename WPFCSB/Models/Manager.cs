
namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о менеджере</summary>
	public class Manager
	{
		/// <summary>Инициализация менеджера с двумя параметрами: идентификатор и персона менеджера</summary>
		/// <param name="managerId">Идентификатор менеджера</param>
		/// <param name="managerPerson">Личность менеджера</param>
		public Manager(Int32 managerId, Person managerPerson)
		{
			ManagerID = managerId;
			ManagerPerson = managerPerson;
		}

		/// <summary>Инициализация менеджера с одним параметром: Идентификатор менеджера</summary>
		/// <param name="managerId">Идентификатор менеджера</param>
		public Manager(Int32 managerId)
		{
			ManagerID = managerId;
		}

		/// <summary>Инициализация менеджера без параметров</summary>
		public Manager() { }

		/// <summary>Идентификатор менеджера</summary>
		private Int32 _managerID = default;
		/// <summary>Идентификатор менеджера</summary>
		public Int32 ManagerID
		{
			get { return _managerID; }
			set { _managerID = value; }
		}

		/// <summary>Личность менеджера</summary>
		private Person _managerPerson = new Person();
		/// <summary>Личность менеджера</summary>
		public Person ManagerPerson
		{
			get { return _managerPerson; }
			set { _managerPerson = value; }
		}
	}
}
