
using System.ComponentModel;
using System.Runtime.CompilerServices;
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
    }
}
