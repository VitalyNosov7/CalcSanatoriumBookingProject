namespace CalcSanatoriumBooking.Data
{
    /// <summary>Вид размещения</summary>
    public class AccommodationType
    {
		public AccommodationType(Int32 accommodationTypeID, Int32 sanatoriumID, String accommodationTypeName)
		{
			AccommodationTypeID = accommodationTypeID;
			SanatoriumID = sanatoriumID;
			AccommodationTypeName = accommodationTypeName;
		}

		/// <summary>Идентификатор Вида размещения</summary>
		private Int32 _accommodationTypeID;

		/// <summary>Идентификатор Вида размещения</summary>
		public Int32 AccommodationTypeID
		{
			get { return _accommodationTypeID; }
			set { _accommodationTypeID = value; }
		}

		/// <summary>   Идентификатор санатория.    </summary>
		private Int32 _sanatoriumID = default;

		/// <summary>   Идентификатор санатория.    </summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Наименование Вида размещения</summary>
		private String _accommodationTypeName = String.Empty;

		/// <summary>Наименование Вида размещения</summary>
		public String AccommodationTypeName
		{
			get { return _accommodationTypeName; }
			set { _accommodationTypeName = value; }
		}
	}
}
