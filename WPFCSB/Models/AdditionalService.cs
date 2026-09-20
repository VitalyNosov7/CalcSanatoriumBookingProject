namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о дополнительных услугах, товарах при бронировании путевки</summary>
	public class AdditionalService
	{
		/// <summary>Идентификатор дополнительной услуги(товара) при бронирование</summary>
		private Int32 _additionalServiceID = default;
		/// <summary>Идентификатор дополнительной услуги(товара) при бронирование</summary>
		public Int32 AdditionalServiceID
		{
			get { return _additionalServiceID; }
			set { _additionalServiceID = value; }
		}

		/// <summary>Наименование дополнительной услуги(товара) при бронирование</summary>
		private String _additionalServiceName = String.Empty;
		/// <summary>Наименование дополнительной услуги(товара) при бронирование</summary>
		public String AdditionalServiceName
		{
			get { return _additionalServiceName; }
			set { _additionalServiceName = value; }
		}

		/// <summary>Стоимость дополнительной услуги(товара) при бронирование</summary>
		private Decimal _additionalServiceCost = default;
		/// <summary>Стоимость дополнительной услуги(товара) при бронирование</summary>
		public Decimal AdditionalServiceCost
		{
			get { return _additionalServiceCost; }
			set { _additionalServiceCost = value; }
		}

		/// <summary>Дата вступления цены в силу</summary>
		private DateTime _priceEffectiveDate = default;
		/// <summary>Дата вступления цены в силу</summary>
		public DateTime PriceEffectiveDate
		{
			get { return _priceEffectiveDate; }
			set { _priceEffectiveDate = value; }
		}

		/// <summary>Дата начала периода стоимости дополнительной услуги(товара)</summary>
		private DateTime _startDatePeriodPrice = default;
		/// <summary>Дата начала периода стоимости дополнительной услуги(товара)</summary>
		public DateTime StartDatePeriodPrice
		{
			get { return _startDatePeriodPrice; }
			set { _startDatePeriodPrice = value; }
		}

		/// <summary>Дата окончания периода стоимости дополнительной услуги(товара)</summary>
		private DateTime _endDatePeriodPrice = default;
		/// <summary>Дата окончания периода стоимости дополнительной услуги(товара)</summary>
		public DateTime EndDatePeriodPrice
		{
			get { return _endDatePeriodPrice; }
			set { _endDatePeriodPrice = value; }
		}



	}
}
