
using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
	/// <summary>	Конструктор расчета бронирования.	</summary>
    public class BookingCalcConstructor : BookingCalcID
	{
		//	TODO:	разработать в этом классе алгоритм сборки расчета используя классы:
		//			(CalcShapes ?); CalcAction; CalcOperation; BookingPeriod
		//			В этом классе будет собираться расчет (в определенном порядке) и записываться в List<CalcAction>
		//			м затем для окончательного расчета будет передаваться в класс BookimgCalc

		/// <summary>	Текущие операции расчета.	</summary>
		private List<CalcAction>? _currentCalcActionList = default;

		/// <summary>	Текущие операции расчета.	</summary>
		public List<CalcAction> CurrentCalcActionList
		{
			get => _currentCalcActionList!;
			set => _currentCalcActionList = value;
		}

		/// <summary>	Добавить очередной , текущий расчет в список.	</summary>
		public void AddCurrentCalcAction(Int32 currentСalcId,
											  Int32 currentSerialNumberCalc,
											  Int32 currentOperandA,
											  Int32 currentOperandB,
											  MathOperation currentMathOperation)
		{
			try
			{
				CalcAction currentCalcAction = new CalcAction(currentСalcId,
																   currentSerialNumberCalc,
																   currentOperandA,
																   currentOperandB,
																   currentMathOperation);
				CurrentCalcActionList.Add(currentCalcAction);

			}
			catch (Exception) { }
		}
	}
}
