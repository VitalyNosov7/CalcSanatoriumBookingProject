namespace WPFCSB.Models
{
	/// <summary>Класс содержит данные о расчете дополнительной услуги(товаре) при бронировании путевки</summary>
	public class CalcAdditionalServiceData
	{
		/// <summary>Идентификатор данных о расчете дополнительной услуги, товаре при бронировании путевки</summary>
		private Int32 _calcAdditionalServiceDataID;
		/// <summary>Идентификатор данных о расчете дополнительной услуги, товаре при бронировании путевки</summary>
		public Int32 CalcAdditionalServiceDataID
		{
			get { return _calcAdditionalServiceDataID; }
			set { _calcAdditionalServiceDataID = value; }
		}

		/// <summary>Идентификатор бронирования</summary>
		private Int32 _bookingID = default;
		/// <summary>Идентификатор бронирования</summary>
		public Int32 BookingID
		{
			get { return _bookingID; }
			set { _bookingID = value; }
		}

		/// <summary>Идентификатор дополнительной услуги(товара) при бронирование</summary>
		private Int32 _additionalServiceID = default;
		/// <summary>Идентификатор дополнительной услуги(товара) при бронирование</summary>
		public Int32 AdditionalServiceID
		{
			get { return _additionalServiceID; }
			set { _additionalServiceID = value; }
		}

	}
}
