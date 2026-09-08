namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о виде размещения(одноместное, двухместное, доп. и т.п.)</summary>
	public class AccommodationType
	{
		/// <summary>Инициализация вида размещения с тремя параметрами</summary>
		/// <param name="accommodationTypeID">Идентификатор вида размещения</param>
		/// <param name="sanatoriumID">Идентификатор санатория</param>
		/// <param name="accommodationTypeName">Наименование вида размещения</param>
		public AccommodationType(Int32 accommodationTypeID, Int32 sanatoriumID, String accommodationTypeName)
		{
			AccommodationTypeID = accommodationTypeID;
			SanatoriumID = sanatoriumID;
			AccommodationTypeName = accommodationTypeName;
		}

		/// <summary>Инициализация вида размещения с двумя параметрами</summary>
		/// <param name="sanatoriumID">Идентификатор санатория</param>
		/// <param name="accommodationTypeName">Наименование вида размещения</param>
		public AccommodationType(Int32 sanatoriumID, String accommodationTypeName)
		{
			SanatoriumID = sanatoriumID;
			AccommodationTypeName = accommodationTypeName;
		}

		/// <summary>Инициализация вида размещения без параметров</summary>
		public AccommodationType() { }

		/// <summary>Идентификатор вида размещения</summary>
		private Int32 _accommodationTypeID;
		/// <summary>Идентификатор вида размещения</summary>
		public Int32 AccommodationTypeID
		{
			get { return _accommodationTypeID; }
			set { _accommodationTypeID = value; }
		}

		/// <summary>Идентификатор санатория</summary>
		private Int32 _sanatoriumID = default;
		/// <summary>Идентификатор санатория</summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Наименование вида размещения</summary>
		private String _accommodationTypeName = String.Empty;
		/// <summary>Наименование вида размещения</summary>
		public String AccommodationTypeName
		{
			get { return _accommodationTypeName; }
			set { _accommodationTypeName = value; }
		}
	}
}
