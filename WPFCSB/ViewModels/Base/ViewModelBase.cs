using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace WPFCSB.ViewModels.Base
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;

            field = value;
            NotifyPropertyChanged(propertyName);
            return true;
        }

        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // 1. Вариант
            // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            // 2. Вариант
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
    }

    //public event PropertyChangedEventHandler? PropertyChanged;
    //public void OnPropertyChanged([CallerMemberName] string propertyName = "")
    //{
    //    if (PropertyChanged != null)
    //    { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
    //}
    //#endregion РЕАЛИЗАЦИЯ INotifyPropertyChanged
}
