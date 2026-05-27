
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

    }
}
