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
			new TemplateMessage(1, "{EmailSanatorium}\r\nЗаявка на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста заявку.\r\nРасчет брони:{CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."),
			new TemplateMessage(2, "Заявка напр.{CurrendDate} на сумму {CalcBookingString}"),
			new TemplateMessage(3, "{EmailSanatorium}\r\nКоррекция заявки на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста коррекцию заявки.\r\n{DescriptionBooking}\r\nРасчет брони: {CalcBookingString} \r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."),
			new TemplateMessage(4, "{CurrendDate} {DescriptionBooking}\r\nКоррекция Заявки напр. {CurrendDate} на сумму {CalcBookingString}"),
			new TemplateMessage(5, "МЫ ПОЛУЧИЛИ ВАШУ ОПЛАТУ и присвоили статус «Гарантированное бронирование»\r\n\r\nНаправляем официальную путевку — подтверждение для заезда в санаторий\r\n\r\n*сообщите удалось ли открыть путевку, и корректно ли она отображается?\r\n*если бланк путевки отображается некорректно (иероглифами), либо пустой, то Вам необходимо скачать приложение, которое поддерживает файлы формата pdf (например, Foxit Reader, PDF Reader, WPS Office и тд.) или позвонить/написать нам.\r\n\r\nПО ЛЮБЫМ ВОПРОСАМ:\r\n\r\nЗвоните бесплатно Вашему менеджеру:\r\n+7(800)444-18-10"),
			new TemplateMessage(6, "Скорректированная Путевка для заезда в санаторий {SanatoriumName}!\r\nДобрый день. Направляем Вам скорректированную Путевку.\r\nС уважением, {ManagerName}\r\nменеджер по продаже путевок"),
			new TemplateMessage(7, "п/о {CalcBookingString}\r\nПутевка напр. {CurrendDate} в мах"),
			new TemplateMessage(8, "Коррекция Путевки напр. {CurrendDate} в мах "),
			new TemplateMessage(9, "МЫ ПОЛУЧИЛИ ВАШУ ОПЛАТУ и присвоили статус «Гарантированное бронирование».\r\n\r\nНаправляем официальный подтверждающий документ Вашей оплаты с печатью и подписью генерального директора.\r\nСообщаем Вам, что мы закрепили за Вами путевку.\r\n\r\nОжидаем оплату в размере 100% и направим Вам официальную путевку-ваучер для заезда.\r\n\r\nПО ЛЮБЫМ ВОПРОСАМ:\r\n\r\nЗвоните бесплатно Вашему менеджеру:\r\n+7(800)444-18-10"),
			new TemplateMessage(10, "Скорректированное подтверждение оплаты счета для заезда в санаторий {SanatoriumName}!\r\nДобрый день. Направляем Вам Скорректированное подтверждение оплаты счета.\r\nС уважением, {ManagerName}\r\nменеджер по продаже путевок"),
			new TemplateMessage(11, "{EmailSanatorium}\r\nАннуляция заявки на {StartDatePeriodBooking} {SurnameWithInitials}\r\nКоллеги, добрый день.\r\nПримите, пожалуйста аннуляцию заявки.\r\nСпасибо.\r\nС уважением,  Виталий\r\nменеджер сервисного отдела."),
			new TemplateMessage(12, "Аннуляция Заявки напр. {CurrendDate} "),
			new TemplateMessage(13, "Оплаченная бронь в Киев на {StartDatePeriodBooking} {SurnameWithInitials} "),
			new TemplateMessage(14, "Аннуляция в Киев на {StartDatePeriodBooking} {SurnameWithInitials} "),
			new TemplateMessage(15, "Здравствуйте!\r\n\r\nВами забронирована официальная путевка в санаторий. Благодарим за Ваш правильный выбор. Направляем официальный счёт, который является гарантией Вашего бронирования. Оплачивая данный счет, Вы соглашаетесь с условиями Договора-оферты размещенном на нашем официальном сайте https://zcentr-crimea.ru/ofertapubl. Оригинал официального договора с печатью и подписью, справку о медицинских услугах, квитанции об оплате и другие документы, Вы сможете заказать за 3 дня до выезда из санатория, обратившись на ресепшн.\r\n\r\nОбратите внимание: СРОК ВНЕСЕНИЯ ОПЛАТЫ УКАЗАН В СЧЕТЕ. ЕСЛИ СРОК ПОТРЕБУЕТСЯ ПРОДЛИТЬ, СООБЩИТЕ НАМ ОБ ЭТОМ.\r\n\r\nОплату Вы можете произвести:\r\n1) по QR-коду, указанному в счете или на официальном сайте: https://zcentr-crimea.ru/oplata\r\n2) в мобильном приложении Вашего банка\r\n3) в любом отделении банка, в т.ч. Сбербанк\r\n4) оплата частями от банка Тинькофф\r\n\r\nОтветным письмом прошу сообщить удалось ли открыть счет, и корректно ли он отображается?\r\n\r\nЕсли будут какие-либо вопросы, обращайтесь. Обязательно Вам помогу.\r\n\r\nЗвоните бесплатно Вашему менеджеру:\r\n+7(800)444-18-10\r\nс 09:00 до 18:00 по МСК\r\n\r\nЗамечательного дня и хорошего настроения, до встречи в Крыму!"),
			new TemplateMessage(16, "Счёт на доплату за Путевку в санаторий {SanatoriumName}\r\nДобрый день. Направляем Вам Счёт на доплату за Путевку в санаторий {SanatoriumName} в размере {CalcBookingString} руб..\r\nС уважением, {ManagerName}\r\nменеджер по продаже путевок"),
			new TemplateMessage(17, "Скорректированный Счет для оплаты Путевки в санаторий {SanatoriumName}!\r\nДобрый день. Направляем Вам скорректированный Счёт.\r\nС уважением, {ManagerName}\r\nменеджер по продаже путевок"),
			new TemplateMessage(18, "Оплата за путевку в санаторий {SanatoriumName}\r\nСсылка на оплату {SanatoriumName} {SurnameWithInitials}\r\n\r\nСсылка на оплату создана {CurrendDate}"),
			new TemplateMessage(19, "Ссылка для входа в Т-банк"),
			new TemplateMessage(20, "{EmailSanatorium}\r\n! Информация по оплате на {CurrendDate} {SurnameWithInitials}\r\n\r\nКоллеги добрый день.\r\nПримите, пожалуйста информацию по оплате на {StartDatePeriodBooking} {SurnameWithInitials}\r\n\r\nСумма брони: __ руб.\r\nОплачено гостем: __ руб.\r\nГостем полностью оплачена путевка.\r\nСумма к доплате составит: {CalcBookingString} руб.\r\nСпасибо.\r\n\r\nС уважением, Виталий\r\nменеджер сервисного отдела."),
			new TemplateMessage(21, "Информацию об оплате напр. {CurrendDate}"),
			new TemplateMessage(22, "Коллеги, добрый день.\r\nОтправленное письмо от __ г(__) отправлено ошибочно.\r\nПросим считать его недействительным!"),
			new TemplateMessage(23, "Шаблон РЖМ Заявка Отправить"),
			new TemplateMessage(24, "Шаблон РЖМ Заявка отправлена"),
			new TemplateMessage(25, "Шаблон РЖМ Коррекция Заявки Отправить"),
			new TemplateMessage(26, "Шаблон РЖМ Коррекция Заявки отправлена")
			);
		}
	}
}
