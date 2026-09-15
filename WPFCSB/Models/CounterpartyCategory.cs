namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о категории контрагента</summary>
	public class CounterpartyCategory
	{
		/// <summary>Идентификатор категории контрагента</summary>
		private Int32 _counterpartyCategoryID = default;
		/// <summary>Идентификатор категории контрагента</summary>
		public Int32 CounterpartyCategoryID
		{
			get { return _counterpartyCategoryID; }
			set { _counterpartyCategoryID = value; }
		}

		/// <summary>организационно-правовая форма(Юрлицо, физлицо, ИП и т.д.)</summary>
		private String _legalFormOrganization = String.Empty;
		/// <summary>организационно-правовая форма(Юрлицо, физлицо, ИП и т.д.)</summary>
		public String LegalFormOrganization
		{
			get { return _legalFormOrganization ; }
			set { _legalFormOrganization  = value; }
		}

	}
}
