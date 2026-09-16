using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class TextTemplateVariableConfiguration : IEntityTypeConfiguration<TextTemplateVariable>
	{
		public void Configure(EntityTypeBuilder<TextTemplateVariable> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
                new TextTemplateVariable(1, "SANATORIUM_NAME", "SanatoriumName", "Значение ключа SanatoriumName отсутствует"),
                new TextTemplateVariable(2, "EMAIL_SANATORIUM", "EmailSanatorium", "Значение ключа EmailSanatorium отсутствует"),
				new TextTemplateVariable(3, "START_DATE_PERIOD_BOOKING", "StartDatePeriodBooking", "Значение ключа StartDatePeriodBooking отсутствует"),
				new TextTemplateVariable(4, "SURNAME_WITH_INITIALS", "SurnameWithInitials", "Значение ключа SurnameWithInitials отсутствует"),
				new TextTemplateVariable(5, "CALC_BOOKING_STRING", "CalcBookingString", "Значение ключа CalcBookingString отсутствует"),
				new TextTemplateVariable(6, "CURRENT_DATE", "CurrentDate", "Значение ключа CurrendDate отсутствует"),
				new TextTemplateVariable(7, "DESCRIPTION_BOOKING", "DescriptionBooking", "Значение ключа DescriptionBooking отсутствует")
			);
		}
	}
}
