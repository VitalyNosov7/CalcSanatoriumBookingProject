namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о типе скидке на бронирование(процентный или фиксированная сумма)</summary>
	public class DiscountType
	{
		/// <summary>Идентификатор типа скидки на бронирование</summary>
		private Int32 _discountTypeID = default;
		/// <summary>Идентификатор типа скидки на бронирование</summary>
		public Int32 DiscountTypeID
		{
			get { return _discountTypeID; }
			set { _discountTypeID = value; }
		}

		/// <summary>Наименование типа скидки на бронирование</summary>
		private String _discountTypeName = String.Empty;
		/// <summary>Наименование типа скидки на бронирование</summary>
		public String DiscountTypeName
		{
			get { return _discountTypeName; }
			set { _discountTypeName = value; }
		}



	}
}
