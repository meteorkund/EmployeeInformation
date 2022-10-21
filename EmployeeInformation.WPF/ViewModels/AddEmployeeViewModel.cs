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
    public class AddEmployeeViewModel : ViewModelBase
    {
        public EmployeeDetailsFormViewModel EmployeeDetailsFormViewModel { get;  }

        public AddEmployeeViewModel(EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new AddEmployeeCommand(this, employeeStore, modalNavigationStore) ;
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            EmployeeDetailsFormViewModel = new EmployeeDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
