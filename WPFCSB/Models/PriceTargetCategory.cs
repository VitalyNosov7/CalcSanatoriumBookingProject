namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию целевой категории стоимости бронирования(Прайс для санатория, прайс для гостей)</summary>
	public class PriceTargetCategory
	{

		/// <summary>Инициализация целевой категории стоимости бронирования с тремя параметрами</summary>
		/// <param name="priceTargetCategoryID">Идентификатор целевой категории стоимости бронирования</param>
		/// <param name="priceTargetCategoryName">Наименование категории стоимости бронирования</param>
		/// <param name="priceTargetCategoryDescription">Описание</param>
		public PriceTargetCategory(Int32 priceTargetCategoryID, String priceTargetCategoryName, String priceTargetCategoryDescription)
		{
			PriceTargetCategoryID = priceTargetCategoryID;
			PriceTargetCategoryName = priceTargetCategoryName;
			PriceTargetCategoryDescription = priceTargetCategoryDescription;
		}

		/// <summary>Инициализация целевой категории стоимости бронирования с двумя параметрами</summary>
		/// <param name="priceTargetCategoryName">Наименование категории стоимости бронирования</param>
		/// <param name="priceTargetCategoryDescription">Описание</param>
		public PriceTargetCategory(String priceTargetCategoryName, String priceTargetCategoryDescription)
		{
			PriceTargetCategoryName = priceTargetCategoryName;
			PriceTargetCategoryDescription = priceTargetCategoryDescription;
		}

		/// <summary>Инициализация целевой категории стоимости бронирования без параметров</summary>
		public PriceTargetCategory() { }

		/// <summary>Идентификатор целевой категории стоимости бронирования</summary>
		private Int32 _priceTargetCategoryID = default;
		/// <summary>Идентификатор целевой категории стоимости бронирования</summary>
		public Int32 PriceTargetCategoryID
		{
			get { return _priceTargetCategoryID; }
			set { _priceTargetCategoryID = value; }
		}

		/// <summary>Наименование категории стоимости бронирования</summary>
		private String _priceTargetCategoryName = String.Empty;
		/// <summary>Наименование категории стоимости бронирования</summary>
		public String PriceTargetCategoryName
		{
			get { return _priceTargetCategoryName; }
			set { _priceTargetCategoryName = value; }
		}

		/// <summary>Описание</summary>
		private String _priceTargetCategoryDescription = String.Empty;
		/// <summary>Описание</summary>
		public String PriceTargetCategoryDescription
		{
			get { return _priceTargetCategoryDescription; }
			set { _priceTargetCategoryDescription = value; }
		}
	}
}
