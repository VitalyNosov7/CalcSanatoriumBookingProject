namespace CollectionLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var mike = new KeyValuePair<int, string>(56, "Mike");
            //var employees = new List<KeyValuePair<int, string>>() { mike };
            //var people = new Dictionary<int, string>(employees)
            //{
            //    [5] = "Tom",
            //    [6] = "Sam",
            //    [7] = "Bob",
            //};

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"key: {person.Key}  value: {person.Value}");
            //}

            // Пример обработки строки извне с использованием Dictionary


            var values = new Dictionary<string, object>
            {
                ["Name"] = "Анна",
                ["Age"] = 30,
                ["City"] = "Москва",
                ["Role"] = "Разработчик"
            };

            string template = "Привет, {Name}! Тебе {Age} лет, ты живёшь в {City} и работаешь как {Role}.";

            string result = template;
            foreach (var kvp in values)
            {
                result = result.Replace($"{{{kvp.Key}}}", kvp.Value.ToString());
            }

            Console.WriteLine(result);
        }
    }
}
