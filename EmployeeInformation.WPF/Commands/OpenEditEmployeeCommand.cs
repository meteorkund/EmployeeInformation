using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Commands
{
    public class OpenEditEmployeeCommand :CommandBase
    {
        readonly EmployeeStore _employeeStore;
        readonly DepartmentStore _departmentStore;
        readonly ModalNavigationStore _modalNavigationStore;
        readonly EmployeeListingItemViewModel _employeeListingItemViewModel;

        public OpenEditEmployeeCommand(EmployeeListingItemViewModel employeeListingItemViewModel, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, DepartmentStore departmentStore)
        {
            _employeeListingItemViewModel = employeeListingItemViewModel;
            _employeeStore = employeeStore;
            _departmentStore = departmentStore;
            _modalNavigationStore = modalNavigationStore;

        }

        public override void Execute(object? parameter)
        {
            Employee employee = _employeeListingItemViewModel.Employee;

            EditEmployeeViewModel editEmployeeViewModel = new EditEmployeeViewModel(employee,_employeeStore,_modalNavigationStore, _departmentStore);
            _modalNavigationStore.CurrentViewModel = editEmployeeViewModel;
        }
    }
}
