
namespace WPFCSB.Models
{
	/// <summary>Данные о менеджере.</summary>
	public class Manager
	{
		public Manager(Int32 managerId, Person managerPerson)
		{
			ManagerID = managerId;
			ManagerPerson = managerPerson;
		}

		public Manager(Int32 managerId)
		{
			ManagerID = managerId;
		}

		public Manager()
		{
			
		}

		/// <summary>   Идентификатор менеджера.  </summary>
		private Int32 _managerID = default;
		/// <summary>   Идентификатор менеджера.  </summary>
		public Int32 ManagerID
		{
			get { return _managerID; }
			set { _managerID = value; }
		}

		/// <summary>   Личность менеджера.  </summary>
		private Person _managerPerson = new Person();
		/// <summary>   Личность менеджера.  </summary>
		public Person ManagerPerson
		{
			get { return _managerPerson; }
			set { _managerPerson = value; }
		}
	}
}
