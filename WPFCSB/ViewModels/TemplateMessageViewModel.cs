using System.Collections.ObjectModel;
using System.Windows;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;
using WPFCSB.Views.Interfaces;

namespace WPFCSB.ViewModels
{
	public class TemplateMessageViewModel : ViewModelBase
	{
		public TemplateMessageViewModel(IDialogService dialogService)
		{
			ExtractDataTemplateMessageFromDBCommand.Execute(null!);
			_dialogService = dialogService;
		}
		private readonly IDialogService _dialogService;

		/// <summary>Список текстовых шаблонов</summary>
		private ObservableCollection<TemplateMessage> _templateMessages = new ObservableCollection<TemplateMessage>();
		/// <summary>Список текстовых шаблонов</summary>
		public ObservableCollection<TemplateMessage> TemplateMessages
		{
			get { return _templateMessages; }
			set => Set(ref _templateMessages, value);
		}

		/// <summary>Выбранный текстовый шаблон</summary>
		private TemplateMessage _selectedTemplateMessage = null!;
		/// <summary>Выбранный текстовый шаблон</summary>
		public TemplateMessage SelectedTemplateMessage
		{
			get { return _selectedTemplateMessage!; }
			set
			{
				Set(ref _selectedTemplateMessage, value);
				FillPropertyTemplateMessage();
			}
		}

		/// <summary>Идентификатор шаблона текста сообщения</summary>
		private Int32 _templateMessageID;
		/// <summary>Идентификатор шаблона текста сообщения</summary>
		public Int32 TemplateMessageID
		{
			get { return _templateMessageID; }
			set => Set(ref _templateMessageID, value);
		}

		/// <summary>Текст шаблона </summary>
		private String _templateMessageText = String.Empty;
		/// <summary>Текст шаблона </summary>
		public String TemplateMessageText
		{
			get { return _templateMessageText; }
			set => Set(ref _templateMessageText, value);
		}

