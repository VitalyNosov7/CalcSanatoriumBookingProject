using static DelegateLAB.Program;

namespace DelegateLAB
{
	public class Program
	{
		//static void Main(string[] args)
		//	{
		//		Account account = new Account(200);
		//		// Добавляем в делегат ссылку на методы
		//		account.RegisterHandler(PrintSimpleMessage);
		//		account.RegisterHandler(PrintColorMessage);
		//		// Два раза подряд пытаемся снять деньги
		//		account.Take(100);
		//		account.Take(150);

		//		// Удаляем делегат
		//		account.UnregisterHandler(PrintColorMessage);
		//		// снова пытаемся снять деньги
		//		account.Take(50);

		//		void PrintSimpleMessage(string message) => Console.WriteLine(message);
		//		void PrintColorMessage(string message)
		//		{
		//			// Устанавливаем красный цвет символов
		//			Console.ForegroundColor = ConsoleColor.Red;
		//			Console.WriteLine(message);
		//			// Сбрасываем настройки цвета
		//			Console.ResetColor();
		//		}
		//	}



		static void Main(string[] args)
		{
			GetMessage gm = new GetMessage();
			gm.RegisterHandler(Hello);
			gm.RegisterHandler(Hello);
			gm.RegisterHandler(HowAreYou);




			gm.message?.Invoke();
		}
		static void Hello() => Console.WriteLine("Hello");
		static void HowAreYou() => Console.WriteLine("How are you?");



		public delegate void Message();

	}

	public class GetMessage
	{
		public Message? message = null;
		
		public void RegisterHandler(Message m)
		{
			message += m;
		}


		public delegate void Message();
}



	//public delegate void AccountHandler(string message);
	//public class Account
	//{
	//	int sum;
	//	AccountHandler? taken;
	//	public Account(int sum) => this.sum = sum;
	//	// Регистрируем делегат
	//	public void RegisterHandler(AccountHandler del)
	//	{
	//		taken += del;
	//	}
	//	// Отмена регистрации делегата
	//	public void UnregisterHandler(AccountHandler del)
	//	{
	//		taken -= del; // удаляем делегат
	//	}
	//	public void Add(int sum) => this.sum += sum;
	//	public void Take(int sum)
	//	{
	//		if (this.sum >= sum)
	//		{
	//			this.sum -= sum;
	//			taken?.Invoke($"Со счета списано {sum} у.е.");
	//		}
	//		else
	//			taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
	//	}
	//}

}
