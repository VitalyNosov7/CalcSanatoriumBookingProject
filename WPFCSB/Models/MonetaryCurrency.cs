namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о денежной валюте</summary>
	public class MonetaryCurrency
	{
		/// <summary>Инициализация денежной валюты с семью параметрами</summary>
		/// <param name="monetaryCurrencyID">Идентификатор денежной валюты</param>
		/// <param name="digitalCodeCurrency">Цифровой код денежной валюты</param>
		/// <param name="alphabeticCodeCurrency">Буквенный код денежной валюты</param>
		/// <param name="currencyFullName">Наименование валюты</param>
		/// <param name="currencySymbol">Символ валюты</param>
		/// <param name="currencyAbbreviatedName">Сокращенное представление валюты</param>
		/// <param name="currencyCountry">Страна валюты</param>
		public MonetaryCurrency(Int32 monetaryCurrencyID, Int32 digitalCodeCurrency, String alphabeticCodeCurrency, String currencyFullName, String currencySymbol, String currencyAbbreviatedName, String currencyCountry)
		{
			MonetaryCurrencyID = monetaryCurrencyID;
			DigitalCodeCurrency = digitalCodeCurrency;
			AlphabeticCodeCurrency = alphabeticCodeCurrency;
			CurrencyFullName = currencyFullName;
			CurrencySymbol = currencySymbol;
			CurrencyAbbreviatedName = currencyAbbreviatedName;
			CurrencyCountry = currencyCountry;
		}

		/// <summary>Инициализация денежной валюты с шестью параметрами</summary>		
		/// <param name="digitalCodeCurrency">Цифровой код денежной валюты</param>
		/// <param name="alphabeticCodeCurrency">Буквенный код денежной валюты</param>
		/// <param name="currencyFullName">Наименование валюты</param>
		/// <param name="currencySymbol">Символ валюты</param>
		/// <param name="currencyAbbreviatedName">Сокращенное представление валюты</param>
		/// <param name="currencyCountry">Страна валюты</param>
		public MonetaryCurrency( Int32 digitalCodeCurrency, String alphabeticCodeCurrency, String currencyFullName, String currencySymbol, String currencyAbbreviatedName, String currencyCountry)
		{			
			DigitalCodeCurrency = digitalCodeCurrency;
			AlphabeticCodeCurrency = alphabeticCodeCurrency;
			CurrencyFullName = currencyFullName;
			CurrencySymbol = currencySymbol;
			CurrencyAbbreviatedName = currencyAbbreviatedName;
			CurrencyCountry = currencyCountry;
		}

		/// <summary>Инициализация денежной валюты без параметров</summary>
		public MonetaryCurrency() { }

		/// <summary>Идентификатор денежной валюты</summary>
		private Int32 _monetaryCurrencyID = default;
		/// <summary>Идентификатор денежной валюты</summary>
		public Int32 MonetaryCurrencyID
		{
			get { return _monetaryCurrencyID; }
			set { _monetaryCurrencyID = value; }
		}

		/// <summary>Цифровой код денежной валюты</summary>
		private Int32 _digitalCodeCurrency = default;
		/// <summary>Цифровой код денежной валюты</summary>
		public Int32 DigitalCodeCurrency
		{
			get { return _digitalCodeCurrency; }
			set { _digitalCodeCurrency = value; }
		}

		/// <summary>Буквенный код денежной валюты</summary>
		private String _alphabeticCodeCurrency = String.Empty;
		/// <summary>Буквенный код денежной валюты</summary>
		public String AlphabeticCodeCurrency
		{
			get { return _alphabeticCodeCurrency; }
			set { _alphabeticCodeCurrency = value; }
		}

		/// <summary>Наименование валюты</summary>
		private String _currencyFullName = String.Empty;
		/// <summary>Наименование валюты</summary>
		public String CurrencyFullName
		{
			get { return _currencyFullName; }
			set { _currencyFullName = value; }
		}

		/// <summary>Символ валюты</summary>
		private String _currencySymbol = String.Empty;
		/// <summary>Символ валюты</summary>
		public String CurrencySymbol
		{
			get { return _currencySymbol; }
			set { _currencySymbol = value; }
		}

		/// <summary>Сокращенное представление валюты</summary>
		private String _currencyAbbreviatedName = String.Empty;
		/// <summary>Сокращенное представление валюты</summary>
		public String CurrencyAbbreviatedName
		{
			get { return _currencyAbbreviatedName; }
			set { _currencyAbbreviatedName = value; }
		}

		/// <summary>Страна валюты</summary>
		private String _currencyCountry = String.Empty;
		/// <summary>Страна валюты</summary>
		public String CurrencyCountry
		{
			get { return _currencyCountry; }
			set { _currencyCountry = value; }
		}
	}
}
