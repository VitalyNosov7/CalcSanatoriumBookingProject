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
			new TarifCategory(4, 2, "Оздоровление") // Категория тарифа санатория Киев
		   );
		}
	}
}
