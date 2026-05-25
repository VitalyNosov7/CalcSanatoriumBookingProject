
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
        /// <summary>Текущая модель TabItem</summary>
        private TabItemModel? _currentTabItemModel;

        public TabItemModel CurrentTabItemModel
        {
            get { return _currentTabItemModel!; }
            set { _currentTabItemModel = value; }
        }



        public ObservableCollection<TabItem>? TabItems { get; set; }

        private TabItem? _selectedTabItem;
        public TabItem SelectedTabItem
        {
            get { return _selectedTabItem!; }
            set
            {
                _selectedTabItem = value;
                OnPropertyChanged("SelectedTabItem");
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
        private RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {


                  }));
            }
        }

        #endregion Команды

    }
}
