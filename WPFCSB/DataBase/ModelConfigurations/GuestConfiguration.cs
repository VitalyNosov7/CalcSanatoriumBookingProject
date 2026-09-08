using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class GuestConfiguration : IEntityTypeConfiguration<Guest>
	{
		public void Configure(EntityTypeBuilder<Guest> builder)
		{
			new Guest() { GuestID = 1, GuestPersonID = 10 };
			new Guest() { GuestID = 2, GuestPersonID = 11 };
			new Guest() { GuestID = 3, GuestPersonID = 12 };
		}
	}
}