		// Получение данных о текстовых шаблонах из базы данных
		private RelayCommand? _extractDataTemplateMessageFromDBCommand;
		// Получение данных о текстовых шаблонах из базы данных
		public RelayCommand ExtractDataTemplateMessageFromDBCommand
		{
			get
			{
				return _extractDataTemplateMessageFromDBCommand ??
				  (_extractDataTemplateMessageFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  List<TemplateMessage> listTemplateMessages = db.TemplateMessages.ToList();
						  TemplateMessages.Clear();
						  foreach (TemplateMessage templateMessage in listTemplateMessages)
						  {
							  TemplateMessage? foundTemplateMessage = db.TemplateMessages.Find(templateMessage.TemplateMessageID);
							  if (foundTemplateMessage != null)
							  {
								  TemplateMessage createdNewTemplateMessage = new TemplateMessage()
								  {
									  TemplateMessageID = templateMessage.TemplateMessageID,
									  TemplateMessageText = templateMessage.TemplateMessageText
								  };

								  TemplateMessages.Add(createdNewTemplateMessage);
							  }
							  else
							  {
								  MessageBox.Show("Данные о текстовом шаблоне не найдены в базе данных!");
								  return;
							  }

						  }

						  SelectedTemplateMessage = null!;
						  ClearPropertyTemplateMessage();
					  }

				  }));
			}
		}


		// Добавление данных о текстовом шаблоне в базу данных
		private RelayCommand? addTemplateMessageFromDBCommand;
		// Добавление данных о текстовом шаблоне в базу данных
		public RelayCommand AddTemplateMessageFromDBCommand
		{
			get
			{
				return addTemplateMessageFromDBCommand ??
				  (addTemplateMessageFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  TemplateMessage newTemplateMessage = CreateNewTemplateMessage();				

						  db.TemplateMessages.Add(newTemplateMessage);
						  db.SaveChanges();

						  // TODO: Подумать как еще можно обновлять данные
						  ExtractDataTemplateMessageFromDBCommand.Execute(null!);
					  }

				  }));
			}
		}

		// Редактирование данных о текстовом шаблоне в базе данных
		private RelayCommand? editTemplateMessageToDBCommand;
		// Редактирование данных о текстовом шаблоне в базе данных
		public RelayCommand EeditTemplateMessageToDBCommand
		{
			get
			{
				return editTemplateMessageToDBCommand ??
				  (editTemplateMessageToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedTemplateMessage != null)
						  {
							  TemplateMessage? selectedTemplateMessage = SelectedTemplateMessage;
							  TemplateMessage? foundEditedTemplateMessage = db.TemplateMessages.Find(selectedTemplateMessage.TemplateMessageID);
							  TemplateMessage editedTemplateMessage = CreateNewTemplateMessage();


							  if (foundEditedTemplateMessage != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение редактирования", $"Вы действительно хотите редактировать дынне текстового шаблона c ID «{foundEditedTemplateMessage.TemplateMessageID}» - «{foundEditedTemplateMessage.TemplateMessageText}»?");

								  if (confirmed == true) // Если подтверждаем редактирования
								  {
									  // TODO: Подумать как можно сдклать валидатор
									  if (foundEditedTemplateMessage.TemplateMessageText != editedTemplateMessage.TemplateMessageText)
									  { foundEditedTemplateMessage.TemplateMessageText = editedTemplateMessage.TemplateMessageText; }
									 
									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataTemplateMessageFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем редактирования
							  }
						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать шаблон из списка");
							  return;
						  }
					  }
				  }));
			}
		}

		// Удаление шаблона текста из базы данных
		private RelayCommand? deleteTemplateMessageToDBCommand;
		// Удаление шаблона текста из базы данных
		public RelayCommand DeleteTemplateMessageToDBCommand
		{
			get
			{
				return deleteTemplateMessageToDBCommand ??
				  (deleteTemplateMessageToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedTemplateMessage != null)
						  {
							  TemplateMessage selectedTemplateMessage = SelectedTemplateMessage;
							  TemplateMessage? foundDeletedTemplateMessage = db.TemplateMessages.Find(selectedTemplateMessage.TemplateMessageID);
							  


							  if (foundDeletedTemplateMessage != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение удаления", $"Вы действительно хотите удалить шаблон текста  c ID «{foundDeletedTemplateMessage.TemplateMessageID}» - «{foundDeletedTemplateMessage.TemplateMessageText}»?");

								  if (confirmed == true) // Если подтверждаем удаление
								  {
									  db.TemplateMessages.Remove(foundDeletedTemplateMessage!);									
									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataTemplateMessageFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем удаление

							  }

						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать шаблон из списка");
							  return;
						  }

					  }

				  }));
			}
		}


		// Снять выделение текстового шаблона
		private RelayCommand? deselectTemplateMessageCommand;
		// Снять выделение текстового шаблона
		public RelayCommand DeselectTemplateMessageCommand
		{
			get
			{
				return deselectTemplateMessageCommand ??
				  (deselectTemplateMessageCommand = new RelayCommand(obj =>
				  {
					  SelectedTemplateMessage = null!;
					  ClearPropertyTemplateMessage();
				  }));
			}
		}

		// Обновление данных о текстовых шаблонах из базы данных
		private RelayCommand? updateDataЬTemplateMessageFromDBCommand;
		// Обновление данных о текстовых шаблонах из базы данных
		public RelayCommand UpdateDataЬTemplateMessageFromDBCommand
		{
			get
			{
				return updateDataЬTemplateMessageFromDBCommand ??
				  (updateDataЬTemplateMessageFromDBCommand = new RelayCommand(obj =>
				  {
					  ExtractDataTemplateMessageFromDBCommand.Execute(null!);
				  }));
			}
		}

		/// <summary>Заполнить свойства текстового шаблона</summary>
		private void FillPropertyTemplateMessage()
		{
			if (SelectedTemplateMessage != null)
			{
				TemplateMessageID = SelectedTemplateMessage.TemplateMessageID;
				TemplateMessageText = SelectedTemplateMessage.TemplateMessageText;
			}
			else
			{
				return;
			}
		}

		/// <summary>Очистить свойства текстового шаблон</summary>
		private void ClearPropertyTemplateMessage()
		{
			TemplateMessageID = default;
			TemplateMessageText = String.Empty;
		}

		private TemplateMessage CreateNewTemplateMessage()
		{
			
			TemplateMessage createdNewTemplateMessage = new TemplateMessage(TemplateMessageText);
			return createdNewTemplateMessage;
		}
	}
}
