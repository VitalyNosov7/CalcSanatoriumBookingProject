namespace WPFCSB.Models
{
	/// <summary>Класс содержит информацию о текстовых шаблонах</summary>
	public class TemplateMessage
	{
	/// <summary>Инициализация текстового шаблона с двумя параметрами</summary>
	/// <param name="templateMessageID">Идентификатор текстового шаблона</param>
	/// <param name="templateMessageText">Текст шаблона</param>
		public TemplateMessage(Int32 templateMessageID, String templateMessageText)
		{
			TemplateMessageID = templateMessageID;
			TemplateMessageText = templateMessageText;
		}

		/// <summary>Инициализация текстового шаблона без параметров</summary>
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
	}
}
