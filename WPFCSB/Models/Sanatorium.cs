namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о санатории</summary>
	public class Sanatorium
	{
		/// <summary>Инициализация санатория с тремя параметрами</summary>
		/// <param name="sanatoriumID">Идентификатор санатория</param>
		/// <param name="sanatoriumName">Название санатория</param>
		/// <param name="emailSanatorium">Электронный адрес санатория</param>
		public Sanatorium(Int32 sanatoriumID, String sanatoriumName, String emailSanatorium)
		{
			SanatoriumID = sanatoriumID;
			SanatoriumName = sanatoriumName;
			EmailSanatorium = emailSanatorium;
		}

		/// <summary>Инициализация санатория с тремя параметрами</summary>
		/// <param name="sanatoriumName">Название санатория</param>
		/// <param name="emailSanatorium">Электронный адрес санатория</param>
		public Sanatorium( String sanatoriumName, String emailSanatorium)
		{
			SanatoriumName = sanatoriumName;
			EmailSanatorium = emailSanatorium;
		}

		/// <summary>Инициализация санатория без параметров</summary>
		public Sanatorium()	{}

		/// <summary>Идентификатор санатория</summary>
		private Int32 _sanatoriumID = default;

		/// <summary>Идентификатор санатория</summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Название санатория</summary>
		private String _sanatoriumName = String.Empty;

		/// <summary>Название санатория</summary>
		public String SanatoriumName
		{
			get { return _sanatoriumName; }
			set { _sanatoriumName = value; }
		}

        /// <summary> Электронная почта санатория</summary>
        private String _emailSanatorium = String.Empty;
        /// <summary> Электронная почта санатория</summary>
        public String EmailSanatorium
        {
			get { return _emailSanatorium ; }
			set { _emailSanatorium = value; }
		}
	}
}
