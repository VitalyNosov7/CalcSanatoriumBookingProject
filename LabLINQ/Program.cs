namespace LabLINQ
{
	using System;
	using System.Linq;
	using System.Collections.ObjectModel;

	class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	class Program
	{
		static void Main()
		{
			var people = new ObservableCollection<Person>
		{
			new Person { Id = 1, Name = "Alice" },
			new Person { Id = 2, Name = "Bob" },
			new Person { Id = 3, Name = "Charlie" }
		};

			// Пример LINQ: найти по ID
			var person = people.FirstOrDefault(p => p.Id == 3);

			// Пример: отфильтровать по условию
			var filtered = people.Where(p => p.Name.StartsWith("A")).ToList();

			Console.WriteLine(person.Name);
		}
	}
}
