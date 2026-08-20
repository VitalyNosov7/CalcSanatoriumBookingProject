using System.ComponentModel.DataAnnotations.Schema;

namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о операциях с бронированием</summary>
	public class BookingOperation
	{
		/// <summary>Инициализация операции с бронированием с четырьмя параметрами</summary>
		/// <param name="bookingOperationID">Идентификатор операции с бронированием</param>
		/// <param name="textTemplate">Текстовый шаблон</param>
		/// <param name="bookingOperationName">Название операции с бронированием</param>
		/// <param name="prefixFileName">Префикс операции с бронированием</param>
		public BookingOperation(Int32 bookingOperationID, String bookingOperationName, TemplateMessage textTemplate, String prefixFileName)
		{
			BookingOperationID = bookingOperationID;
			BookingOperationName = bookingOperationName;
			TextTemplateID = textTemplate.TemplateMessageID;
			TemplateMessageBookingOperation = textTemplate;
			PrefixFileName = prefixFileName;
		}

		/// <summary>Инициализация операции с бронированием с тремя параметрами</summary>
		/// <param name="bookingOperationID">Идентификатор операции с бронированием</param>
		/// <param name="textTemplate">Текстовый шаблон</param>
		/// <param name="bookingOperationName">Название операции с бронированием</param>
		public BookingOperation(Int32 bookingOperationID, String bookingOperationName, TemplateMessage textTemplate)
		{
			BookingOperationID = bookingOperationID;
			BookingOperationName = bookingOperationName;
			TextTemplateID = textTemplate.TemplateMessageID;
			TemplateMessageBookingOperation = textTemplate;
		}

		public BookingOperation() { }

		/// <summary>Идентификатор операции бронирования</summary>
		private Int32 _bookingOperationID;
		/// <summary>Идентификатор операции бронирования</summary>
		public Int32 BookingOperationID
		{
			get { return _bookingOperationID; }
			set { _bookingOperationID = value; }
		}

		/// <summary>Название операции бронирования</summary>
		private String _bookingOperationName = String.Empty;

		/// <summary>Название операции бронирования</summary>
		public String BookingOperationName
		{
			get { return _bookingOperationName; }
			set { _bookingOperationName = value; }
		}

		/// <summary>Идентификатор тнестового шаблона текущей операции бронирования(внешний ключ)</summary>
		private Int32 _textTemplateID;
		/// <summary>Идентификатор тнестового шаблона текущей операции бронирования(внешний ключ)</summary>
		public Int32 TextTemplateID
		{
			get { return _textTemplateID; }
			set { _textTemplateID = value; }
		}

		/// <summary>Текущий текстовый шаблон</summary>
		private TemplateMessage _templateMessageBookingOperation = null!;
		/// <summary>Текущий текстовый шаблон</summary>
		public TemplateMessage TemplateMessageBookingOperation
		{
			get { return _templateMessageBookingOperation; }
			set { _templateMessageBookingOperation = value; }
		}

		/// <summary>Префикс для именования файла документа</summary>
		private String _prefixFileName = String.Empty;
		/// <summary>Префикс для именования файла документа</summary>
		public String? PrefixFileName
		{
			get { return _prefixFileName; }
			set { _prefixFileName = value!; }
		}
	}
}
