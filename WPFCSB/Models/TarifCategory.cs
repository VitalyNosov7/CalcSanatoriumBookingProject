
namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о категории тарифа санатория</summary>
	public class TarifCategory
	{
		/// <summary>Конструктор категории тарифа санатория с тремя параметрами</summary>
		/// <param name="tarifCategoryID">Идентификатор категории тарифа санатория</param>
		/// <param name="sanatoriumID">Идентификатор санатория</param>
		/// <param name="tarifCategoryName">Наименование категории тарифа санатория</param>
		public TarifCategory(Int32 tarifCategoryID, Int32 sanatoriumID, String tarifCategoryName)
		{
			TarifCategoryID = tarifCategoryID;
			SanatoriumID = sanatoriumID;
			TarifCategoryName = tarifCategoryName;
		}

		/// <summary>Конструктор категории тарифа санатория с двумя параметрами</summary>
		/// <param name="sanatoriumID">Идентификатор санатория</param>
		/// <param name="tarifCategoryName">Наименование категории тарифа санатория</param>
		public TarifCategory(Int32 sanatoriumID, String tarifCategoryName)
		{
			SanatoriumID = sanatoriumID;
			TarifCategoryName = tarifCategoryName;
		}
		/// <summary>Конструктор категории тарифа санатория без параметров</summary>
		public TarifCategory() { }

		/// <summary>Идентификатор категории тарифа санатория</summary>
		private Int32 _tarifCategoryID;
		/// <summary>Идентификатор категории тарифа санатория</summary>
		public Int32 TarifCategoryID
		{
			get { return _tarifCategoryID; }
			set { _tarifCategoryID = value; }
		}

		/// <summary>Идентификатор санатория</summary>
		private Int32 _sanatoriumID;
		/// <summary>Идентификатор санатория</summary>
		public Int32 SanatoriumID
		{
			get { return _sanatoriumID; }
			set { _sanatoriumID = value; }
		}

		/// <summary>Наименование категории тарифа санатория</summary>
		private String _tarifCategoryName = String.Empty;
		/// <summary>Наименование категории тарифа санатория</summary>
		public String TarifCategoryName
		{
			get { return _tarifCategoryName; }
			set { _tarifCategoryName = value; }
		}
	}
}
