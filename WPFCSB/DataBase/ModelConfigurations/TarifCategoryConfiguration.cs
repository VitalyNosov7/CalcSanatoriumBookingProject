using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	/// <summary>Конфигурация таблицы категории тарифов - TarifCategories </summary>
	public class TarifCategoryConfiguration : IEntityTypeConfiguration<TarifCategory>
	{

		public void Configure(EntityTypeBuilder<TarifCategory> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new TarifCategory(1, 1, "С лечением"), // Категория тарифа санатория Планета			
			new TarifCategory(2, 1, "Без лечения"), // Категория тарифа санатория Планета	
			new TarifCategory(3, 2, "С лечением"), // Категория тарифа санатория Киев	
			new TarifCategory(4, 2, "Оздоровление"), // Категория тарифа санатория Киев
            new TarifCategory(5, 3, "С лечением"), // Категория тарифа санатория Озеро сновидений
            new TarifCategory(6, 4, "С лечением"), // Категория тарифа санатория Сакрополь
            new TarifCategory(7, 4, "Без лечения"), // Категория тарифа санатория Сакрополь
            new TarifCategory(8, 5, "С лечением"), // Категория тарифа санатория Узбекистан
            new TarifCategory(9, 6, "С лечением") // Категория тарифа санатория ТЭС
           );
		}
	}
}
