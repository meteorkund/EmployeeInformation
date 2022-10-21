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

        public TopMenuViewModel(EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore)
        {
            AddEmployeeCommand = new OpenAddEmployeeCommand(employeeStore, modalNavigationStore);
        }
    }
}
