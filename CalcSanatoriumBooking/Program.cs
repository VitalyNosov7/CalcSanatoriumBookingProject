using CalcSanatoriumBooking.Model;
using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет стоимости путевки в санаторий");

            CalcBookingCost currentCalcBookingCost = new CalcBookingCost();
            Int32 opA = 20;
			Int32 opB = 0;
            Console.WriteLine($"Результат = {currentCalcBookingCost.PerformCalc(opA, opB,MathOperation.Divide)}"); 

		}
    }
}
