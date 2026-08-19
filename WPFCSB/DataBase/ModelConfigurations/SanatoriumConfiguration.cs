using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;
using WPFCSB.Resources;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class SanatoriumConfiguration : IEntityTypeConfiguration<Sanatorium>
	{
		public void Configure(EntityTypeBuilder<Sanatorium> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new Sanatorium(1, "Планета", "olgaakopyan@mail.ru"),
			new Sanatorium(2, "Киев", "alushtasankiev-rus@mail.ru"),
			new Sanatorium(3, "Озеро Сновидений", "admin@o-snov.com"),
			new Sanatorium(4, "Рябинка", "ribinka.buh@inbox.ru"),
			new Sanatorium(5, "Сакрополь", "sakropol@yandex.ru"),
			new Sanatorium(6, "Узбекистан", "marketing@yalta-uzbekistan.ru"),
			new Sanatorium(7, "ТЭС", "teshotel@rambler.ru"),
			new Sanatorium(8, "Новый санаторий", "")
		   );
		}
	}
}
