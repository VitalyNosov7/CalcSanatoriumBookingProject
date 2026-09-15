using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class PriceTargetCategoryConfiguration : IEntityTypeConfiguration<PriceTargetCategory>
	{
		public void Configure(EntityTypeBuilder<PriceTargetCategory> builder)
		{
			builder.HasData(
			new PriceTargetCategory(1, "Цена закупки", "Цена для подачи заявки в санаторий"),
			new PriceTargetCategory(2, "Цена продажи", "Цена для гостей"),
			new PriceTargetCategory(3, "Цена продажи и закупки", "Цена для гостей и для санатория")
			);
		}

	}
}
