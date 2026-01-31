

namespace CalcSanatoriumBooking.Model
{
	/// <summary>	Расчет стоимости бронирования.	</summary>
    public class BookingCalc : BookingCalcID
	{
		/// <summary>   Расчет стоимости бронирования.    </summary>
		private Decimal _bookingCost = default;

		/// <summary>   Расчет стоимости бронирования.    </summary>
		public Decimal BookingCost
		{
			get => _bookingCost;
			set => _bookingCost = value;
		}

		/// <summary>   Строковое представление расчета стоимости бронирования.    </summary>
		private String _bookingCostToString = String.Empty;

		/// <summary>   Строковое представление расчета стоимости бронирования.    </summary>
		public String BookingCostToString
		{
			get => _bookingCostToString;
			set => _bookingCostToString = value;
		}

		/// <summary>	Текущие операции расчета.	</summary>
		private List<CalcAction>? _currentCalcActionList = default;

		/// <summary>	Текущие операции расчета.	</summary>
		public List<CalcAction> CurrentCalcActionList
		{
			get => _currentCalcActionList!;
			set => _currentCalcActionList = value;
		}


		// Получить стоимость бронирования.
		public Decimal GetCostBooking()
		{
			Decimal result = default;
			return result;
		}
	}
}
