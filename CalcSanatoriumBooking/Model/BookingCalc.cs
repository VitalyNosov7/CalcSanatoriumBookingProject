
namespace CalcSanatoriumBooking.Model
{
	/// <summary>	Расчет стоимости бронирования.	</summary>
    public class BookingCalc : BookingCalcID
	{
        //	TODO:	Разработать алгоритм, в котором будет производиться расчет из данных списка  List<CalcAction>

        /// <summary>   Расчет стоимости бронирования.    </summary>
        private Decimal _bookingCost = default;

		/// <summary>   Расчет стоимости бронирования.    </summary>
		public Decimal BookingCost
		{
			get { return _bookingCost; }
			set { _bookingCost = value; }
		}

		/// <summary>   Строковое представление расчета стоимости бронирования.    </summary>
		private String _bookingCostToString = String.Empty;

		/// <summary>   Строковое представление расчета стоимости бронирования.    </summary>
		public String BookingCostToString
		{
			get { return _bookingCostToString; }
			set { _bookingCostToString = value; }
		}

		//	TODO:	Оставить  поле List<CalcAction> только для чтения, а свойство убрать?


		/// <summary>	Текущие операции расчета.	</summary>
		private List<CalcAction>? _currentCalcActionList = default;

		/// <summary>	Текущие операции расчета.	</summary>
		public List<CalcAction> CurrentCalcActionList
		{
			get { return _currentCalcActionList!; }
			set { _currentCalcActionList = value; }
		}


		// Получить стоимость бронирования.
		public Decimal GetCostBooking()
		{
			Decimal result = default;

			//	TODO:	

			return result;
		}
	}
}
