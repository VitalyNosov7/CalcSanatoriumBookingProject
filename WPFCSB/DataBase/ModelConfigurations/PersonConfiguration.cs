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
			new Person(11, "Кривошеина", "Ольга", "Владимировна", new DateTime(1960, 01, 01), Gender.Female),
			new Person(12, "Боровкова", "Кристина", "Викторовна", new DateTime(1977, 05, 01), Gender.Female),
			new Person(13, "Девочкина", "Юлия", "Владимировна", new DateTime(1976, 12, 03), Gender.Female),
			new Person(14, "Корниенко", "Надежда", "Евгеньевна", new DateTime(1980, 03, 04), Gender.Female),
			new Person(15, "Кузнецова", "Ирина", "Геннадьевна", new DateTime(1978, 04, 08), Gender.Female),
			new Person(16, "Огнева", "Алёна", "Ивановна", new DateTime(1977, 06, 05), Gender.Female),
			new Person(17, "Юкнявичус", "Виолетта", "Викторовна", new DateTime(1990, 04, 07), Gender.Female),
			new Person(18, "Носов", "Виталий", "Владимирович", new DateTime(1977, 06, 06), Gender.Male),
			new Person(19, "Гороховская", "Виктория", "Владимирович", new DateTime(1977, 06, 07), Gender.Female)
		   );

		}
	}
}
