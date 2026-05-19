using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace WPFCSB.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(property)); }
        }
    }
}
