using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class GuestConfiguration : IEntityTypeConfiguration<Guest>
	{
		public void Configure(EntityTypeBuilder<Guest> builder)
		{
			throw new NotImplementedException();
		}
	}
}
