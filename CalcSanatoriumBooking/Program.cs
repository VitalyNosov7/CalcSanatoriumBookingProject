using CalcSanatoriumBooking.Resources;


namespace CalcSanatoriumBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчет стоимости путевки в санаторий");
            DateTime DefaultDateTime = default;
            Console.WriteLine($"Дата по умолчанию равна: {DefaultDateTime}");
            Gender gender = default;
            Console.WriteLine($"Пол по умолчанию равна: {gender}");


            //         CalcBookingCost currentCalcBookingCost = new CalcBookingCost();
            //         Int32 opA = 20;
            //Int32 opB = 0;
            //         Console.WriteLine($"Результат = {currentCalcBookingCost.PerformCalc(opA, opB,MathOperation.Divide)}"); 

        }
    }
}
