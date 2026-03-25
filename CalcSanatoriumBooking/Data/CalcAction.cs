using CalcSanatoriumBooking.Model;
using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Data
{
    /// <summary>
    ///     Текущая операция расчета.
    ///     Из экземпляров этого класса формируется окончательный порядок расчета бронирования.   
    /// </summary>
    public class CalcAction : BookingCalcID
    {
        /// <summary>   Номер группы расчета.   </summary>
        private Int32 _groupNumberCalc = default;

        /// <summary>   Номер группы расчета.   </summary>
        public Int32 GroupNumberCalc
        {
            get { return _groupNumberCalc; }
            set { _groupNumberCalc = value; }
        }

        /// <summary>	Очередной, порядковый номер, расчета. </summary>
        private Int32 _serialNumberCalc = default;

        /// <summary>	Очередной, порядковый номер, расчета. </summary>
        public Int32 SerialNumberCalc
        {
            get { return _serialNumberCalc; }
            set { _serialNumberCalc = value; }
        }

        /// <summary>	Первый операнд. </summary>
        private Int32 _operandA = default;

        /// <summary>	Первый операнд. </summary>
        public Int32 OperandA
        {
            get { return _operandA; }
            set { _operandA = value; }
        }

        /// <summary>	Второй операнд. </summary>
        private Int32 _operandB = default;

        /// <summary>	Второй операнд. </summary>
        public Int32 OperandB
        {
            get { return _operandB; }
            set { _operandB = value; }
        }

        /// <summary>	Результат текущего расчета. </summary>
        private Int32 _resultCurrentCalc = default;

        /// <summary>	Результат текущего расчета. </summary>
        public Int32 ResultCurrentCalc
        {
            get { return _resultCurrentCalc; }
            set { _resultCurrentCalc = value; }
        }

        /// <summary>	Текущая математическая операция. </summary>
        private MathOperation _currentMathOperation = default;

        /// <summary>	Текущая математическая операция. </summary>
        public MathOperation CurrentMathOperation
        {
            get { return _currentMathOperation; }
            set { _currentMathOperation = value; }
        }

        public CalcAction(Int32 currentСalcId
                            , Int32 groupNumberCalc
                            , Int32 serialNumberCalc
                            , Int32 currentOperandA
                            , Int32 currentOperandB
                            , MathOperation currentMathOperation)
        {
            СalcId = currentСalcId;
            GroupNumberCalc = groupNumberCalc;
            SerialNumberCalc = serialNumberCalc;
            OperandA = currentOperandA;
            OperandB = currentOperandB;
            CurrentMathOperation = currentMathOperation;
        }
    }
}
