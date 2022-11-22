using EmployeeInformation.EF;
using EmployeeInformation.WPF.Stores;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels;

public class EmployeesViewModel : ViewModelBase
{
    public EmployeeListingViewModel EmployeeListingViewModel { get; }
    public EmployeeDetailsViewModel EmployeeDetailsViewModel { get; }
    public EmployeeDetailsFormViewModel EmployeeDetailsFormViewModel { get; }

    readonly EmployeesDbContextFactory _contextFactory;


    public TopMenuViewModel TopMenuViewModel { get; }
    public LeftMenuViewModel LeftMenuViewModel { get; }
    public EmployeesViewModel(EmployeeStore employeeStore, SelectedEmployeeStore selectedEmployeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, SectorStore sectorStore, DepartmentStore departmentStore, EducationStore educationStore, MilitaryStore militaryStore, MaritialStore maritialStore)
    {
        _contextFactory = contextFactory;

        EmployeeListingViewModel = EmployeeListingViewModel.LoadViewModel(employeeStore, selectedEmployeeStore, modalNavigationStore, contextFactory, sectorStore, departmentStore, educationStore, militaryStore, maritialStore);
        EmployeeDetailsViewModel = new EmployeeDetailsViewModel(selectedEmployeeStore);

        TopMenuViewModel = new TopMenuViewModel(EmployeeListingViewModel, employeeStore, modalNavigationStore, contextFactory, sectorStore, departmentStore, educationStore, militaryStore, maritialStore);
        LeftMenuViewModel = new LeftMenuViewModel();

    }

}
