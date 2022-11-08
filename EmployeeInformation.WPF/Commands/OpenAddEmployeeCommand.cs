using EmployeeInformation.EF;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;

namespace EmployeeInformation.WPF.Commands
{
    public class OpenAddEmployeeCommand : CommandBase
    {
        readonly ModalNavigationStore _modalNavigationStore;
        readonly EmployeeStore _employeeStore;
        readonly SectorStore _sectorStore;
        readonly DepartmentStore _departmentStore;
        readonly EducationStore _educationStore;
        readonly MilitaryStore _militaryStore;
        readonly MaritialStore _maritialStore;

        readonly EmployeesDbContextFactory _contextFactory;

        public OpenAddEmployeeCommand(EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, SectorStore sectorStore, DepartmentStore departmentStore, EducationStore educationStore, MilitaryStore militaryStore, MaritialStore maritialStore)
        {
            _employeeStore = employeeStore;
            _sectorStore = sectorStore;
            _departmentStore = departmentStore;
            _educationStore = educationStore;
            _militaryStore = militaryStore;
            _maritialStore = maritialStore;
            _modalNavigationStore = modalNavigationStore;
            _contextFactory = contextFactory;

        }

        public override void Execute(object? parameter)
        {
            AddEmployeeViewModel addEmployeeViewModel = new AddEmployeeViewModel(_employeeStore, _modalNavigationStore, _contextFactory, _sectorStore, _departmentStore, _educationStore, _militaryStore,_maritialStore);

            _modalNavigationStore.CurrentViewModel = addEmployeeViewModel;
        }
    }
}
