namespace DelegateLAB
{
	public class Program
	{
		delegate T Operation<T, K>(K x, K y) where T : struct where K : struct;
		static void Main(string[] args)
		{
			Program p = new Program();
			p.DoOperation(5, 4, p.Add);         // 9
			p.DoOperation(5, 4, p.Subtract);    // 1
			p.DoOperation(5, 4, p.Multiply);    // 20		

		}
		void DoOperation(int a, int b, Operation<int, int> op)
		{
			Console.WriteLine(op(a, b));
		}

		int Add(int x, int y) => x + y;
		int Subtract(int x, int y) => x - y;
		int Multiply(int x, int y) => x * y;


	}
}
