

namespace WPFCSB.Models
{
	/// <summary>Шаблон текста сообщения</summary>
	public class TemplateMessage
	{
		public TemplateMessage(Int32 templateMessageID, String templateMessageText)
		{
			TemplateMessageID = templateMessageID;
			TemplateMessageText = templateMessageText;
		}

		public TemplateMessage() { }

		/// <summary>Идентификатор шаблона текста сообщения</summary>
		private Int32 _templateMessageID;
		/// <summary>Идентификатор шаблона текста сообщения</summary>
		public Int32 TemplateMessageID
		{
			get { return _templateMessageID; }
			set { _templateMessageID = value; }
		}

		/// <summary>Текст шаблона </summary>
		private String _templateMessageText = String.Empty;
		/// <summary>Текст шаблона </summary>
		public String TemplateMessageText
		{
			get { return _templateMessageText; }
			set { _templateMessageText = value; }
		}

		/// <summary>Переменные текста шаблона </summary>
		private Dictionary<String,String> _textTemplateVariables = new Dictionary<String, String>();
		/// <summary>Переменные текста шаблона </summary>
		public Dictionary<String,String> TextTemplateVariables
		{
			get { return _textTemplateVariables; }
			set { _textTemplateVariables = value; }
		}

	}
}
