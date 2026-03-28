namespace CalcSanatoriumBooking.Data
{
	/// <summary>Категория номера</summary>
	public class RoomCategory
	{

		public RoomCategory(Int32 roomCategoryID, Int32 sanatoriumID, String roomCategoryName)
		{
			RoomCategoryID = roomCategoryID;
			SanatoriumID = sanatoriumID;
			RoomCategoryName = roomCategoryName;
		}

		/// <summary>Идентификатор категории номера</summary>
		private Int32 _roomCategoryID;

		/// <summary>Идентификатор категории номера</summary>
		public Int32 RoomCategoryID
		{
			get { return _roomCategoryID; }
			set { _roomCategoryID = value; }
		}

		/// <summary>   Идентификатор санатория.    </summary>
		private Int32 _sanatoriumID = default;

		/// <summary>   Идентификатор санатория.    </summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Наименование категории номера</summary>
		private String _roomCategoryName = String.Empty;

		/// <summary>Наименование категории номера</summary>
		public String RoomCategoryName
		{
			get { return _roomCategoryName; }
			set { _roomCategoryName = value; }
		}
	}
}
