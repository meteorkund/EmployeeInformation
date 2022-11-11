using EmployeeInformation.EF;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Stores;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels;

public class AddEmployeeViewModel : ViewModelBase
{
    public EmployeeDetailsFormViewModel EmployeeDetailsFormViewModel { get; }

    public AddEmployeeViewModel(EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, SectorStore sectorStore, DepartmentStore departmentStore, EducationStore educationStore, MilitaryStore militaryStore, MaritialStore maritialStore)
    {
        ICommand submitCommand = new AddEmployeeCommand(this, employeeStore, modalNavigationStore, contextFactory);
        ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);


        EmployeeDetailsFormViewModel = new EmployeeDetailsFormViewModel(submitCommand, cancelCommand, sectorStore, departmentStore, educationStore, militaryStore, maritialStore)
        {
            IsAdding = true,
            SelectedIndexCommon = 0,
        };
    }
}
