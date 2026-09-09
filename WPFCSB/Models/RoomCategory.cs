namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о категории номера санатория</summary>
	public class RoomCategory
	{
		/// <summary>Конструктор категории номера с тремя параметрами</summary>
		/// <param name="roomCategoryID">Идентификатор категории номера санатория</param>
		/// <param name="sanatoriumID">Идентификатор санатория</param>
		/// <param name="roomCategoryName">Наименование категории номера санатория</param>
		public RoomCategory(Int32 roomCategoryID, Int32 sanatoriumID, String roomCategoryName)
		{
			RoomCategoryID = roomCategoryID;
			SanatoriumID = sanatoriumID;
			RoomCategoryName = roomCategoryName;
		}

		/// <summary>Конструктор категории номера с двумя параметрами</summary>		
		/// <param name="sanatoriumID">Идентификатор санатория</param>
		/// <param name="roomCategoryName">Наименование категории номера санатория</param>
		public RoomCategory(Int32 sanatoriumID, String roomCategoryName)
		{
			SanatoriumID = sanatoriumID;
			RoomCategoryName = roomCategoryName;
		}

		/// <summary>Конструктор категории номера без параметров</summary>		
		public RoomCategory() { }

		/// <summary>Идентификатор категории номера санатория</summary>
		private Int32 _roomCategoryID;
		/// <summary>Идентификатор категории номера санатория</summary>
		public Int32 RoomCategoryID
		{
			get { return _roomCategoryID; }
			set { _roomCategoryID = value; }
		}

		/// <summary>Идентификатор санатория</summary>
		private Int32 _sanatoriumID;
		/// <summary>Идентификатор санатория</summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Текущий санаторий</summary>
		private Sanatorium _currentSanatorium;
		/// <summary>Текущий санаторий</summary>
		public Sanatorium CurrentSanatorium
		{
			get { return _currentSanatorium; }
			set { _currentSanatorium = value; }
		}


		/// <summary>Наименование категории номера санатория</summary>
		private String _roomCategoryName = String.Empty;
		/// <summary>Наименование категории номера санатория</summary>
		public String RoomCategoryName
		{
			get { return _roomCategoryName; }
			set { _roomCategoryName = value; }
		}


	}
}
