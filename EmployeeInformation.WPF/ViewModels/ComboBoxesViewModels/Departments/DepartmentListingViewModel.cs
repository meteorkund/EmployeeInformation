using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.WPF.Commands.LoadCommands;
using EmployeeInformation.WPF.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Departments;

public class DepartmentListingViewModel : ViewModelBase
{
    readonly DepartmentStore _departmentStore;
    public IEnumerable<DepartmentListingItemViewModel> DepartmentListingItemViewModels => _departmentStore._departmentListingItemViewModels;

    public DepartmentListingViewModel(EmployeeDetailsFormViewModel employeeDetailsFormViewModel, DepartmentStore departmentStore)
    {
        _departmentStore = departmentStore;

    }




}

