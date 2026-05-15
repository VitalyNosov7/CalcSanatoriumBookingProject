
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
    public class TabBookingViewModel
    {
        TabControl tabControl = new TabControl();

        private void AddTabItem(object sender, RoutedEventArgs e)
        {
            TabItem tabItem = new TabItem();
            StackPanel stackPanelTabItemHeader = new StackPanel();
            // stackPanel.Name = "currentStackPanel";
            Ellipse ellipse = new Ellipse() { Height = 10, Width = 10, Fill=Brushes.Black};
            TextBlock textBlock = new TextBlock() { Margin = new Thickness(3), Text = "Программный Таб" };

            stackPanelTabItemHeader.Orientation = Orientation.Horizontal;
            stackPanelTabItemHeader.Children.Add(ellipse);
            stackPanelTabItemHeader.Children.Add(textBlock);

            tabItem.Header = stackPanelTabItemHeader;

            tabControl.Visibility = Visibility.Visible;
            tabControl.Items.Add(tabItem);
            tabItem.IsSelected = true;
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
