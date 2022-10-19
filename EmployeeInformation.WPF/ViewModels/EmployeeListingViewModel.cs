using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeListingViewModel :ViewModelBase
    {
        readonly ObservableCollection<EmployeeListingItemViewModel> _employeeListingItemViewModels;
        readonly SelectedEmployeeStore _selectedEmployeeStore;

        public IEnumerable<EmployeeListingItemViewModel> EmployeeListingItemViewModels => _employeeListingItemViewModels;
        private EmployeeListingItemViewModel _selectedEmployeeListingItemViewModel;

        public EmployeeListingItemViewModel SelectedEmployeeListingItemViewModel
        {
            get { return _selectedEmployeeListingItemViewModel; }
            set
            {
                _selectedEmployeeListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedEmployeeListingItemViewModel));

                _selectedEmployeeStore.SelectedEmployee = _selectedEmployeeListingItemViewModel?.Employee;
            }
        }


        public EmployeeListingViewModel(SelectedEmployeeStore selectedEmployeeStore)
        {
            _selectedEmployeeStore = selectedEmployeeStore;

            _employeeListingItemViewModels = new ObservableCollection<EmployeeListingItemViewModel>();

            _employeeListingItemViewModels.Add(new EmployeeListingItemViewModel(new Employee(
                "C:\\Users\\YAZILIM\\Desktop\\logo vs\\vader.png",
                "METE ORKUN",
                "DEMİR",
                true,
                "30994332238",
                "02/08/1995",
                "BEKAR",
                "LİSANS",
                "YAPILDI",
                "YAZILIM",
                "YAZILIM DESTEK UZMANI",
                "08/08/2022",
                "",
                "123456",
                "5365065634",
                "ÇALIŞMA SÜRESİ 1AY",
                "İLK İŞE BAŞLAMA 08/08/2022",
                "BOSNA HERSEK MAHALLESİ ABİDEYİ HÜRRİYET SOKAK BAKYAPI SİTESİ 16/E-28 SELÇUKLU/KONYA",
                "TEST METE TEST TEST DENEME DENE TEST TEST DENEME DENE TEST TEST DENEME DENE TEST TEST DENEME DENE  "

                )));

            _employeeListingItemViewModels.Add(new EmployeeListingItemViewModel(new Employee(
                "C:\\Users\\YAZILIM\\Desktop\\logo vs\\Şirket LOGO\\MemetAvatar.jpg",
                "ALİ",
                "ÇETİN",
                false,
                "12345678901",
                "01/01/1999",
                "EVLİ",
                "LİSE",
                "YAPILDI",
                "ARGE",
                "ARGE MÜDÜRÜ",
                "05/10/2019",
                "05/02/2020",
                "654321",
                "5051236598",
                "ÇALIŞMA SÜRESİ 2AY",
                "İLK İŞE BAŞLAMA 05/10/2018",
                "MERAM",
                "TEST ALİ"

                )));


        }
    }
}
