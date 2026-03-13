
using CalcSanatoriumBooking.Resources;

namespace CalcSanatoriumBooking.Model
{
	/// <summary>	Конструктор расчета бронирования.	</summary>
	public class BookingCalcManager : BookingCalcID
	{
		//	TODO:	разработать в этом классе алгоритм сборки расчета используя классы:
		//			(CalcShapes ?); CalcAction; CalcOperation; BookingPeriod
		//			В этом классе будет собираться расчет (в определенном порядке) и записываться в List<CalcAction>
		//			м затем для окончательного расчета будет передаваться в класс BookimgCalc


		public BookingCalcManager(Int32 calcId)
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
		public void ReadCurrentCalcAction(Int32 searchСalcId)
		{
			//	Пример поиска в списке:

			//class Book
			//{
			//    public int Price { get; set; }
			//    public string Name { get; set; }
			//}

			//static void Main(string[] args)
			//{
			//    // заполняем книги
			//    List<Book> books = new List<Book>();
			//    books.Add(new Book() { Price = 10, Name = "aaa" });
			//    books.Add(new Book() { Price = 13, Name = "eee" });
			//    books.Add(new Book() { Price = 5, Name = "ttt" });
			//    books.Add(new Book() { Price = 45, Name = "ooo" });

			//    // ищем 1 элемент
			//    Book found = books.Find(item => item.Price == 13);

			//    // выводим элемент на экран
			//    Console.WriteLine("Цена:{0}, Название:{1}", found.Price, found.Name);
			//}
			// КОНЕЦ	Пример поиска в списке:

			// List<CalcAction> processedCalcActionList = CurrentCalcActionList;

			if (CurrentCalcActionList.Exists(item => item.СalcId == searchСalcId))
			{
                CalcAction? foundCalcAction = CurrentCalcActionList.Find(item => item.СalcId == searchСalcId);
            }
			

        }

        /// <summary>	Редактировать(изменить)  расчет из списка List<CalcAction>.	</summary>
        public void UpdateCurrentCalcAction(Int32 searchСalcId)
		{

		}

		/// <summary>	Удалить  расчет из списка List<CalcAction>.	</summary>
		public void DeleteCurrentCalcAction(Int32 searchСalcId)
		{

		}

	}
}
