using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class BookingOperationConfiguration : IEntityTypeConfiguration<BookingOperation>
	{
		public void Configure(EntityTypeBuilder<BookingOperation> builder)
		{
			throw new NotImplementedException();
		}
	}
}
