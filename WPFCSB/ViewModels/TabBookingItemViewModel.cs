
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using WPFCSB.Commands;

namespace WPFCSB.ViewModels
{
    internal class TabBookingItemViewModel : INotifyPropertyChanged
    {
        #region РЕАЛИЗАЦИЯ INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
        #endregion РЕАЛИЗАЦИЯ INotifyPropertyChanged

        public TabBookingItemViewModel()
        {
            //MyTabItem = CreateTabItem();
        }

         
        private String? _header;
        public String Header
        {
            get => _header!;
            set
            {
                _header = value;
                OnPropertyChanged();
            }
        }


        private String? _content;
        public String Content
        {
            get => _content!;
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }




        //private TabItem? _myTabItem = new TabItem();

        //public TabItem MyTabItem
        //{
        //    get => _myTabItem!;
        //    set
        //    {
        //        _myTabItem = value;
        //        OnPropertyChanged();
        //    }
        //}

        public TabItem CreateTabItem()
        {
            TabItem createdTabItem = new TabItem();

            // Создаём контейнер для заголовка вкладки
            StackPanel headerPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };

            // Создаём контейнер для содержимого вкладки
            StackPanel contentPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal
            };

            // Добавляем иконку (например, эллипс)
            Ellipse icon = new Ellipse
            {
                Height = 10,
                Width = 10,
                Fill = Brushes.Green
            };
            headerPanel.Children.Add(icon);

            // Добавляем текст заголовка
            TextBlock textBlock = new TextBlock
            {
                Text = "Ноутбуки",
                Margin = new Thickness(3)
            };
            headerPanel.Children.Add(textBlock);

            // Создаём вкладку с составным заголовком
            //TabItem advancedTab = new TabItem
            //{
            //    Header = headerPanel,
            //    Content = new TextBlock { Text = "Содержимое вкладки с иконкой" }
            //};

            createdTabItem.Header = headerPanel;


            return createdTabItem;
        }

    }
}
