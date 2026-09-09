using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	/// <summary>Конфигурация таблицы категории номера - RoomCategories </summary>
	public class RoomCategoryConfiguration : IEntityTypeConfiguration<RoomCategory>
	{

		public void Configure(EntityTypeBuilder<RoomCategory> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new RoomCategory(1, 1, "Стандарт"), // Категория номера санатория Планета			
			new RoomCategory(2, 1, "Полулюкс"),// Категория номера санатория Планета		
			new RoomCategory(3, 1, "Люкс"),// Категория номера санатория Планета		
			new RoomCategory(4, 2, "1-местный номер, 2 корпус"), // Категория номера санатория Киев
			new RoomCategory(5, 2, "2-местный номер 1,2 корпус"), // Категория номера санатория Киев
			new RoomCategory(6, 2, "2-3-местный номер,5 корпус"), // Категория номера санатория Киев
			new RoomCategory(7, 2, "2-х комнатный 2-4 местный, 1,2 корпус"), // Категория номера санатория Киев
			new RoomCategory(8, 2, "КОМФОРТ СЕМЕЙНЫЙ"), // Категория номера санатория Киев
			new RoomCategory(9, 2, "2-4-х местный люкс") // Категория номера санатория Киев
		   );

		}
	}
}
