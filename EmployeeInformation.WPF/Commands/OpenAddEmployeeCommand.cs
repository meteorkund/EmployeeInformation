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

        public OpenAddEmployeeCommand(EmployeeStore employeeStore, ModalNavigationStore odalNavigationStore)
        {
            _employeeStore = employeeStore;
            _modalNavigationStore = odalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel(_employeeStore, _modalNavigationStore);

            _modalNavigationStore.CurrentViewModel = addEmployeeViewModel;
        }
    }
}
