namespace CalcSanatoriumBooking.Data
{
	/// <summary>Категория номера</summary>
	public class RoomCategory
	{

		/// <summary>Идентификатор категории номера</summary>
		private Int32 _idRoomCategory;

		/// <summary>Идентификатор категории номера</summary>
		public Int32 IdRoomCategory
		{
			get { return _idRoomCategory; }
			set { _idRoomCategory = value; }
		}

		/// <summary>Наименование категории номера</summary>
		private String _nameRoomCategory = String.Empty;

		/// <summary>Наименование категории номера</summary>
		public String NameRoomCategory
		{
			get { return _nameRoomCategory; }
			set { _nameRoomCategory = value; }
		}
	}
}
