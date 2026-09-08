using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class AccommodationTypeConfiguration : IEntityTypeConfiguration<AccommodationType>
	{
		public void Configure(EntityTypeBuilder<AccommodationType> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new AccommodationType(1, 1, "Одноместное"), // Санаторий Планета
			new AccommodationType(2, 1, "Двухместное"), // Санаторий Планета
			new AccommodationType(3, 1, "Основное"), // Санаторий Планета
			new AccommodationType(4, 1, "Доп. 3-12 лет"), // Санаторий Планета
			new AccommodationType(5, 1, "Доп. место"), // Санаторий Планета
			new AccommodationType(6, 2, "Одноместное"), // Санаторий Киев
			new AccommodationType(7, 2, "Двухместное"), // Санаторий Киев
			new AccommodationType(8, 2, "Основное"), // Санаторий Киев
			new AccommodationType(9, 2, "Доп. место 5-13 лет (вкл.)"), // Санаторий Киев
			new AccommodationType(10, 2, "Доп. место с 14 лет и старше") // Санаторий Киев
		   );
		}
	}
}
