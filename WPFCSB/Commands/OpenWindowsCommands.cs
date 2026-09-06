using WPFCSB.Views.Interfaces;
using WPFCSB.Views.Windows;

namespace WPFCSB.Commands
{
    public class OpenWindowsCommands
    {
		public OpenWindowsCommands(IWindowManager windowManager)
		{
			_windowManager = windowManager;

		}
		private readonly IWindowManager _windowManager;

		// Окно для работы с данными Person из базы данных 
		private RelayCommand? openPersonWindomCommand;
		public RelayCommand OpenPersonWindomCommand
		{
			get
			{
				return openPersonWindomCommand ??
				  (openPersonWindomCommand = new RelayCommand((o) =>
				  {
					  // App.OpenSingleInstancePersonWindow();
					  _windowManager.ShowOrActivate<PersonWindow>();
				  }));
			}
		}

		// Окно для работы с данными Manager из базы данных 
		private RelayCommand? openManagerWindomCommand;
		public RelayCommand OpenManagerWindomCommand
		{
			get
			{
				return openManagerWindomCommand ??
				  (openManagerWindomCommand = new RelayCommand((o) =>
				  {
					  // App.OpenSingleInstancePersonWindow();
					  _windowManager.ShowOrActivate<ManagerWindow>();
				  }));
			}
		}

		// Окно для работы с данными Sanatorium из базы данных 
		private RelayCommand? openSanatoriumWindomCommand;
		public RelayCommand OpenSanatoriumWindomCommand
		{
			get
			{
				return openSanatoriumWindomCommand ??
				  (openSanatoriumWindomCommand = new RelayCommand((o) =>
				  {
					  // App.OpenSingleInstancePersonWindow();
					  _windowManager.ShowOrActivate<SanatoriumWindow>();
				  }));
			}
		}

		// Окно для работы с данными TemplateMessage из базы данных 
		private RelayCommand? openTemplateMessageWindomCommand;
		public RelayCommand OpenTemplateMessageWindomCommand
		{
			get
			{
				return openTemplateMessageWindomCommand ??
				  (openTemplateMessageWindomCommand = new RelayCommand((o) =>
				  {
					  _windowManager.ShowOrActivate<TemplateMessageWindow>();
				  }));
			}
		}

		// Окно для работы с данными TextTemplateVariable из базы данных 
		private RelayCommand? openTextTemplateVariableWindowCommand;
		public RelayCommand OpenTextTemplateVariableWindowCommand
		{
			get
			{
				return openTextTemplateVariableWindowCommand ??
				  (openTextTemplateVariableWindowCommand = new RelayCommand((o) =>
				  {
					  _windowManager.ShowOrActivate<TextTemplateVariableWindow>();
				  }));
			}
		}

		// Окно для работы с данными BookingOperation из базы данных  BookingOperationWindowViewModel
		private RelayCommand? _openBookingOperationWindowCommand;
		public RelayCommand OpenBookingOperationWindowCommand
		{
			get
			{
				return _openBookingOperationWindowCommand ??
				  (_openBookingOperationWindowCommand = new RelayCommand((o) =>
				  {
					  _windowManager.ShowOrActivate<BookingOperationWindow>();
				  }));
			}
		}
	}
}
