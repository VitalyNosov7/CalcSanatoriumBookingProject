
using CalcSanatoriumBooking.Data;
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


		public BookingCalcConstructor(Int32 calcId)
		{
			СalcId = calcId;
		}

		/// <summary>   Данные бронирования.    </summary>
		private BookingDetails? _currentBookingDetails = default;

		/// <summary>   Данные бронирования.    </summary>
		public BookingDetails CurrentBookingDetails
		{
			get { return _currentBookingDetails!; }
			set { _currentBookingDetails = value; }
		}

		/// <summary>	Текущие операции расчета.	</summary>
		private List<CalcAction>? _currentCalcActionList = default;

		/// <summary>	Текущие операции расчета.	</summary>
		public List<CalcAction> CurrentCalcActionList
		{
			get { return _currentCalcActionList!; }
			set { _currentCalcActionList = value; }
		}



		/// <summary>	Создать(добавить) очередной , текущий расчет в список List<CalcAction>.	</summary>
		public void CreateCurrentCalcAction(Int32 currentСalcId
											  , Int32 currentSerialNumberCalc
											  , Int32 currentOperandA
											  , Int32 currentOperandB
											  , MathOperation currentMathOperation)
		{
			try
			{
				CalcAction currentCalcAction = new CalcAction(currentСalcId
															  , currentSerialNumberCalc
															  , currentOperandA
															  , currentOperandB
															  , currentMathOperation);
				CurrentCalcActionList.Add(currentCalcAction);

			}
			catch (Exception) { }
		}

		/// <summary>	Прочитать(получиль)  расчет из списка List<CalcAction>.	</summary>
		public void ReadCurrentCalcAction(Int32 itemNumber)
		{

		}

		/// <summary>	Редактировать(изменить)  расчет из списка List<CalcAction>.	</summary>
		public void UpdateCurrentCalcAction(Int32 itemNumber)
		{

		}

		/// <summary>	Удалить  расчет из списка List<CalcAction>.	</summary>
		public void DeleteCurrentCalcAction(Int32 itemNumber)
		{

		}

	}
}
