using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class SanatoriumConfiguration : IEntityTypeConfiguration<Sanatorium>
	{
		public void Configure(EntityTypeBuilder<Sanatorium> builder)
		{
			throw new NotImplementedException();
		}
	}
}
