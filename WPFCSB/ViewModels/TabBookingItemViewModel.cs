
using System.Collections.ObjectModel;
using System.Windows.Controls;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
    internal class TabBookingItemViewModel : ViewModelBase
    {
        public TabBookingItemViewModel()
        {
            LoadManagerFullNameList();
        }

        private String? _header;
        public String Header
        {
            get => _header!;
            set => Set(ref _header, value);
        }


        private String? _content;
        public String Content
        {
            get => _content!;
            set => Set(ref _content, value);
        }

        private ObservableCollection<String> _managerFullNameList = new ObservableCollection<String>();

        public ObservableCollection<String> ManagerFullNameList
        {
            get { return _managerFullNameList; }
            set => Set(ref _managerFullNameList, value);
        }

        private String _selectedManagerFullName;

        public String SelectedManagerFullName
        {
            get { return _selectedManagerFullName; }
            set => Set(ref _selectedManagerFullName, value);
        }


        private void LoadManagerFullNameList()
        {
            ManagerFullNameList.Add("Боровкова Кристина Викторовна");
            ManagerFullNameList.Add("Девочкина Юлия");
            ManagerFullNameList.Add("Корниенко Надежда Евгеньевна");
            ManagerFullNameList.Add("Кривошеина Ольга Владимировна");
            ManagerFullNameList.Add("Кузнецова Ирина Геннадьевна");
            ManagerFullNameList.Add("Огнева Алёна Ивановна");
            ManagerFullNameList.Add("Юкнявичус Виолетта Викторовна");                 
        }


        //private TabBookingItemViewModel? _selectedTab;

        //public TabBookingItemViewModel SelectedTab
        //{
        //    get => _selectedTab!;
        //    set => Set(ref _selectedTab, value);
        //}




        #region КОМАНДЫ


        #endregion КОМАНДЫ

    }
}
