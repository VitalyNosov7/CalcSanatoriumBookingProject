namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о категории персоны(менеджеры, гости и т.п.)</summary>
	public class PersonCategory
	{
		/// <summary>Инициализация категории персоны с двумя параметрами</summary>
		/// <param name="personCategoryID">Идентификатор категории персоны</param>
		/// <param name="personCategoryName">Наименование категории персоны</param>
		public PersonCategory(Int32 personCategoryID, String personCategoryName)
		{
			PersonCategoryID = personCategoryID;
			PersonCategoryName = personCategoryName;
		}

		/// <summary>Инициализация категории персоны с одним параметром</summary>
		/// <param name="personCategoryName">Наименование категории персоны</param>
		public PersonCategory(String personCategoryName)
		{
			PersonCategoryName = personCategoryName;
		}

		/// <summary>Инициализация категории персоны без параметров</summary>
		public PersonCategory() { }

		/// <summary>Идентификатор категории персоны</summary>
		private Int32 _personCategoryID;
		/// <summary>Идентификатор категории персоны</summary>
		public Int32 PersonCategoryID
		{
			get { return _personCategoryID; }
			set { _personCategoryID = value; }
		}

		/// <summary>Наименование категории персоны</summary>
		private String _personCategoryName = String.Empty;
		/// <summary>Наименование категории персоны</summary>
		public String PersonCategoryName
		{
			get { return _personCategoryName; }
			set { _personCategoryName = value; }
		}
	}
}
