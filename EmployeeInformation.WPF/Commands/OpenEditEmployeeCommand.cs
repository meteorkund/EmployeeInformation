using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Commands;

public class OpenEditEmployeeCommand : CommandBase
{
    readonly EmployeeListingItemViewModel _employeeListingItemViewModel;
    readonly EmployeeStore _employeeStore;
    readonly SectorStore _sectorStore;
    readonly DepartmentStore _departmentStore;
    readonly ModalNavigationStore _modalNavigationStore;

    public OpenEditEmployeeCommand(EmployeeListingItemViewModel employeeListingItemViewModel, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, SectorStore sectorStore, DepartmentStore departmentStore)
    {
        _employeeListingItemViewModel = employeeListingItemViewModel;
        _employeeStore = employeeStore;
        _sectorStore = sectorStore;
        _departmentStore = departmentStore;
        _modalNavigationStore = modalNavigationStore;

    }

    public override void Execute(object? parameter)
    {
        Employee employee = _employeeListingItemViewModel.Employee;

        EditEmployeeViewModel editEmployeeViewModel = new EditEmployeeViewModel(employee, _employeeStore, _modalNavigationStore, _sectorStore, _departmentStore);
        _modalNavigationStore.CurrentViewModel = editEmployeeViewModel;
    }
}
