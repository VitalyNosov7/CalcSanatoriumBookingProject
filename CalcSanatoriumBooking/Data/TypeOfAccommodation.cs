namespace CalcSanatoriumBooking.Data
{
    /// <summary>Вид размещения</summary>
    public class TypeOfAccommodation
    {
		/// <summary>Идентификатор Вида размещения</summary>
		private Int32 _idTypeOfAccommodation;

		/// <summary>Идентификатор Вида размещения</summary>
		public Int32 IdTypeOfAccommodation
		{
			get { return _idTypeOfAccommodation; }
			set { _idTypeOfAccommodation = value; }
		}

		/// <summary>Наименование Вида размещения</summary>
		private String _nameTypeOfAccommodation = String.Empty;

		/// <summary>Наименование Вида размещения</summary>
		public String NameTypeOfAccommodation
		{
			get { return _nameTypeOfAccommodation; }
			set { _nameTypeOfAccommodation = value; }
		}
	}
}
