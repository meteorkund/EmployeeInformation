using EmployeeInformation.EF;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.Commands
{
    public class OpenAddEmployeeCommand : CommandBase
    {
        readonly ModalNavigationStore _modalNavigationStore;
        readonly EmployeeStore _employeeStore;
        readonly DepartmentStore _departmentStore;
        readonly EmployeesDbContextFactory _contextFactory;

        public OpenAddEmployeeCommand(EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, DepartmentStore departmentStore)
        {
            _employeeStore = employeeStore;
            _modalNavigationStore = modalNavigationStore;
            _contextFactory = contextFactory;
            _departmentStore = departmentStore;
        }

        public override void Execute(object? parameter)
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel(_employeeStore, _modalNavigationStore, _contextFactory, _departmentStore);

            _modalNavigationStore.CurrentViewModel = addEmployeeViewModel;
        }
    }
}
