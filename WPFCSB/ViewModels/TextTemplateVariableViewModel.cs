using System.Collections.ObjectModel;
using System.Windows;
using WPFCSB.Commands;
using WPFCSB.DataBase;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;
using WPFCSB.Views.Interfaces;

namespace WPFCSB.ViewModels
{
	public class TextTemplateVariableViewModel : ViewModelBase
	{
		public TextTemplateVariableViewModel(IDialogService dialogService)
		{
			ExtractDataTextTemplateVariableFromDBCommand.Execute(null!);
			_dialogService = dialogService;
		}

		private readonly IDialogService _dialogService;

		/// <summary>Список текстовых переменных шаблонов</summary>
		private ObservableCollection<TextTemplateVariable> _textTemplateVariables = new ObservableCollection<TextTemplateVariable>();
		/// <summary>Список текстовых переменных шаблонов</summary>
		public ObservableCollection<TextTemplateVariable> TextTemplateVariables
		{
			get { return _textTemplateVariables; }
			set => Set(ref _textTemplateVariables, value);
		}

		/// <summary>Выбранная текстовая переменная шаблона</summary>
		private TextTemplateVariable _selectedTextTemplateVariable = null!;
		/// <summary>Выбранная текстовая переменная шаблона</summary>
		public TextTemplateVariable SelectedTextTemplateVariable
		{
			get { return _selectedTextTemplateVariable!; }
			set
			{
				Set(ref _selectedTextTemplateVariable, value);
				FillPropertyTextTemplateVariable();
			}
		}

		/// <summary>Идентификатор текстовой переменной для текстового шаблона</summary>
		private Int32 _textTemplateVariableID;
		/// <summary>Идентификатор текстовой переменной для текстового шаблона</summary>
		public Int32 TextTemplateVariableID
		{
			get { return _textTemplateVariableID; }
			set => Set(ref _textTemplateVariableID, value);
		}

		/// <summary>Наименование текстовой переменной для текстового шаблона</summary>
		private String _nameTemplateVariable = String.Empty;
		/// <summary>Наименование текстовой переменной для текстового шаблона</summary>
		public String NameTemplateVariable
		{
			get { return _nameTemplateVariable; }
			set => Set(ref _nameTemplateVariable, value);
		}

		/// <summary>Ключ текстовой переменной для текстового шаблона</summary>
		private String _keyTextTemlateVariable = String.Empty;
		/// <summary>Ключ текстовой переменной для текстового шаблона</summary>
		public String KeyTextTemlateVariable
		{
			get { return _keyTextTemlateVariable; }
			set => Set(ref _keyTextTemlateVariable, value);
		}

		/// <summary>Значение текстовой переменной для текстового шаблона</summary>
		private String _valueTextTemplateVariable = String.Empty;
		/// <summary>Значение текстовой переменной для текстового шаблона</summary>
		public String ValueTextTemplateVariable
		{
			get { return _valueTextTemplateVariable; }
			set => Set(ref _valueTextTemplateVariable, value);
		}

