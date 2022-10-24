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
        readonly EmployeesDbContextFactory _contextFactory;

        public OpenAddEmployeeCommand(EmployeeStore employeeStore, ModalNavigationStore odalNavigationStore, EmployeesDbContextFactory contextFactory)
        {
            _employeeStore = employeeStore;
            _modalNavigationStore = odalNavigationStore;
            _contextFactory = contextFactory;   
        }

        public override void Execute(object? parameter)
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel(_employeeStore, _modalNavigationStore, _contextFactory);

            _modalNavigationStore.CurrentViewModel = addEmployeeViewModel;
        }
    }
}
