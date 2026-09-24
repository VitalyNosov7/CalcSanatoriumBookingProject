namespace WPFCSB.Models
{
	/// <summary>Класс содержит данные о расчете бронирования</summary>
	public class CalcBookingData
	{
		/// <summary>Идентификатор данных о расчете бронирования</summary>
		private Int32 _calcBookingDataID = default;
		/// <summary>Идентификатор данных о расчете бронирования</summary>
		public Int32 CalcBookingDataID
		{
			get { return _calcBookingDataID; }
			set { _calcBookingDataID = value; }
		}

		/// <summary>Идентификатор бронирования</summary>
		private Int32 _bookingID = default;
		/// <summary>Идентификатор бронирования</summary>
		public Int32 BookingID
		{
			get { return _bookingID; }
			set { _bookingID = value; }
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

		/// <summary>Переходящая дата  бронирования</summary>
		private DateTime _pivotDate = default;
		/// <summary>Переходящая дата  бронирования</summary>
		public DateTime PivotDate
		{
			get { return _pivotDate; }
			set { _pivotDate = value; }
		}

		/// <summary>Идентификатор гостя</summary>
		private Int32 _guestID = default;
		/// <summary>Идентификатор гостя</summary>
		public Int32 GuestID
		{
			get { return _guestID; }
			set { _guestID = value; }
		}

		/// <summary>Гость</summary>
		private Guest _currentGuest = null!;
		/// <summary>Гость</summary>
		public Guest CurrentGuest
		{
			get { return _currentGuest; }
			set { _currentGuest = value; }
		}

		/// <summary>Основной гость(на которого оформляется бронь)</summary>
		private Boolean _guestWhoOrdering = false;
		/// <summary>Основной гость(на которого оформляется бронь)</summary>
		public Boolean GuestWhoOrdering
		{
			get { return _guestWhoOrdering; }
			set { _guestWhoOrdering = value; }
		}


		/// <summary>Идентификатор санатория</summary>
		private Int32 _sanatoriumID = default;
		/// <summary>Идентификатор санатория</summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Санаторий</summary>
		private Sanatorium _currentSanatorium = null!;
		/// <summary>Санаторий</summary>
		public Sanatorium CurrentSanatorium
		{
			get { return _currentSanatorium; }
			set { _currentSanatorium = value; }
		}

		/// <summary>Идентификатор категории номера</summary>
		private Int32 _roomCategoryID = default;
		/// <summary>Идентификатор категории номера</summary>
		public Int32 RoomCategoryID
		{
			get { return _roomCategoryID; }
			set { _roomCategoryID = value; }
		}

		/// <summary>Категория номера</summary>
		private RoomCategory _currentRoomCategory = null!;
		/// <summary>Категория номера</summary>
		public RoomCategory CurrentRoomCategory
		{
			get { return _currentRoomCategory; }
			set { _currentRoomCategory = value; }
		}

		/// <summary>Идентификатор вида размещения</summary>
		private Int32 _accommodationTypeID = default;
		/// <summary>Идентификатор вида размещения</summary>
		public Int32 AccommodationTypeID
		{
			get { return _accommodationTypeID; }
			set { _accommodationTypeID = value; }
		}

		/// <summary>Вид размещения/summary>
		private AccommodationType _currentAccommodationType = null!;
		/// <summary>Вид размещения/summary>
		public AccommodationType CurrentAccommodationType
		{
			get { return _currentAccommodationType; }
			set { _currentAccommodationType = value; }
		}

		/// <summary>Идентификатор категории тарифа/summary>
		private Int32 _tarifCategoryID = default;
		/// <summary>Идентификатор категории тарифа/summary>
		public Int32 TarifCategoryID
		{
			get { return _tarifCategoryID; }
			set { _tarifCategoryID = value; }
		}

		/// <summary>Категория тарифа/summary>
		private TarifCategory _currentTarifCategory = null!;
		/// <summary>Категория тарифа/summary>
		public TarifCategory CurrentTarifCategory
		{
			get { return _currentTarifCategory; }
			set { _currentTarifCategory = value; }
		}

		/// <summary>Стоимость бронирования для гостей</summary>
		private Decimal _priceFromGuest = default;
		/// <summary>Стоимость бронирования для гостей</summary>
		public Decimal PriceFromGuest
		{
			get { return _priceFromGuest; }
			set { _priceFromGuest = value; }
		}


		/// <summary>Результат расчета бронирования для гостей</summary>
		private Decimal _calcResultFromGuest = default;
		/// <summary>Результат расчета бронирования для гостей</summary>
		public Decimal CalcResultFromGuest
		{
			get { return _calcResultFromGuest; }
			set { _calcResultFromGuest = value; }
		}

		/// <summary>Результат расчета бронирования в виде строки для гостей</summary>
		private String _calcResultFromGuestToString = String.Empty;
		/// <summary>Результат расчета бронирования в виде строки для гостей</summary>
		public String CalcResultFromGuestToString
		{
			get { return _calcResultFromGuestToString; }
			set { _calcResultFromGuestToString = value; }
		}

		/// <summary>Стоимость бронирования для санатория</summary>
		private Decimal _priceFromSanatorium = default;
		/// <summary>Стоимость бронирования для санатория</summary>
		public Decimal PriceFromSanatorium
		{
			get { return _priceFromSanatorium; }
			set { _priceFromSanatorium = value; }
		}

		/// <summary>Результат расчета бронирования для санатория</summary>
		private Decimal _calcResultFromSanatorium = default;
		/// <summary>Результат расчета бронирования для санатория</summary>
		public Decimal CalcResultFromSanatorium
		{
			get { return _calcResultFromSanatorium; }
			set { _calcResultFromSanatorium = value; }
		}

		/// <summary>Результат расчета бронирования в виде строки для санатория</summary>
		private String _calcResultFromSanatoriumToString = String.Empty;
		/// <summary>Результат расчета бронирования в виде строки для санатория</summary>
		public String CalcResultFromSanatoriumToString
		{
			get { return _calcResultFromSanatoriumToString; }
			set { _calcResultFromSanatoriumToString = value; }
		}
	}
}
