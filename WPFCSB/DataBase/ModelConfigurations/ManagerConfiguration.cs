using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
	{
		public void Configure(EntityTypeBuilder<Manager> builder)
		{
			builder.HasData(
			   new Manager { ManagerID = 1, ManagerPersonID = 11 },
			   new Manager { ManagerID = 2, ManagerPersonID = 12 },
			   new Manager { ManagerID = 3, ManagerPersonID = 13 },
			   new Manager { ManagerID = 4, ManagerPersonID = 14 },
			   new Manager { ManagerID = 5, ManagerPersonID = 15 },
			   new Manager { ManagerID = 6, ManagerPersonID = 16 },
			   new Manager { ManagerID = 7, ManagerPersonID = 17 }
	   );
		}
	}
}