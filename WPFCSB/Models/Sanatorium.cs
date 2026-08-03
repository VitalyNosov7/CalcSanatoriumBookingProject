namespace WPFCSB.Models
{
	/// <summary>   Санаторий.  </summary>
	public class Sanatorium
	{
		public Sanatorium(Int32 sanatoriumID, String sanatoriumName)
		{
			SanatoriumID = sanatoriumID;
			SanatoriumName = sanatoriumName;
		}

		public Sanatorium()	{}

		/// <summary>   Идентификатор санатория.    </summary>
		private Int32 _sanatoriumID = default;

		/// <summary>   Идентификатор санатория.    </summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>   Название санатория.    </summary>
		private String _sanatoriumName = String.Empty;

		/// <summary>   Название санатория.    </summary>
		public String SanatoriumName
		{
			get { return _sanatoriumName; }
			set { _sanatoriumName = value; }
		}

        /// <summary> Электронная почта санатория.</summary>
        private String _emailSanatorium = String.Empty;
        /// <summary> Электронная почта санатория.</summary>
        public String EmailSanatorium
        {
			get { return _emailSanatorium ; }
			set { _emailSanatorium = value; }
		}

	}
}
