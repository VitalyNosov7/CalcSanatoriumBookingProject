
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using WPFCSB.Commands;
using WPFCSB.Models;


namespace WPFCSB.ViewModels
{
    public class TabBookingViewModel : INotifyPropertyChanged
    {


        /// <summary>Коллекция вкладок TabItem</summary>
        public ObservableCollection<TabItem>? TabItems { get; set; }

        /// <summary>Выбранная вкладка TabItem</summary>
        private TabItem? _selectedTabItem;
        /// <summary>Выбранная вкладка TabItem</summary>
        public TabItem SelectedTabItem
        {
            get { return _selectedTabItem!; }
            set
            {
                _selectedTabItem = value;
                OnPropertyChanged("SelectedTabItem");
            }
        }

        /// <summary>Текущая модель TabItem</summary>
        private TabItemModel? _currentTabItemModel = default;
        /// <summary>Текущая модель TabItem</summary>
        public TabItemModel CurrentTabItemModel
        {
            get { return _currentTabItemModel!; }
            set 
            {
                _currentTabItemModel = value; 
            }
        }

        /// <summary>"Элементы заголовка вкладки TabItem</summary>
        private ObservableCollection<Object>? _tabItemHeaderElements;

        /// <summary>"Элементы заголовка вкладки TabItem</summary>
        public ObservableCollection<Object> TabItemHeaderElements
        {
            get { return _tabItemHeaderElements!; }
            set 
            {
                _tabItemHeaderElements = value;
                OnPropertyChanged("TabItemHeaderElements");
            }
        }

        /// <summary>Элементы содержимого вкладки TabItem</summary>
        private ObservableCollection<Object>? _tabItemContentElements;

        /// <summary>Элементы содержимого вкладки TabItem</summary>
        public ObservableCollection<Object> TabItemContentElements
        {
            get { return _tabItemContentElements!; }
            set
            { 
                _tabItemContentElements = value;
                OnPropertyChanged("TabItemContentElements");
            }
        }





        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName ));
        }

        #region Команды

        // команда добавления нового объекта
        private RelayCommand? addTabItemCommand;
        public RelayCommand AddTabItemCommand
        {
            get
            {
                return addTabItemCommand ??
                  (addTabItemCommand = new RelayCommand(obj =>
                  {


                  }));
            }
        }

        #endregion Команды

    }
}
