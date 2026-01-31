using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
	/// <summary>   Операция расчета.   </summary>
	public class CalcOperation : BookingCalcID
	{
		/// <summary>	Вызов математических операций(+ - * /).	</summary>
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
	}
}
