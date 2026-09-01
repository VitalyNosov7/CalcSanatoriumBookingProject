namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о текстовой переменной для текстового шаблона</summary>
	public class TextTemplateVariable
	{
		public TextTemplateVariable(Int32 textTemplateVariableID, String nameTemplateVariable, String keyTextTemlateVariable, String valueTextTemplateVariable)
		{
			TextTemplateVariableID = textTemplateVariableID;
			NameTemplateVariable = nameTemplateVariable;
			KeyTextTemlateVariable = keyTextTemlateVariable;
			ValueTextTemplateVariable = valueTextTemplateVariable;
		}

		public TextTemplateVariable(String nameTemplateVariable, String keyTextTemlateVariable, String valueTextTemplateVariable)
		{			
			NameTemplateVariable = nameTemplateVariable;
			KeyTextTemlateVariable = keyTextTemlateVariable;
			ValueTextTemplateVariable = valueTextTemplateVariable;
		}

		public TextTemplateVariable() { }

		/// <summary>Идентификатор текстовой переменной для текстового шаблона</summary>
		private Int32 _textTemplateVariableID;
		/// <summary>Идентификатор текстовой переменной для текстового шаблона</summary>
		public Int32 TextTemplateVariableID
		{
			get { return _textTemplateVariableID; }
			set { _textTemplateVariableID = value; }
		}

		/// <summary>Наименование текстовой переменной для текстового шаблона</summary>
		private String _nameTemplateVariable = String.Empty;
		/// <summary>Наименование текстовой переменной для текстового шаблона</summary>
		public String NameTemplateVariable
		{
			get { return _nameTemplateVariable; }
			set { _nameTemplateVariable = value; }
		}

		/// <summary>Ключ текстовой переменной для текстового шаблона</summary>
		private String _keyTextTemlateVariable = String.Empty;
		/// <summary>Ключ текстовой переменной для текстового шаблона</summary>
		public String KeyTextTemlateVariable
		{
			get { return _keyTextTemlateVariable; }
			set { _keyTextTemlateVariable = value; }
		}

		/// <summary>Значение текстовой переменной для текстового шаблона</summary>
		private String _valueTextTemplateVariable = String.Empty;
		/// <summary>Значение текстовой переменной для текстового шаблона</summary>
		public String ValueTextTemplateVariable
		{
			get { return _valueTextTemplateVariable; }
			set { _valueTextTemplateVariable = value; }
		}
	}
}
