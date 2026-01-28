using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
	//	TODO:	Переименовать класс, чтобы было понятно его назначение!
	/// <summary>   
	///     В этом классе  формирунтся данные о порядке расчета бронирования.
	///     Далее эти данные передаются в класс CalcBookingCost для окончательного расчета.
	/// </summary>
	public class BookingCalcConstructor
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

		/// <summary>	Текущие операции расчета.	</summary>
		private List<CalcTransaction>? _currentCalcTransactionList = default;

		/// <summary>	Текущие операции расчета.	</summary>
		public List<CalcTransaction> CurrentCalcTransactionList
		{
			get => _currentCalcTransactionList!;
			set => _currentCalcTransactionList = value;
		}

		/// <summary>	Добавить очередной , текущий расчет в список.	</summary>
		public void AddCurrentCalcTransaction(	Int32 currentTransactionId,
												Int32 nextCalcNumber,
												Int32 currentOperandA,
												Int32 currentOperandB,
												MathOperation currentMathOperation)
		{
			try
			{
				CalcTransaction currentCalcTransaction = new CalcTransaction(	currentTransactionId,
																							nextCalcNumber,
																							currentOperandA,
																							currentOperandB,
																							currentMathOperation);
				CurrentCalcTransactionList.Add(currentCalcTransaction);
				
			}
			catch (Exception) { }
		}
	}
}

