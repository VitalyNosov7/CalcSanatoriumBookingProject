
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Resources;
using System.Windows.Shapes;
using WPFCSB.Commands;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
    public class TabBookingViewModel : INotifyPropertyChanged
    {
      
        public ObservableCollection<TabItem> TabItems { get; set; }

        private TabItem _selectedTabItem;
        public TabItem SelectedTabItem
        {
            get { return _selectedTabItem; }
            set
            {
                _selectedTabItem = value;
                OnPropertyChanged("SelectedTabItem");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {

                      //Phone phone = new Phone();
                      //Phones.Insert(0, phone);
                      //SelectedPhone = phone;

                      TabItem newTabItem = new TabItem();
                      TabItems.Insert(0, newTabItem.So); // TODO: Вытащить TabItem из ресурса TabItemsDictionary.xaml
                      SelectedTabItem = newTabItem;
                  }));
            }
        }

        private void AddTabItem(object sender, RoutedEventArgs e)
        {
            //TabItem tabItem = new TabItem();
            //StackPanel stackPanelTabItemHeader = new StackPanel();
            //// stackPanel.Name = "currentStackPanel";
            //Ellipse ellipse = new Ellipse() { Height = 10, Width = 10, Fill=Brushes.Black};
            //TextBlock textBlock = new TextBlock() { Margin = new Thickness(3), Text = "Программный Таб" };

            //stackPanelTabItemHeader.Orientation = Orientation.Horizontal;
            //stackPanelTabItemHeader.Children.Add(ellipse);
            //stackPanelTabItemHeader.Children.Add(textBlock);

            //tabItem.Header = stackPanelTabItemHeader;

            //tabControl.Visibility = Visibility.Visible;
            //tabControl.Items.Add(tabItem);
            //tabItem.IsSelected = true;
        }

        private void DelTabItem(object sender, RoutedEventArgs e)
        {
            //products.Items.RemoveAt(products.SelectedIndex);

            //TabItem current = (TabItem)tabControl.SelectedItem;
            //current.Visibility = Visibility.Collapsed;
            //tabItemStart.Visibility = Visibility.Collapsed;
            //// tabControl.Visibility = Visibility.Collapsed;
            //stackPanelTabItemHeader.Visibility = Visibility.Collapsed;
        }

        public TabBookingViewModel()
        {
         
        }
    }
}
