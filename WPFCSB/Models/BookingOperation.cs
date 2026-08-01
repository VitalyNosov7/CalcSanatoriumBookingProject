using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCSB.Models
{
    /// <summary>Операция над бронированием</summary>
    public class BookingOperation
    {
        public BookingOperation(Int32 bookingOperationID, Int32 textTemplateID, String bookingOperationName)
        {
            BookingOperationID = bookingOperationID;
            BookingOperationName = bookingOperationName;
			TextTemplateID = textTemplateID;

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

		/// <summary>Идентификатор тнестового шаблона текущей операции бронирования</summary>
		private Int32 _textTemplateID;
		/// <summary>Идентификатор тнестового шаблона текущей операции бронирования</summary>
		public Int32 TextTemplateID
		{
			get { return _textTemplateID; }
			set { _textTemplateID = value; }
		}

		/// <summary>Название операции бронирования</summary>
		private String _bookingOperationName = String.Empty;

        /// <summary>Название операции бронирования</summary>
        public String BookingOperationName
        {
            get { return _bookingOperationName; }
            set { _bookingOperationName = value; }
        }

    }
}
