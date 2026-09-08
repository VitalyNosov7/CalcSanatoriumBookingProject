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
			   new Manager { ManagerID = 1, ManagerPersonID = 1 },
			   new Manager { ManagerID = 2, ManagerPersonID = 2 },
			   new Manager { ManagerID = 3, ManagerPersonID = 3 },
			   new Manager { ManagerID = 4, ManagerPersonID = 4 },
			   new Manager { ManagerID = 5, ManagerPersonID = 5 },
			   new Manager { ManagerID = 6, ManagerPersonID = 6 },
			   new Manager { ManagerID = 7, ManagerPersonID = 7 },
			   new Manager { ManagerID = 8, ManagerPersonID = 8 },
			   new Manager { ManagerID = 9, ManagerPersonID = 9 }
	   );
		}
	}
}