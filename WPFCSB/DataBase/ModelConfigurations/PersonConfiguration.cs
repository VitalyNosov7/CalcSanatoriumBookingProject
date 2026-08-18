using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class PersonConfiguration : IEntityTypeConfiguration<Person>
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.HasData(
			new Person { PersonID = 11, Surname = "Кривошеина", Name = "Ольга", Patronymic = "Владимировна" },
		   new Person { PersonID = 12, Surname = "Боровкова", Name = "Кристина", Patronymic = "Викторовна" },
		   new Person { PersonID = 13, Surname = "Девочкина", Name = "Юлия", Patronymic = "Владимировна" },
		   new Person { PersonID = 14, Surname = "Корниенко", Name = "Надежда", Patronymic = "Евгеньевна" },
		   new Person { PersonID = 15, Surname = "Кузнецова", Name = "Ирина", Patronymic = "Геннадьевна" },
		   new Person { PersonID = 16, Surname = "Огнева", Name = "Алёна", Patronymic = "Ивановна" },
		   new Person { PersonID = 17, Surname = "Юкнявичус", Name = "Виолетта", Patronymic = "Викторовна" }
		   );
		}
	}
}
