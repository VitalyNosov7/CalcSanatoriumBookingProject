namespace CalcSanatoriumBooking.Data
{
    /// <summary>Тариф санатория(с лечением, без лечения, климатолечение, оздоровление)</summary>
    public class SanatoriumTariff
    {
		/// <summary>Идентификатор Тарифа санатория</summary>
		private Int32 _idSanatoriumTariff;

		/// <summary>Идентификатор Тарифа санатория</summary>
		public Int32 IdSanatoriumTariff
		{
			get { return _idSanatoriumTariff; }
			set { _idSanatoriumTariff = value; }
		}

		/// <summary>Наименование Тарифа санатория</summary>
		private String _nameSanatoriumTariff = String.Empty;

		/// <summary>Наименование Тарифа санатория</summary>
		public String NameSanatoriumTariff
		{
			get { return _nameSanatoriumTariff; }
			set { _nameSanatoriumTariff = value; }
		}
	}
}
