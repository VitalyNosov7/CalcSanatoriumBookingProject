using System.Collections.ObjectModel;
using System.Windows;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;
using WPFCSB.Views.Interfaces;
using WPFCSB.Views.Services;

namespace WPFCSB.ViewModels
{
	public class BookingOperationWindowViewModel : ViewModelBase
	{
		public BookingOperationWindowViewModel(IDialogService dialogService)
		{
			ExtractDataBookingOperationFromDBCommand.Execute(null!);
			_dialogService = dialogService;
		}

		private readonly IDialogService _dialogService;

		private OpenWindowsCommands _openWindowsCommands = new OpenWindowsCommands(new WindowManager());

		public OpenWindowsCommands OpenWindowsCommands
		{
			get { return _openWindowsCommands; }
			set { _openWindowsCommands = value; }
		}

		/// <summary>Список операций бронирования</summary>
		private ObservableCollection<BookingOperation> _bookingOperations = new ObservableCollection<BookingOperation>();
		/// <summary>Список операций бронирования</summary>
		public ObservableCollection<BookingOperation> BookingOperations
		{
			get { return _bookingOperations; }
			set => Set(ref _bookingOperations, value);
		}

		/// <summary>Выбранная операция бронирования</summary>
		private BookingOperation _selectedBookingOperation = null!;
		/// <summary>Выбранная операция бронирования</summary>
		public BookingOperation SelectedBookingOperation
		{
			get { return _selectedBookingOperation!; }
			set
			{
				Set(ref _selectedBookingOperation, value);
				FillPropertyBookingOperation();
			}
		}

		/// <summary>Идентификатор операции бронирования</summary>
		private Int32 _bookingOperationID;
		/// <summary>Идентификатор операции бронирования</summary>
		public Int32 BookingOperationID
		{
			get { return _bookingOperationID; }
			set => Set(ref _bookingOperationID, value);
		}

		/// <summary>Название операции бронирования</summary>
		private String _bookingOperationName = String.Empty;

		/// <summary>Название операции бронирования</summary>
		public String BookingOperationName
		{
			get { return _bookingOperationName; }
			set => Set(ref _bookingOperationName, value);
		}

		/// <summary>Идентификатор тнестового шаблона текущей операции бронирования(внешний ключ)</summary>
		private Int32 _textTemplateID;
		/// <summary>Идентификатор тнестового шаблона текущей операции бронирования(внешний ключ)</summary>
		public Int32 TextTemplateID
		{
			get { return _textTemplateID; }
			set => Set(ref _textTemplateID, value);
		}

		///// <summary>Текущий текстовый шаблон</summary>
		//private TemplateMessage _templateMessageBookingOperation = null!;
		///// <summary>Текущий текстовый шаблон</summary>
		//public TemplateMessage TemplateMessageBookingOperation
		//{
		//	get { return _templateMessageBookingOperation; }
		//	set => Set(ref _templateMessageBookingOperation, value);
		//}

		/// <summary>Префикс для именования файла документа</summary>
		private String _prefixFileName = String.Empty;
		/// <summary>Префикс для именования файла документа</summary>
		public String? PrefixFileName
		{
			get { return _prefixFileName; }
			set => Set(ref _prefixFileName!, value);
		}

		/// <summary>Текст шаблона </summary>
		private String _templateMessageText = String.Empty;
		/// <summary>Текст шаблона </summary>
		public String TemplateMessageText
		{
			get { return _templateMessageText; }
			set => Set(ref _templateMessageText, value);
		}

