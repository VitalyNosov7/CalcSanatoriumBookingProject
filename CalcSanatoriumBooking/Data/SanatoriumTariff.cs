namespace CalcSanatoriumBooking.Data
{
	/// <summary>Тариф санатория(с лечением, без лечения, климатолечение, оздоровление)</summary>
	public class SanatoriumTariff
	{
		public SanatoriumTariff(Int32 sanatoriumTariffID, Int32 sanatoriumID, String _sanatoriumTariffName)
		{
			SanatoriumTariffID = sanatoriumTariffID;
			SanatoriumID = sanatoriumID;
			SanatoriumTariffName = _sanatoriumTariffName;
		}

		/// <summary>Идентификатор Тарифа санатория</summary>
		private Int32 _sanatoriumTariffID;

		/// <summary>Идентификатор Тарифа санатория</summary>
		public Int32 SanatoriumTariffID
		{
			get { return _sanatoriumTariffID; }
			set { _sanatoriumTariffID = value; }
		}

		/// <summary>   Идентификатор санатория.    </summary>
		private Int32 _sanatoriumID = default;

		/// <summary>   Идентификатор санатория.    </summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Наименование Тарифа санатория</summary>
		private String _sanatoriumTariffName = String.Empty;

		/// <summary>Наименование Тарифа санатория</summary>
		public String SanatoriumTariffName
		{
			get { return _sanatoriumTariffName; }
			set { _sanatoriumTariffName = value; }
		}
	}
}
