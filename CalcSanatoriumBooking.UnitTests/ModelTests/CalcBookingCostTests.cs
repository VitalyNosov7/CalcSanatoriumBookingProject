using CalcSanatoriumBooking.Model;
using NUnit.Framework;

namespace CalcSanatoriumBooking.UnitTests.DataTests
{
    [TestFixture]
    public class CalcBookingCostTests
    {

        List<CalcAction> testCalcTransactionList = new List<CalcAction>();

        /// <summary>   Получить экземпляр класса CalcBookingCost	</summary>
        /// <returns>	Экземпляр класса CalcBookingCost	</returns>
        private CalcBookingCost MakeCalcBookingCost()
        {
            return new CalcBookingCost(testCalcTransactionList);
		}

		/// <summary>	Тест на значение по умолчанию, равное нулю.	</summary>
		[Test]
		public void BookingCost_ByDefault_ReturnZero()
		{
			CalcBookingCost currentCalcBookingCost = MakeCalcBookingCost();
			Decimal result = currentCalcBookingCost.BookingCost;
			Assert.That(result, Is.Zero);
		}

		/// <summary>	Тест на значение по умолчанию, равное Empty.	</summary>
		[Test]
		public void BookingCostToString_ByDefault_Empty()
		{
			CalcBookingCost currentCalcBookingCost = MakeCalcBookingCost();
			String result = currentCalcBookingCost.BookingCostToString;
			Assert.That(result, Is.Empty);
		}
	}
}
