using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class TextTemplateVariableConfiguration : IEntityTypeConfiguration<TextTemplateVariable>
	{
		public void Configure(EntityTypeBuilder<TextTemplateVariable> builder)
		{
			throw new NotImplementedException();
		}
	}
}
