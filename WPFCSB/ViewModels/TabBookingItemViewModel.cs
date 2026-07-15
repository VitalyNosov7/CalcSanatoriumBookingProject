
using System.Collections.ObjectModel;
using System.Windows.Controls;
using WPFCSB.Models;
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

        private ObservableCollection<Manager> _managerFullNameList = new ObservableCollection<Manager>();

        public ObservableCollection<Manager> ManagerFullNameList
        {
            get { return _managerFullNameList; }
            set => Set(ref _managerFullNameList, value);
        }

		private Manager _selectedManagerFullName = new Manager();

		public Manager SelectedManagerFullName
		{
			get { return _selectedManagerFullName; }
			set => Set(ref _selectedManagerFullName, value);
		}

		//private String _selectedManagerFullName = "FIO";

		//public String SelectedManagerFullName
		//{
		//	get { return _selectedManagerFullName; }
		//	set => Set(ref _selectedManagerFullName, value);
		//}

		//  TODO: разработать загрузку саиска из класса
		private void LoadManagerFullNameList()
        {
            ManagerFullNameList.Add(new Manager(1, new Person() { PersonID = 11,
				Surname = "Боровкова",
				Name = "Кристина",
				Patronymic = "Викторовна" }));

			ManagerFullNameList.Add(new Manager(2, new Person()
			{
				PersonID = 12,
				Surname = "Девочкина",
				Name = "Юлия",
				Patronymic = "Владимировна"
			}));

			ManagerFullNameList.Add(new Manager(3, new Person()
			{
				PersonID = 13,
				Surname = "Корниенко",
				Name = "Надежда",
				Patronymic = "Евгеньевна"
			}));
			ManagerFullNameList.Add(new Manager(4, new Person()
			{
				PersonID = 14,
				Surname = "Кривошеина",
				Name = "Ольга",
				Patronymic = "Владимировна"
			}));
			ManagerFullNameList.Add(new Manager(5, new Person()
			{
				PersonID = 15,
				Surname = "Кузнецова",
				Name = "Ирина",
				Patronymic = "Геннадьевна"
			}));
			ManagerFullNameList.Add(new Manager(6, new Person()
			{
				PersonID = 16,
				Surname = "Огнева",
				Name = "Алёна",
				Patronymic = "Ивановна"
			}));
			ManagerFullNameList.Add(new Manager(7, new Person()
			{
				PersonID = 17,
				Surname = "Юкнявичус",
				Name = "Виолетта",
				Patronymic = "Викторовна"
			}));


			//ManagerFullNameList.Add("Боровкова Кристина Викторовна");
			//ManagerFullNameList.Add("Девочкина Юлия Владимировна");
			//ManagerFullNameList.Add("Корниенко Надежда Евгеньевна");
			//ManagerFullNameList.Add("Кривошеина Ольга Владимировна");
			//ManagerFullNameList.Add("Кузнецова Ирина Геннадьевна");
			//ManagerFullNameList.Add("Огнева Алёна Ивановна");
			//ManagerFullNameList.Add("Юкнявичус Виолетта Викторовна");                 
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
