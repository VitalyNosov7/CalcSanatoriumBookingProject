using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
	/// <summary>
	///     Текущая операция расчета.
	///     Из экземпляров этого класса формируется окончательный расчет бронирования.   
	/// </summary>
	public class CalcTransaction
	{
		/// <summary>	
		///		Идентификатор транзакции.
		///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
		///	</summary>
		private Int32 _transactionId = default;

		/// <summary>	
		///		Идентификатор транзакции.
		///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
		///	</summary>
		public Int32 TransactionId
		{
			get => _transactionId;
			set => _transactionId = value;
		}

		/// <summary>	Очередной, порядковый номер, расчета. </summary>
		private Int32 _nextCalcNumber = default;

		/// <summary>	Очередной, порядковый номер, расчета. </summary>
		public Int32 NextCalcNumber
		{
			get => _nextCalcNumber;
			set => _nextCalcNumber = value;
		}

		/// <summary>	Первый операнд. </summary>
		private Int32 _operandA = default;

		/// <summary>	Первый операнд. </summary>
		public Int32 OperandA
		{
			get => _operandA;
			set => _operandA = value;
		}

		/// <summary>	Второй операнд. </summary>
		private Int32 _operandB = default;

		/// <summary>	Второй операнд. </summary>
		public Int32 OperandB
		{
			get => _operandB;
			set => _operandB = value;
		}

		/// <summary>	Результат текущего расчета. </summary>
		private Int32 _resultCurrentCalc = default;

		/// <summary>	Результат текущего расчета. </summary>
		public Int32 ResultCurrentCalc
		{
			get => _resultCurrentCalc;
			set => _resultCurrentCalc = value;
		}

		/// <summary>	Текущая математическая операция. </summary>
		private MathOperation _currentMathOperation = default;

		/// <summary>	Текущая математическая операция. </summary>
		public MathOperation CurrentMathOperation
		{
			get => _currentMathOperation;
			set => _currentMathOperation = value;
		}

		public CalcTransaction(Int32 currentTransactionId,
										Int32 nextCalcNumber,
										Int32 currentOperandA,
										Int32 currentOperandB,
										MathOperation currentMathOperation)
		{
			TransactionId = currentTransactionId;
			NextCalcNumber = nextCalcNumber;
			OperandA = currentOperandA;
			OperandB = currentOperandB;
			CurrentMathOperation = currentMathOperation;
		}
	}
}
