using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Commands.LoadCommands;
using EmployeeInformation.WPF.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Departments;

public class DepartmentListingViewModel : ViewModelBase
{
    readonly ObservableCollection<DepartmentListingItemViewModel> _departmentListingItemViewModels;
    readonly DepartmentStore _departmentStore;
    public IEnumerable<DepartmentListingItemViewModel> DepartmentListingItemViewModels => _departmentListingItemViewModels;

    public ICommand LoadDepartmentsCommand { get; }

    public DepartmentListingViewModel(DepartmentStore departmentStore)
    {
        _departmentStore = departmentStore;

        _departmentListingItemViewModels = new ObservableCollection<DepartmentListingItemViewModel>();

        LoadDepartmentsCommand = new LoadDepartmentsCommand(this, departmentStore);

        _departmentStore.DepartmentsLoaded += DepartmentStore_DepartmentsLoaded;

    }

    public static DepartmentListingViewModel LoadDepartments(DepartmentStore departmentStore)
    {
        DepartmentListingViewModel viewModel = new DepartmentListingViewModel(departmentStore);
        viewModel.LoadDepartmentsCommand.Execute(null);
        return viewModel;
    }


    private void DepartmentStore_DepartmentsLoaded()
    {
        _departmentListingItemViewModels.Clear();
        foreach (Department department in _departmentStore.Departments)
        {
            AddDepartment(department);
        }
    }


    private void AddDepartment(Department department)
    {
        DepartmentListingItemViewModel itemViewModel = new DepartmentListingItemViewModel(department);

        _departmentListingItemViewModels.Add(itemViewModel);
    }


    protected override void Dispose()
    {

        _departmentStore.DepartmentsLoaded -= DepartmentStore_DepartmentsLoaded;

        base.Dispose();
    }

}