		// Получение данных о операциях бронирования из базы данных
		private RelayCommand? _extractDataBookingOperationFromDBCommand;
		// Получение данных о операциях бронирования из базы данных
		public RelayCommand ExtractDataBookingOperationFromDBCommand
		{
			get
			{
				return _extractDataBookingOperationFromDBCommand ??
				  (_extractDataBookingOperationFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  List<BookingOperation> listBookingOperations = db.BookingOperations.ToList();
						  BookingOperations.Clear();
						  foreach (BookingOperation bookingOperation in listBookingOperations)
						  {
							  TemplateMessage? foundTemplateMessage = db.TemplateMessages.Find(bookingOperation.TextTemplateID);
							  if (foundTemplateMessage != null)
							  {
								  TemplateMessage createdNewTemplateMessage = new TemplateMessage
								  {
									  TemplateMessageID = foundTemplateMessage.TemplateMessageID,
									  TemplateMessageText = foundTemplateMessage.TemplateMessageText
								  };
								  bookingOperation.TemplateMessageBookingOperation = createdNewTemplateMessage;
								  BookingOperations.Add(bookingOperation);
							  }
							  else
							  {
								  MessageBox.Show("Данные о текстовом шаблоне не найдены в базе данных!");
								  return;
							  }

						  }

						  SelectedBookingOperation = null!;
						  ClearPropertyBookingOperation();
					  }

				  }));
			}
		}

		// Добавление данных о операциях бронирования в базу данных
		private RelayCommand? _addBookingOperationFromDBCommand;
		// Добавление данных о операциях бронирования в базу данных
		public RelayCommand AddBookingOperationFromDBCommand
		{
			get
			{
				return _addBookingOperationFromDBCommand ??
				  (_addBookingOperationFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  TemplateMessage newTemplateMessage = CreateNewTemplateMessage();

						  db.TemplateMessages.Add(newTemplateMessage);
						  db.SaveChanges();

						  Int32 newTemplateMessageID = newTemplateMessage.TemplateMessageID;

						  BookingOperation newBookingOperation = new BookingOperation()
						  {
							  BookingOperationName = BookingOperationName,
							  TextTemplateID = newTemplateMessageID,
							  PrefixFileName = PrefixFileName
						  };

						  db.BookingOperations.Add(newBookingOperation);
						  db.SaveChanges();

						  // TODO: Подумать как еще можно обновлять данные
						  ExtractDataBookingOperationFromDBCommand.Execute(null!);
					  }

				  }));
			}
		}

		// Редактирование данных о операциях бронирования в базе данных
		private RelayCommand? _editBookingOperationToDBCommand;
		// Редактирование данных о операциях бронирования в базе данных
		public RelayCommand EditBookingOperationToDBCommand
		{
			get
			{
				return _editBookingOperationToDBCommand ??
				  (_editBookingOperationToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedBookingOperation != null)
						  {
							  BookingOperation? selectedBookingOperation = SelectedBookingOperation;
							  BookingOperation? foundEditedBookingOperation = db.BookingOperations.Find(selectedBookingOperation.BookingOperationID);
							  BookingOperation editedBookingOperation = CreateNewBookingOperation();
							  TemplateMessage editedTemplateMessage = CreateNewTemplateMessage();
							  TemplateMessage? foundEditedTemplateMessage = db.TemplateMessages.Find(selectedBookingOperation.TextTemplateID);

							  if (foundEditedTemplateMessage != null && foundEditedBookingOperation != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение редактирования", $"Вы действительно хотите редактировать дынне операции бронирования c ID «{foundEditedBookingOperation.BookingOperationID}» текстовый шаблон c ID «{foundEditedTemplateMessage.TemplateMessageID}» - «{foundEditedTemplateMessage.TemplateMessageText}»?");

								  if (confirmed == true) // Если подтверждаем редактирования
								  {
									  // TODO: Подумать как можно сдклать валидатор
									  if (foundEditedTemplateMessage.TemplateMessageText != editedTemplateMessage.TemplateMessageText)
									  { foundEditedTemplateMessage.TemplateMessageText = editedTemplateMessage.TemplateMessageText; }
									  //db.SaveChanges();

									  if (foundEditedBookingOperation.BookingOperationName != editedBookingOperation.BookingOperationName)
									  { foundEditedBookingOperation.BookingOperationName = editedBookingOperation.BookingOperationName; }
									  if (foundEditedBookingOperation.PrefixFileName != editedBookingOperation.PrefixFileName)
									  { foundEditedBookingOperation.PrefixFileName = editedBookingOperation.PrefixFileName; }

									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataBookingOperationFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем редактирования
							  }
						  }
						  else
						  {
							  MessageBox.Show("Необходимо операцию бронирования  из списка");
							  return;
						  }
					  }
				  }));
			}
		}

		// Удаление операциях бронирования(текстового шаблона) из базы данных
		private RelayCommand? _deleteBookingOperationToDBCommand;
		// Удаление операциях бронирования(текстового шаблона) из базы данных
		public RelayCommand DeleteBookingOperationToDBCommand
		{
			get
			{
				return _deleteBookingOperationToDBCommand ??
				  (_deleteBookingOperationToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedBookingOperation != null)
						  {
							  BookingOperation selectedBookingOperation = SelectedBookingOperation;
							  BookingOperation? foundDeletedBookingOperation = db.BookingOperations.Find(selectedBookingOperation.BookingOperationID);
							  TemplateMessage? foundDeletedTemplateMessage = db.TemplateMessages.Find(selectedBookingOperation.TextTemplateID);


							  if (foundDeletedBookingOperation != null && foundDeletedTemplateMessage != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение удаления", $"Вы действительно хотите удалить операцию бронирования c ID «{foundDeletedBookingOperation.BookingOperationID}» и текстовый шаблон c ID «{foundDeletedTemplateMessage.TemplateMessageID}» -  «{foundDeletedTemplateMessage.TemplateMessageText}»?");

								  if (confirmed == true) // Если подтверждаем удаление
								  {
									  db.TemplateMessages.Remove(foundDeletedTemplateMessage!);
									  db.BookingOperations.Remove(foundDeletedBookingOperation!);
									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataBookingOperationFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем удаление

							  }

						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать операцию бронирования из списка");
							  return;
						  }

					  }

				  }));
			}
		}

		// Обновление данных о операциях бронирования из базы данных
		private RelayCommand? _updateDataЬBookingOperationFromDBCommand;
		// Обновление данных о операциях бронирования из базы данных
		public RelayCommand UpdateDataЬBookingOperationFromDBCommand
		{
			get
			{
				return _updateDataЬBookingOperationFromDBCommand ??
				  (_updateDataЬBookingOperationFromDBCommand = new RelayCommand(obj =>
				  {
					  ExtractDataBookingOperationFromDBCommand.Execute(null!);
				  }));
			}
		}

		// Снять выделение операции бронирования
		private RelayCommand? _deselectBookingOperationrCommand;
		// Снять выделение операции бронирования
		public RelayCommand DeselectBookingOperationCommand
		{
			get
			{
				return _deselectBookingOperationrCommand ??
				  (_deselectBookingOperationrCommand = new RelayCommand(obj =>
				  {
					  SelectedBookingOperation = null!;
					  ClearPropertyBookingOperation();
				  }));
			}
		}

		/// <summary>Заполнить свойства персоны</summary>
		private void FillPropertyBookingOperation()
		{
			if (SelectedBookingOperation != null)
			{
				BookingOperationID = SelectedBookingOperation.BookingOperationID;
				TextTemplateID = SelectedBookingOperation.TextTemplateID;
				BookingOperationName = SelectedBookingOperation.BookingOperationName;
				TemplateMessageText = SelectedBookingOperation.TemplateMessageBookingOperation.TemplateMessageText;
				PrefixFileName = SelectedBookingOperation.PrefixFileName;
			}
			else
			{
				return;
			}
		}

		private BookingOperation CreateNewBookingOperation()
		{
			BookingOperation createdNewBookingOperation = new BookingOperation() { BookingOperationName = BookingOperationName, PrefixFileName = PrefixFileName };
			return createdNewBookingOperation;
		}

		private TemplateMessage CreateNewTemplateMessage()
		{
			TemplateMessage createdNewTemplateMessage = new TemplateMessage(TemplateMessageText);
			return createdNewTemplateMessage;
		}

		private void ClearPropertyBookingOperation()
		{
			BookingOperationID = default;
			BookingOperationName = String.Empty;
			TextTemplateID = default;
			//TemplateMessageBookingOperation = null!;
			TemplateMessageText = String.Empty;
			PrefixFileName = String.Empty;
		}
	}
}
