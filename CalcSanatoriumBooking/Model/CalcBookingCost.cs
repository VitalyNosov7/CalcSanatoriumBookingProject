using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
	/// <summary>   Расчет стоимости путевки в санаторий.   </summary>
	public class CalcBookingCost
	{

		/// <summary>	
		///		Идентификатор транзакции.
		///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
		///	</summary>
		private Int32 _calcId = default;

		/// <summary>	
		///		Идентификатор транзакции.
		///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
		///	</summary>
		public Int32 СalcId
        {
			get => _calcId;
			set => _calcId = value;
		}

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

		public CalcBookingCost(List<CalcAction> currentCalcActionList)
		{
            CurrentCalcActionList = currentCalcActionList;

		}


		/// <summary>	Вызов математических операций.	</summary>
		/// <param name="operandA">	Операнд А	</param>
		/// <param name="operandB">	Операнд В	</param>
		/// <param name="mathOperator">	Математическая операция	</param>
		public Int32 PerformCalc(Int32 operandA, Int32 operandB, MathOperation mathOperator)
		{
			Int32 result = default;
			try
			{
				switch (mathOperator)
				{
					case MathOperation.Add:
						result = Add(operandA, operandB);
						break;
					case MathOperation.Subtract:
						result = Subtract(operandA, operandB);
						break;
					case MathOperation.Multiply:
						result = Multiply(operandA, operandB);
						break;
					case MathOperation.Divide:
						result = Divide(operandA, operandB);
						break;
						//result = mathOperator switch
						//{
						//	MathOperation.Add => operandA + operandB,
						//	MathOperation.Subtract => operandA - operandB,
						//	MathOperation.Multiply => operandA * operandB,
						//	MathOperation.Divide => operandA / operandB
						//};			
				}
			}
			catch (Exception) { }
			return result;
		}

		/// <summary>	Вызов математической операции сложения.	</summary>
		/// <param name="operandA">	Операнд А	</param>
		/// <param name="operandB">	Операнд В	</param>
		/// <returns>	Возвращает результат сложения типа Int32	</returns>
		private Int32 Add(Int32 operandA, Int32 operandB)
		{
			Int32 result = default;
			result = operandA + operandB;
			return result;
		}

		/// <summary>	Вызов математической операции вычитания.	</summary>
		/// <param name="operandA">	Операнд А	</param>
		/// <param name="operandB">	Операнд В	</param>
		/// <returns>	Возвращает результат вычитания типа Int32	</returns>
		private Int32 Subtract(Int32 operandA, Int32 operandB)
		{
			Int32 result = default;
			result = operandA - operandB;
			return result;
		}

		/// <summary>	Вызов математической операции умножения.	</summary>
		/// <param name="operandA">	Операнд А	</param>
		/// <param name="operandB">	Операнд В	</param>
		/// <returns>	Возвращает результат умножения типа Int32	</returns>
		private Int32 Multiply(Int32 operandA, Int32 operandB)
		{
			Int32 result = default;
			result = operandA * operandB;
			return result;
		}

		/// <summary>	Вызов математической операции деления.	</summary>
		/// <param name="operandA">	Операнд А	</param>
		/// <param name="operandB">	Операнд В	</param>
		/// <returns>	Возвращает результат деления типа Int32	</returns>
		private Int32 Divide(Int32 operandA, Int32 operandB)
		{
			Int32 result = default;
			result = operandA / operandB;
			return result;
		}

		// Получить стоимость бронирования.
		public Decimal GetCostBooking()
		{
			Decimal result = default;
			return result;
		}
	}
}
