using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeesViewModel :ViewModelBase
    {
        public EmployeeListingViewModel EmployeeListingViewModel { get; }
        public EmployeeDetailsViewModel EmployeeDetailsViewModel { get; }
        public TopMenuViewModel TopMenuViewModel { get; }
        public LeftMenuViewModel LeftMenuViewModel { get; }
        public EmployeesViewModel(SelectedEmployeeStore _selectedEmployeeStore)
        {
            EmployeeListingViewModel = new EmployeeListingViewModel(_selectedEmployeeStore);
            EmployeeDetailsViewModel = new EmployeeDetailsViewModel(_selectedEmployeeStore);
            TopMenuViewModel = new TopMenuViewModel();
            LeftMenuViewModel = new LeftMenuViewModel();
        }
    }
}
