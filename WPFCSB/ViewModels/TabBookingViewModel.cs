
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using WPFCSB.Commands;


namespace WPFCSB.ViewModels
{
    public class TabBookingViewModel : INotifyPropertyChanged
    {


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

        public void AddTabFromResources(object sender, RoutedEventArgs e)
        {

        }

        private void AddTabItem(object sender, RoutedEventArgs e)
        {

        }

        private void DelTabItem(object sender, RoutedEventArgs e)
        {

        }

    }
}
