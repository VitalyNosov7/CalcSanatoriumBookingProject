namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о платежах за бронироване между лицами</summary>
	public class Payment
	{
		/// <summary>Идентификатор платежа за бронироване между лицами</summary>
		private Int32 _paymentID = default;
		/// <summary>Идентификатор платежа за бронироване между лицами</summary>
		public Int32 PaymentID
		{
			get { return _paymentID; }
			set { _paymentID = value; }
		}

		/// <summary>Идентификатор бронирования</summary>
		private Int32 _bookingID = default;
		/// <summary>Идентификатор бронирования</summary>
		public Int32 BookingID
		{
			get { return _bookingID; }
			set { _bookingID = value; }
		}

		/// <summary>Дата платежа за бронирования</summary>
		private DateTime _paymentDate = default;
		/// <summary>Дата начала бронирования</summary>
		public DateTime PaymentDate
		{
			get { return _paymentDate; }
			set { _paymentDate = value; }
		}

		/// <summary>Сумма платежа за бронирования</summary>
		private Decimal _paymentAmount;
		/// <summary>Сумма платежа за бронирования</summary>
		public Decimal PaymentAmount
		{
			get { return _paymentAmount; }
			set { _paymentAmount = value; }
		}

		/// <summary>Идентификатор валюты платежа за бронирования</summary>
		private Int32 _paymentCurrencyID = default;
		/// <summary>Идентификатор валюты платежа за бронирования</summary>
		public Int32 PaymentCurrencyID
		{
			get { return _paymentCurrencyID; }
			set { _paymentCurrencyID = value; }
		}
	}
}
