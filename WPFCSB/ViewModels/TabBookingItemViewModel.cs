
using System.Collections.ObjectModel;
using System.Windows.Controls;
using WPFCSB.Commands;
using WPFCSB.Models;
using WPFCSB.ViewModels.Base;

namespace WPFCSB.ViewModels
{
    internal class TabBookingItemViewModel : ViewModelBase
    {
        public TabBookingItemViewModel()
        {
            LoadManagerList();
            LoadSanatoriumList();
        }

        #region ЗАГОЛОВОК
        /// <summary>Заголовок вкладки.</summary>
        private String? _header;
        /// <summary>Заголовок вкладки.</summary>
        public String Header
        {
            get => _header!;
            set => Set(ref _header, value);
        }
        #endregion ЗАГОЛОВОК

        #region КОНТЕНТ

        // TODO: Подумать над дальнейшем использовании этого свойства
        /// <summary>Контент(это пример, который далее можно удалить или объединить весь контент в это свойство).</summary>
        private String? _content;
        /// <summary>Контент(это пример, который далее можно удалить или объединить весь контент в это свойство).</summary>
        public String Content
        {
            get => _content!;
            //set => Set(ref _content, value);
            set => Set(ref _content, value);
        }

        #region МЕНЕДЖЕРЫ

        /// <summary>Список менеджеров</summary>
        private ObservableCollection<Manager> _managerList = new ObservableCollection<Manager>();
        /// <summary>Список менеджеров</summary>
        public ObservableCollection<Manager> ManagerList
        {
            get { return _managerList; }
            set => Set(ref _managerList, value);
        }

        /// <summary>Выбранный менеджер</summary>
        private Manager _selectedManager = new Manager();
        /// <summary>Выбранный менеджер</summary>
        public Manager SelectedManager
        {
            get { return _selectedManager; }
            set => Set(ref _selectedManager, value);
        }

        //  TODO: разработать загрузку(сортировку) саиска из класса
        private void LoadManagerList()
        {
            ManagerList.Add(new Manager(1, new Person()
            {
                PersonID = 11,
                Surname = "Боровкова",
                Name = "Кристина",
                Patronymic = "Викторовна"
            }));

            ManagerList.Add(new Manager(2, new Person()
            {
                PersonID = 12,
                Surname = "Девочкина",
                Name = "Юлия",
                Patronymic = "Владимировна"
            }));

            ManagerList.Add(new Manager(3, new Person()
            {
                PersonID = 13,
                Surname = "Корниенко",
                Name = "Надежда",
                Patronymic = "Евгеньевна"
            }));
            ManagerList.Add(new Manager(4, new Person()
            {
                PersonID = 14,
                Surname = "Кривошеина",
                Name = "Ольга",
                Patronymic = "Владимировна"
            }));
            ManagerList.Add(new Manager(5, new Person()
            {
                PersonID = 15,
                Surname = "Кузнецова",
                Name = "Ирина",
                Patronymic = "Геннадьевна"
            }));
            ManagerList.Add(new Manager(6, new Person()
            {
                PersonID = 16,
                Surname = "Огнева",
                Name = "Алёна",
                Patronymic = "Ивановна"
            }));
            ManagerList.Add(new Manager(7, new Person()
            {
                PersonID = 17,
                Surname = "Юкнявичус",
                Name = "Виолетта",
                Patronymic = "Викторовна"
            }));
        }
        #endregion МЕНЕДЖЕРЫ

        #region САНАТОРИИ

        /// <summary>Список санаториев</summary>
        private ObservableCollection<Sanatorium> _sanatoriumList = new ObservableCollection<Sanatorium>();
        /// <summary>Список санаториев</summary>
        public ObservableCollection<Sanatorium> SanatoriumList
        {
            get { return _sanatoriumList; }
            set => Set(ref _sanatoriumList, value);
        }

        /// <summary>Выбранный санаторий</summary>
        private Sanatorium _selectedSanatorium = new Sanatorium();
        /// <summary>Выбранный санаторий</summary>
        public Sanatorium SelectedSanatorium
        {
            get { return _selectedSanatorium; }
            set => Set(ref _selectedSanatorium, value);
        }

        private void LoadSanatoriumList()
        {
            SanatoriumList.Add(new Sanatorium(1, "Планета"));
            SanatoriumList.Add(new Sanatorium(2, "Киев"));
            SanatoriumList.Add(new Sanatorium(3, "Озеро Сновидений"));
            SanatoriumList.Add(new Sanatorium(4, "Рябинка"));
            SanatoriumList.Add(new Sanatorium(5, "Сакрополь"));
            SanatoriumList.Add(new Sanatorium(6, "Узбекистан"));
            SanatoriumList.Add(new Sanatorium(7, "ТЭС"));
            SanatoriumList.Add(new Sanatorium(8, "Новый санаторий"));
        }

        #endregion САНАТОРИИ

        #region ПЕРИОД БРОНИРОВАНИЯ

        /// <summary>Период бронирования.</summary>
        private BookingPeriod _currentBookingPeriod = new BookingPeriod();
        /// <summary>Период бронирования.</summary>
        public BookingPeriod CurrentBookingPeriod
        {
            get { return _currentBookingPeriod; }
            set
            {
                Set(ref _currentBookingPeriod, value);
            }
        }

        ///// <summary>Количество ночей.</summary>
        //private Double _numberOfNights;
        ///// <summary>Количество ночей.</summary>
        //public Double NumberOfNights
        //{
        //    get { return _numberOfNights; }
        //    set => Set(ref _numberOfNights, value);          
        //}


        #endregion ПЕРИОД БРОНИРОВАНИЯ

        #endregion КОНТЕНТ

        #region МЕТОДЫ



        #endregion МЕТОДЫ

        #region КОМАНДЫ

        // Получить количество ночей
        private RelayCommand? numberOfNightsCommand;
        public RelayCommand NumberOfNightsCommand
        {
            get
            {
                return numberOfNightsCommand ??
                  (numberOfNightsCommand = new RelayCommand(obj =>
                  {
                      //var newTab = new TabBookingItemViewModel();
                      //{
                      // newTab.Header = $"Tab {TabItems.Count + 1}";
                      // newTab.Content = $"Content of tab {TabItems.Count + 1}";
                      // newTab.SelectedManager = new Manager();
                      // newTab.SelectedSanatorium = new Sanatorium();
                      // newTab.CurrentBookingPeriod = new BookingPeriod(DateTime.Now.AddDays(14), DateTime.Now.AddDays(24));
                      //}
                      //;

                      //var currentTab = new TabBookingItemViewModel();
                      //{
                      // TimeSpan difference = currentTab.CurrentBookingPeriod.EndDatePeriodBooking -
                      // currentTab.CurrentBookingPeriod.StartDatePeriodBooking;
                      // currentTab.NumberOfNights = difference.Days;
                      //}



                      TimeSpan difference = CurrentBookingPeriod.EndDatePeriodBooking -
                      CurrentBookingPeriod.StartDatePeriodBooking;
                      NumberOfNights = difference.Days;


                  }));
            }
        }


        #endregion КОМАНДЫ

    }
}
