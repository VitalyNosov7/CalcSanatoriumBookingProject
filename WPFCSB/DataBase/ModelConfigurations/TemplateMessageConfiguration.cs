using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class TemplateMessageConfiguration : IEntityTypeConfiguration<TemplateMessage>
	{
		public void Configure(EntityTypeBuilder<TemplateMessage> builder)
		{
			throw new NotImplementedException();
		}
	}
}
