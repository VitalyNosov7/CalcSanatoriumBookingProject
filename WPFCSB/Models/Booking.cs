namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о бронировании</summary>
	public class Booking
	{
		/// <summary>Идентификатор бронирования</summary>
		private Int32 _bookingID = default;
		/// <summary>Идентификатор бронирования</summary>
		public Int32 BookingID
		{
			get { return _bookingID; }
			set { _bookingID = value; }
		}

		/// <summary>Дата создания бронирования</summary>
		private DateTime _createDate = default;
		/// <summary>Дата создания бронирования</summary>
		public DateTime CreateDate
		{
			get { return _createDate; }
			set { _createDate = value; }
		}

		/// <summary>Дата начала бронирования</summary>
		private DateTime _startDate = default;
		/// <summary>Дата начала бронирования</summary>
		public DateTime StartDate
		{
			get { return _startDate; }
			set { _startDate = value; }
		}

		/// <summary>Дата окончания бронирования</summary>
		private DateTime _endDate = default;
		/// <summary>Дата окончания бронирования</summary>
		public DateTime EndDate
		{
			get { return _endDate; }
			set { _endDate = value; }
		}

		/// <summary>Список с данными о расчете бронирования по текущему бронированию</summary>
		private List<CalcBookingData> _calcBookingList = null!;
		/// <summary>Список с данными о расчете бронирования по текущему бронированию</summary>
		public List<CalcBookingData> CalcBookingList
		{
			get { return _calcBookingList; }
			set { _calcBookingList = value; }
		}

		/// <summary>Список с данными о расчете  дополнительных услугаъ(товарах) по текущему бронированию</summary>
		private List<CalcAdditionalServiceData> _calcAdditionalServiceList = null!;
		/// <summary>Список с данными о расчете  дополнительных услугаъ(товарах) по текущему бронированию</summary>
		public List<CalcAdditionalServiceData> CalcAdditionalServiceList
		{
			get { return _calcAdditionalServiceList; }
			set { _calcAdditionalServiceList = value; }
		}

		/// <summary>Гость текущего бронирования</summary>
		private Guest _currentBookingGuest = null!;
		/// <summary>Гость текущего бронирования</summary>
		public Guest CurrentBookingGuest
		{
			get { return _currentBookingGuest; }
			set { _currentBookingGuest = value; }
		}


		/// <summary>Стоимость бронирования для гостей</summary>
		private Decimal _priceFromGuest = default;
		/// <summary>Стоимость бронирования для гостей</summary>
		public Decimal PriceFromGuest
		{
			get { return _priceFromGuest; }
			set { _priceFromGuest = value; }
		}

		/// <summary>Расчет стоимости бронирования для гостей(в виде строки)</summary>
		private String _calcBookingCostFromGuest = String.Empty;
		/// <summary>Расчет стоимости бронирования для гостей(в виде строки)</summary>
		public String CalcBookingCostFromGuest
		{
			get { return _calcBookingCostFromGuest; }
			set { _calcBookingCostFromGuest = value; }
		}

		/// <summary>Стоимость бронирования для санатория</summary>
		private Decimal _priceFromSanatorium = default;
		/// <summary>Стоимость бронирования для санатория</summary>
		public Decimal PriceFromSanatorium
		{
			get { return _priceFromSanatorium; }
			set { _priceFromSanatorium = value; }
		}

		/// <summary>Расчет стоимости бронирования для санатория(в виде строки)</summary>
		private String _calcBookingCostFromSanatorium = String.Empty;
		/// <summary>Расчет стоимости бронирования для санатория(в виде строки)</summary>
		public String CalcBookingCostFromSanatorium
		{
			get { return _calcBookingCostFromSanatorium; }
			set { _calcBookingCostFromSanatorium = value; }
		}
	}
}
