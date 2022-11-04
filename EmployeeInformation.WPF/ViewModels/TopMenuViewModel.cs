using EmployeeInformation.Domain.Models;
using EmployeeInformation.EF;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels
{
    public class TopMenuViewModel : ViewModelBase
    {
        public ICommand AddEmployeeCommand { get; }
        readonly EmployeesDbContextFactory _contextFactory;
        readonly EmployeeListingViewModel _employeeListingViewModel;

        public EmployeeListingViewModel EmployeeListingViewModel { get; set; }


        public TopMenuViewModel(EmployeeListingViewModel employeeListingViewModel, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, SectorStore sectorStore, DepartmentStore departmentStore)
        {
            _employeeListingViewModel = employeeListingViewModel;
            _contextFactory = contextFactory;
            AddEmployeeCommand = new OpenAddEmployeeCommand(employeeStore, modalNavigationStore, contextFactory, sectorStore,departmentStore);


        }


        private string _textToFilter;

        public string TextToFilter
        {
            get { return _textToFilter; }
            set
            {
                _textToFilter = value;
                OnPropertyChanged(nameof(TextToFilter));
                _employeeListingViewModel.EmployeeCollection.Filter = FilterByName;

            }
        }

        private bool FilterByName(object emp)
        {
            if (!string.IsNullOrEmpty(TextToFilter))
            {
                var empDetail = emp as EmployeeListingItemViewModel;
                return empDetail != null && empDetail.Isim.Contains(TextToFilter)
                                         || empDetail.Soyisim.Contains(TextToFilter);
            }
            return true;
        }

    }
}
