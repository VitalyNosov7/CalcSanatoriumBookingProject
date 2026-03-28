
namespace CalcSanatoriumBooking.Data
{
	//	TODO:	Подумать, нужен ли этот класс?

	//	В этом классе хранится информация о правиле(условии) расчета бронирования.
	
	/// <summary>Правило(условие) расчета бронирования</summary>
	public class RuleBookingCalc
	{
		/// <summary>Идентификационный номер правила расчета бронирования</summary>
		private int _ruleBookingCalcID;

		/// <summary>Идентификационный номер правила расчета бронирования</summary>
		public int RuleBookingCalcID
		{
			get { return _ruleBookingCalcID; }
			set { _ruleBookingCalcID = value; }
		}


		private int _amountGuests;

		public int AmountGuests
		{
			get { return _amountGuests; }
			set { _amountGuests = value; }
		}

	}
}