		// Получение данных о  текстовых переменных для текстового шаблона из базы данных
		private RelayCommand? _extractDataTextTemplateVariableFromDBCommand;
		// Получение данных о  текстовых переменных для текстового шаблона из базы данных
		public RelayCommand ExtractDataTextTemplateVariableFromDBCommand
		{
			get
			{
				return _extractDataTextTemplateVariableFromDBCommand ??
				  (_extractDataTextTemplateVariableFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  List<TextTemplateVariable> listTextTemplateVariables = db.TextTemplateVariables.ToList();
						  TextTemplateVariables.Clear();
						  foreach (TextTemplateVariable textTemplateVariable in listTextTemplateVariables)
						  {
							  TextTemplateVariable? foundTextTemplateVariable = db.TextTemplateVariables.Find(textTemplateVariable.TextTemplateVariableID);
							  if (foundTextTemplateVariable != null)
							  {
								  TextTemplateVariable createdNewTextTemplateVariable = new TextTemplateVariable
								  {
									  TextTemplateVariableID = foundTextTemplateVariable.TextTemplateVariableID,
									  NameTemplateVariable = foundTextTemplateVariable.NameTemplateVariable,
									  KeyTextTemlateVariable = foundTextTemplateVariable.KeyTextTemlateVariable,
									  ValueTextTemplateVariable = foundTextTemplateVariable.ValueTextTemplateVariable
								  };

								  TextTemplateVariables.Add(createdNewTextTemplateVariable);
							  }
							  else
							  {
								  MessageBox.Show("Данные о текстовых переменных для текстового шаблона не найдены в базе данных!");
								  return;
							  }

						  }

						  SelectedTextTemplateVariable = null!;
						  ClearPropertyTemplateMessage();
					  }

				  }));
			}
		}

		// Добавление данных о  текстовых переменных для текстового шаблона в базу данных
		private RelayCommand? _addTextTemplateVariableFromDBCommand;
		// Добавление данных о  текстовых переменных для текстового шаблона в базу данных
		public RelayCommand AddTextTemplateVariableFromDBCommand
		{
			get
			{
				return _addTextTemplateVariableFromDBCommand ??
				  (_addTextTemplateVariableFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  TextTemplateVariable newTextTemplateVariable = CreateNewTextTemplateVariable();

						  db.TextTemplateVariables.Add(newTextTemplateVariable);
						  db.SaveChanges();

						  // TODO: Подумать как еще можно обновлять данные
						  ExtractDataTextTemplateVariableFromDBCommand.Execute(null!);
					  }

				  }));
			}
		}

		// Редактирование данных о  текстовых переменных для текстового шаблона в базу данных
		private RelayCommand? _editTextTemplateVariableFromDBCommand;
		// Редактирование данных о  текстовых переменных для текстового шаблона в базу данных
		public RelayCommand EeditTextTemplateVariableFromDBCommand
		{
			get
			{
				return _editTextTemplateVariableFromDBCommand ??
				  (_editTextTemplateVariableFromDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedTextTemplateVariable != null)
						  {
							  TextTemplateVariable? selectedTextTemplateVariable = SelectedTextTemplateVariable;
							  TextTemplateVariable? foundEditedTextTemplateVariable = db.TextTemplateVariables.Find(selectedTextTemplateVariable.TextTemplateVariableID);
							  TextTemplateVariable editedTextTemplateVariable = CreateNewTextTemplateVariable();


							  if (foundEditedTextTemplateVariable != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение редактирования", $"Вы действительно хотите редактировать дынне текстовой переменной шаблона c ID «{foundEditedTextTemplateVariable.TextTemplateVariableID}» - «{foundEditedTextTemplateVariable.NameTemplateVariable}»?");

								  if (confirmed == true) // Если подтверждаем редактирования
								  {
									  // TODO: Подумать как можно сдклать валидатор
									  if (foundEditedTextTemplateVariable.NameTemplateVariable != editedTextTemplateVariable.NameTemplateVariable)
									  { foundEditedTextTemplateVariable.NameTemplateVariable = editedTextTemplateVariable.NameTemplateVariable; }
									  if (foundEditedTextTemplateVariable.KeyTextTemlateVariable != editedTextTemplateVariable.KeyTextTemlateVariable)
									  { foundEditedTextTemplateVariable.KeyTextTemlateVariable = editedTextTemplateVariable.KeyTextTemlateVariable; }
									  if (foundEditedTextTemplateVariable.ValueTextTemplateVariable != editedTextTemplateVariable.ValueTextTemplateVariable)
									  { foundEditedTextTemplateVariable.ValueTextTemplateVariable = editedTextTemplateVariable.ValueTextTemplateVariable; }


									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataTextTemplateVariableFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем редактирования
							  }
						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать дынне текстовой переменной шаблона из списка");
							  return;
						  }
					  }
				  }));
			}
		}

		// Удаление  данных о  текстовых переменных для текстового шаблона из базы данных
		private RelayCommand? _deleteTextTemplateVariableToDBCommand;
		// Удаление  данных о  текстовых переменных для текстового шаблона из базы данных
		public RelayCommand DeleteTextTemplateVariableToDBCommand
		{
			get
			{
				return _deleteTextTemplateVariableToDBCommand ??
				  (_deleteTextTemplateVariableToDBCommand = new RelayCommand(obj =>
				  {
					  using (ApplicationContext db = new ApplicationContext())
					  {
						  if (SelectedTextTemplateVariable != null)
						  {
							  TextTemplateVariable selectedTextTemplateVariable = SelectedTextTemplateVariable;
							  TextTemplateVariable? foundDeletedTextTemplateVariable = db.TextTemplateVariables.Find(selectedTextTemplateVariable.TextTemplateVariableID);



							  if (foundDeletedTextTemplateVariable != null)
							  {
								  bool? confirmed = _dialogService.Confirm("Подтверждение удаления", $"Вы действительно хотите удалить дынне текстовой переменной шаблона текста  c ID «{foundDeletedTextTemplateVariable.TextTemplateVariableID}» - «{foundDeletedTextTemplateVariable.NameTemplateVariable}»?");

								  if (confirmed == true) // Если подтверждаем удаление
								  {
									  db.TextTemplateVariables.Remove(foundDeletedTextTemplateVariable!);
									  db.SaveChanges();

									  // TODO: Подумать как еще можно обновлять данные
									  ExtractDataTextTemplateVariableFromDBCommand.Execute(null!);
								  }
								  else { return; } // Если не подтверждаем удаление

							  }

						  }
						  else
						  {
							  MessageBox.Show("Необходимо выбрать дынне текстовой переменной шаблона из списка");
							  return;
						  }

					  }

				  }));
			}
		}

		// Снять выделение текстовых переменных для текстового шаблона
		private RelayCommand? _deselectTextTemplateVariableCommand;
		// Снять выделение текстовых переменных для текстового шаблона
		public RelayCommand DeselectTextTemplateVariableCommand
		{
			get
			{
				return _deselectTextTemplateVariableCommand ??
				  (_deselectTextTemplateVariableCommand = new RelayCommand(obj =>
				  {
					  SelectedTextTemplateVariable = null!;
					  ClearPropertyTemplateMessage();
				  }));
			}
		}

		// Обновление данных о текстовых переменных для текстового шаблона из базы данных
		private RelayCommand? _updateDataЬTextTemplateVariableFromDBCommand;
		// Обновление данных о текстовых переменных для текстового шаблона из базы данных
		public RelayCommand UpdateDataЬTextTemplateVariableFromDBCommand
		{
			get
			{
				return _updateDataЬTextTemplateVariableFromDBCommand ??
				  (_updateDataЬTextTemplateVariableFromDBCommand = new RelayCommand(obj =>
				  {
					  ExtractDataTextTemplateVariableFromDBCommand.Execute(null!);
				  }));
			}
		}

		/// <summary>Заполнить свойства текстовой переменной для текстового шаблона</summary>
		private void FillPropertyTextTemplateVariable()
		{
			if (SelectedTextTemplateVariable != null)
			{
				TextTemplateVariableID = SelectedTextTemplateVariable.TextTemplateVariableID;
				NameTemplateVariable = SelectedTextTemplateVariable.NameTemplateVariable;
				KeyTextTemlateVariable = SelectedTextTemplateVariable.KeyTextTemlateVariable;
				ValueTextTemplateVariable = SelectedTextTemplateVariable.ValueTextTemplateVariable;
			}
			else
			{
				return;
			}
		}

		/// <summary>Очистить свойства текстовой переменной для текстового шаблона</summary>
		private void ClearPropertyTemplateMessage()
		{
			TextTemplateVariableID = default;
			NameTemplateVariable = String.Empty;
			KeyTextTemlateVariable = String.Empty;
			ValueTextTemplateVariable = String.Empty;
		}

		private TextTemplateVariable CreateNewTextTemplateVariable()
		{
			TextTemplateVariable createdTextTemplateVariable = new TextTemplateVariable(NameTemplateVariable, KeyTextTemlateVariable, ValueTextTemplateVariable);
			return createdTextTemplateVariable;
		}
	}
}

