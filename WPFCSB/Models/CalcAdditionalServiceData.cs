namespace WPFCSB.Models
{
	/// <summary>Класс содержит данные о расчете дополнительной услуге(товаре) при бронировании путевки</summary>
	public class CalcAdditionalServiceData
	{
		/// <summary>Идентификатор данных о расчете дополнительной услуге, товаре при бронировании путевки</summary>
		private Int32 _calcAdditionalServiceDataID;
		/// <summary>Идентификатор данных о расчете дополнительной услуге, товаре при бронировании путевки</summary>
		public Int32 CalcAdditionalServiceDataID
		{
			get { return _calcAdditionalServiceDataID; }
			set { _calcAdditionalServiceDataID = value; }
		}

		// Порядковый номер бронирования в данном случае означает, что бронирование с этим номером в дальнейшем будет иметь разный статус(новая бронь, коррекция и т.п.)
		/// <summary>Порядковый номер бронирования(НЕ идентификатор!)</summary>
		private Int32 _bookingNumber = default;
		/// <summary>Порядковый номер бронирования(НЕ идентификатор!)</summary>
		public Int32 BookingNumber
		{
			get { return _bookingNumber; }
			set { _bookingNumber = value; }
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
