using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class PriceBookingConfiguration : IEntityTypeConfiguration<PriceBooking>
	{
		public void Configure(EntityTypeBuilder<PriceBooking> builder)
		{
			builder.HasData(
			new PriceBooking(1, new DateTime(2026, 06, 29), 1, 1, 1, 1, new DateTime(2026, 09, 01), new DateTime(2026, 09, 30), 7385, 3),
			new PriceBooking(2, new DateTime(2026, 06, 29), 1, 1, 1, 1, new DateTime(2026, 10, 01), new DateTime(2026, 10, 31), 5915, 3), 
			new PriceBooking(3, new DateTime(2026, 06, 29), 1, 1, 2, 1, new DateTime(2026, 09, 01), new DateTime(2026, 09, 30), 9870, 3),
			new PriceBooking(4, new DateTime(2026, 06, 29), 1, 1, 2, 1, new DateTime(2026, 10, 01), new DateTime(2026, 10, 31), 7910, 3)
			);
		}
	}
}
