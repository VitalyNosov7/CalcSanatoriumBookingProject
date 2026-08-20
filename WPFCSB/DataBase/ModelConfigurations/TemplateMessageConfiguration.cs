using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class TemplateMessageConfiguration : IEntityTypeConfiguration<TemplateMessage>
	{
		public void Configure(EntityTypeBuilder<TemplateMessage> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
			new TemplateMessage(11, "{EmailSanatorium}\r\nЗаявка на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста заявку.\r\nРасчет брони:{CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."),
			new TemplateMessage(12, "Заявка напр.{CurrendDate} на сумму {CalcBookingString}"),
			new TemplateMessage(13, "{EmailSanatorium}\r\nКоррекция заявки на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста коррекцию заявки.\r\n{DescriptionBooking}\r\nРасчет брони: {CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."),
			new TemplateMessage(14, "{CurrendDate} {DescriptionBooking}\r\nКоррекция Заявки напр. {CurrendDate} на сумму {CalcBookingString}"),
			new TemplateMessage(15, "Шаблон Путевка Отправить"),
			new TemplateMessage(16, "Шаблон Путевка Коррекция Отправить"),
			new TemplateMessage(17, "Шаблон Путевка отправлена"),
			new TemplateMessage(18, "Шаблон Путевка коррекция отправлена"),
			new TemplateMessage(19, "Шаблон Подтверждение оплаты отправить"),
			new TemplateMessage(20, "Шаблон Подтверждение коррекция отправить"),
			new TemplateMessage(21, "Шаблон Аннуляция Отправить"),
			new TemplateMessage(22, "Шаблон Аннуляция отправлена "),
			new TemplateMessage(23, "Шаблон Бронь оплаченная"),
			new TemplateMessage(24, "Шаблон Бронь которую аннулируем"),
			new TemplateMessage(25, "Шаблон Счет Отправить"),
			new TemplateMessage(26, "Шаблон Счет на доплату Отправить"),
			new TemplateMessage(27, "Шаблон Счет Коррекция Отправить"),
			new TemplateMessage(28, "Шаблон Ссылка на БО"),
			new TemplateMessage(29, "Шаблон Рассрочка Т-банк"),
			new TemplateMessage(30, "Шаблон Информация об оплате"),
			new TemplateMessage(31, "Шаблон Информация об оплате отправлена"),
			new TemplateMessage(32, "Шаблон Отмена письма"),
			new TemplateMessage(33, "Шаблон РЖМ Заявка Отправить"),
			new TemplateMessage(34, "Шаблон РЖМ Заявка отправлена"),
			new TemplateMessage(35, "Шаблон РЖМ Коррекция Заявки Отправить"),
			new TemplateMessage(36, "Шаблон РЖМ Коррекция Заявки отправлена")
			);
		}
	}
}
