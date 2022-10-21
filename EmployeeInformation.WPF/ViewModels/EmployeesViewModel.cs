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
    public class EmployeesViewModel :ViewModelBase
    {
        public EmployeeListingViewModel EmployeeListingViewModel { get; }
        public EmployeeDetailsViewModel EmployeeDetailsViewModel { get; } 


        public ICommand LoadEmployeesCommand { get; }

        public TopMenuViewModel TopMenuViewModel { get; }
        public LeftMenuViewModel LeftMenuViewModel { get; }
        public EmployeesViewModel(EmployeeStore employeeStore,SelectedEmployeeStore selectedEmployeeStore, ModalNavigationStore modalNavigationStore)
        {
            EmployeeListingViewModel = EmployeeListingViewModel.LoadViewModel(employeeStore,selectedEmployeeStore, modalNavigationStore);
            EmployeeDetailsViewModel = new EmployeeDetailsViewModel(selectedEmployeeStore);

            TopMenuViewModel = new TopMenuViewModel(employeeStore, modalNavigationStore);
            LeftMenuViewModel = new LeftMenuViewModel();

        }

    }
}
