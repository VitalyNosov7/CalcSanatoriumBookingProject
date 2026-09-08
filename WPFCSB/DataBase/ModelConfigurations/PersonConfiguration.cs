using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;
using WPFCSB.Resources;

namespace WPFCSB.DataBase.ModelConfigurations
{
	/// <summary>Настройка параметров таблицы Person</summary>
	public class PersonConfiguration : IEntityTypeConfiguration<Person>
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new Person(1, "Кривошеина", "Ольга", "Владимировна", new DateTime(1960, 01, 01), Gender.Female),
			new Person(2, "Боровкова", "Кристина", "Викторовна", new DateTime(1977, 05, 01), Gender.Female),
			new Person(3, "Девочкина", "Юлия", "Владимировна", new DateTime(1976, 12, 03), Gender.Female),
			new Person(4, "Корниенко", "Надежда", "Евгеньевна", new DateTime(1980, 03, 04), Gender.Female),
			new Person(5, "Кузнецова", "Ирина", "Геннадьевна", new DateTime(1978, 04, 08), Gender.Female),
			new Person(6, "Огнева", "Алёна", "Ивановна", new DateTime(1977, 06, 05), Gender.Female),
			new Person(7, "Юкнявичус", "Виолетта", "Викторовна", new DateTime(1990, 04, 07), Gender.Female),
			new Person(8, "Носов", "Виталий", "Владимирович", new DateTime(1977, 06, 06), Gender.Male),
			new Person(9, "Гороховская", "Виктория", "Владимирович", new DateTime(1977, 06, 07), Gender.Female),
			new Person(10, "Иванов", "Иван", "Иванович", new DateTime(1977, 06, 07), Gender.Male),
			new Person(11, "Иванова", "Мария", "Петровна", new DateTime(1977, 06, 07), Gender.Female),
			new Person(12, "Иванов", "Михаил", "Иванович", new DateTime(2000, 06, 07), Gender.Male)
		   );

		}
	}
}
