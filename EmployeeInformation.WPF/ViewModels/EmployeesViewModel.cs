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


    public ICommand LoadEmployeesCommand { get; }

    public TopMenuViewModel TopMenuViewModel { get; }
    public LeftMenuViewModel LeftMenuViewModel { get; }
    public EmployeesViewModel(EmployeeStore employeeStore, SelectedEmployeeStore selectedEmployeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, SectorStore sectorStore, DepartmentStore departmentStore)
    {
        _contextFactory = contextFactory;

        EmployeeListingViewModel = EmployeeListingViewModel.LoadViewModel(employeeStore,selectedEmployeeStore,modalNavigationStore,contextFactory,sectorStore,departmentStore);
        EmployeeDetailsViewModel = new EmployeeDetailsViewModel(selectedEmployeeStore);

        TopMenuViewModel = new TopMenuViewModel(EmployeeListingViewModel, employeeStore, modalNavigationStore, contextFactory, sectorStore, departmentStore);
        LeftMenuViewModel = new LeftMenuViewModel();

    }

}
