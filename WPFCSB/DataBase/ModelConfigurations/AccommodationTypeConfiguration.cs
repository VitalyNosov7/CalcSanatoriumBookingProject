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
			new AccommodationType(10, 2, "Доп. место с 14 лет и старше"), // Санаторий Киев
            new AccommodationType(11, 3, "Одноместное"), // Санаторий Озеро сновидений
            new AccommodationType(12, 3, "Двухместное"), // Санаторий Озеро сновидений
            new AccommodationType(13, 3, "Основное"), // Санаторий Озеро сновидений
            new AccommodationType(14, 3, "Доп. 3-12 лет"), // Санаторий Озеро сновидений
            new AccommodationType(15, 3, "Доп. место"),// Санаторий Озеро сновидений
            new AccommodationType(16, 4, "Подселение"),// Санаторий Сакрополь
            new AccommodationType(17, 4, "Одноместное"), // Санаторий Сакрополь
            new AccommodationType(18, 4, "Двухместное"), // Санаторий Сакрополь
            new AccommodationType(19, 4, "Доп. место (взр.)"), // Санаторий Сакрополь
            new AccommodationType(20, 4, "Основное"), // Санаторий Сакрополь
            new AccommodationType(21, 5, "Одноместное"), // Санаторий Узбекистан
            new AccommodationType(22, 5, "Двухместное"), // Санаторий Узбекистан
            new AccommodationType(23, 5, "Основное"), // Санаторий Узбекистан
            new AccommodationType(24, 5, "Трехместное"), // Санаторий Узбекистан
            new AccommodationType(25, 5, "Четырехместное"), // Санаторий Узбекистан
            new AccommodationType(26, 5, "Цена за номер"), // Санаторий Узбекистан
            new AccommodationType(27, 5, "Дети до 3 лет включит. (без места и лечения)"), // Санаторий Узбекистан
            new AccommodationType(28, 5, "Дети от 4 до 14 лет включит. (без лечения)"), // Санаторий Узбекистан
            new AccommodationType(29, 5, "Дети с 15 лет и взрослые (с лечением)"), // Санаторий Узбекистан
            new AccommodationType(30, 5, "Завтрак"), // Санаторий Узбекистан
            new AccommodationType(31, 5, "Обед"), // Санаторий Узбекистан
            new AccommodationType(32, 5, "Ужин"), // Санаторий Узбекистан
            new AccommodationType(33, 6, "Одноместное"), // Санаторий ТЭС
            new AccommodationType(34, 6, "Двухместное"), // Санаторий ТЭС
            new AccommodationType(35, 6, "Основное"), // Санаторий ТЭС
            new AccommodationType(36, 6, "Доп. 3-6 лет"), // Санаторий ТЭС
            new AccommodationType(37, 6, "Доп. 7-12 лет"), // Санаторий ТЭС
            new AccommodationType(38, 6, "Доп. место") // Санаторий ТЭС
           );
		}
	}
}
