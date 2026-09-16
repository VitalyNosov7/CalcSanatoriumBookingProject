using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WPFCSB.Models;

namespace WPFCSB.DataBase.ModelConfigurations
{
	public class BookingOperationConfiguration : IEntityTypeConfiguration<BookingOperation>
	{
		public void Configure(EntityTypeBuilder<BookingOperation> builder)
		{
			// Инициализация базы данных начальными данными
			builder.HasData(
					new BookingOperation { BookingOperationID = 1, BookingOperationName = "Заявка Отправить", TextTemplateID = 1, PrefixFileName = "Заявка " },
					new BookingOperation { BookingOperationID = 2, BookingOperationName = "Заявка отправлена", TextTemplateID = 2 },
					new BookingOperation { BookingOperationID = 3, BookingOperationName = "Коррекция Заявки Отправить", TextTemplateID = 3, PrefixFileName = "Коррекция заявки " },
					new BookingOperation { BookingOperationID = 4, BookingOperationName = "Коррекция Заявки отправлена", TextTemplateID = 4 },
					new BookingOperation { BookingOperationID = 5, BookingOperationName = "Путевка Отправить", TextTemplateID = 5, PrefixFileName = "Путевка " },
					new BookingOperation { BookingOperationID = 6, BookingOperationName = "Путевка Коррекция Отправить", TextTemplateID = 6 },
					new BookingOperation { BookingOperationID = 7, BookingOperationName = "Путевка отправлена", TextTemplateID = 7 },
					new BookingOperation { BookingOperationID = 8, BookingOperationName = "Путевка коррекция отправлена", TextTemplateID = 8 },
					new BookingOperation { BookingOperationID = 9, BookingOperationName = "Подтверждение оплаты отправить", TextTemplateID = 9, PrefixFileName = "Подтверждение оплаты " },
					new BookingOperation { BookingOperationID = 10, BookingOperationName = "Подтверждение коррекция отправить", TextTemplateID = 10 },
					new BookingOperation { BookingOperationID = 11, BookingOperationName = "Аннуляция Отправить", TextTemplateID = 11, PrefixFileName = "Аннуляция " },
					new BookingOperation { BookingOperationID = 12, BookingOperationName = "Аннуляция отправлена ", TextTemplateID = 12, PrefixFileName = "Аннуляция " },
					new BookingOperation { BookingOperationID = 13, BookingOperationName = "Бронь оплаченная", TextTemplateID = 13 },
					new BookingOperation { BookingOperationID = 14, BookingOperationName = "Бронь которую аннулируем", TextTemplateID = 14 },
					new BookingOperation { BookingOperationID = 15, BookingOperationName = "Счет Отправить", TextTemplateID = 15, PrefixFileName = "Счет " },
					new BookingOperation { BookingOperationID = 16, BookingOperationName = "Счет на доплату Отправить", TextTemplateID = 16, PrefixFileName = "Счет на доплату " },
					new BookingOperation { BookingOperationID = 17, BookingOperationName = "Счет Коррекция Отправить", TextTemplateID = 17, PrefixFileName = "Счет коррекция " },
					new BookingOperation { BookingOperationID = 18, BookingOperationName = "Ссылка на БО", TextTemplateID = 18 },
					new BookingOperation { BookingOperationID = 19, BookingOperationName = "Рассрочка Т-банк", TextTemplateID = 19 },
					new BookingOperation { BookingOperationID = 20, BookingOperationName = "Информация об оплате", TextTemplateID = 20 },
					new BookingOperation { BookingOperationID = 21, BookingOperationName = "Информация об оплате отправлена", TextTemplateID = 21 },
					new BookingOperation { BookingOperationID = 22, BookingOperationName = "Отмена письма", TextTemplateID = 22 },
					new BookingOperation { BookingOperationID = 23, BookingOperationName = "РЖМ Заявка Отправить", TextTemplateID = 23, PrefixFileName = "РМЖ заявка " },
					new BookingOperation { BookingOperationID = 24, BookingOperationName = "РЖМ Заявка отправлена", TextTemplateID = 24 },
					new BookingOperation { BookingOperationID = 25, BookingOperationName = "РЖМ Коррекция Заявки Отправить", TextTemplateID = 25, PrefixFileName = "РМЖ Коррекция заявки " },
					new BookingOperation { BookingOperationID = 26, BookingOperationName = "РЖМ Коррекция Заявки отправлена", TextTemplateID = 26 }
			);
			builder.HasOne(x => x.TemplateMessageBookingOperation)
					.WithMany()
					.HasForeignKey("TextTemplateID");
		}
	}
}

