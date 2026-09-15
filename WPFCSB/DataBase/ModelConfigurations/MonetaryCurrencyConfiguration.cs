using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class MonetaryCurrencyConfiguration : IEntityTypeConfiguration<MonetaryCurrency>
	{
		public void Configure(EntityTypeBuilder<MonetaryCurrency> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new MonetaryCurrency(1, 643, "RUB", "Российский рубль", "₽", "руб.", "Россия")
		   );
		}
	}
}
