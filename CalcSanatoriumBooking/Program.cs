using CalcSanatoriumBooking.Resources;


namespace CalcSanatoriumBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Decimal result = default;
            Int32 a = default;
            Int16 b = default;
            Console.WriteLine($"Значения по умолчанию: Decimal={result} Int32={a} Int16={b}");
            a = 5;
            b = 0;
            result = a * b;
            Console.WriteLine(result);

        }
    }
}
