

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


	}
}
