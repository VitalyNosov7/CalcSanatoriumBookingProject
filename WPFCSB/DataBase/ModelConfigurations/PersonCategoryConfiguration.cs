using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
    public class PersonCategoryConfiguration : IEntityTypeConfiguration<PersonCategory>
	{
		public void Configure(EntityTypeBuilder<PersonCategory> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new PersonCategory(1,"Менеджер"),
			new PersonCategory(2, "Гость")
		   );
		}
	}
}
