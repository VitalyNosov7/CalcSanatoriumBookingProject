

using CalcSanatoriumBooking.Data;
using System.Collections.ObjectModel;

namespace CalcSanatoriumBooking
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Hello world!");

            //ObservableCollection<Object> collection = new ObservableCollection<Object>();
            List<Object> collection = new List<Object>();
            Type type;
			Int32 a = 5;
			String s = "Hello";
			Person p = new Person();



			collection.Add(a);
            collection.Add(s);
            collection.Add(p);

			foreach(Object o in collection)
			{
				Console.WriteLine(o.ToString());
				type = o.GetType();

                Console.WriteLine($"Тип данных {type}");
			}


        }
	}
}
