using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{

    /// <summary>   
    ///     В этом классе  формирунтся данные о порядке расчета бронирования.
    ///     Далее эти данные передаются в класс CalcBookingCost для окончательного расчета.
    /// </summary>
    public class BookingCalcConstructor
    {
        /// <summary>	
        ///		Идентификатор расчета.
        ///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
        ///	</summary>
        private Int32 _calcId = default;

        /// <summary>	
        ///		Идентификатор расчета.
        ///		Все идентификаторы с одинаковым значением, относятся к одному расчету.	
        ///	</summary>
        public Int32 СalcId
        {
            get => _calcId;
            set => _calcId = value;
        }

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

