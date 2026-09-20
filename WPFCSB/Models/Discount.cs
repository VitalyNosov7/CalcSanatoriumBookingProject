
namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о скидке на бронирование</summary>
	public class Discount
	{
		/// <summary>Идентификатор скидки на бронирование</summary>
		private Int32 _discountID = default;
		/// <summary>Идентификатор скидки на бронирование</summary>
		public Int32 DiscountID
		{
			get { return _discountID; }
			set { _discountID = value; }
		}

		/// <summary>Наименование скидки на бронирование</summary>
		private String _discountName = String.Empty;
		/// <summary>Наименование скидки на бронирование</summary>
		public String DiscountName
		{
			get { return _discountName; }
			set { _discountName = value; }
		}

		/// <summary>Сумма скидки на бронирование</summary>
		private Int32 _discountAmount = default;
		/// <summary>Сумма скидки на бронирование</summary>
		public Int32 DiscountAmount
		{
			get { return _discountAmount; }
			set { _discountAmount = value; }
		}

		/// <summary>Идентификатор типа скидки на бронирование</summary>
		private Int32 _discountTypeID = default;
		/// <summary>Идентификатор типа скидки на бронирование</summary>
		public Int32 DiscountTypeID
		{
			get { return _discountTypeID; }
			set { _discountTypeID = value; }
		}





	}
}
