using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCSB.Models
{
    /// <summary>Операция над бронированием</summary>
    public class BookingOperation
    {
        public BookingOperation(Int32 bookingOperationID, String bookingOperationName)
        {
            BookingOperationID = bookingOperationID;
            BookingOperationName = bookingOperationName;
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

    }
}
