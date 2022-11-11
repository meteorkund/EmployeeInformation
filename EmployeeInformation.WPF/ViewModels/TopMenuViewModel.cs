using EmployeeInformation.EF;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Departments;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels;

public class TopMenuViewModel : ViewModelBase
{
    public ICommand AddEmployeeCommand { get; }
    readonly EmployeesDbContextFactory _contextFactory;
    readonly EmployeeListingViewModel _employeeListingViewModel;
    readonly DepartmentListingViewModel _departmentListingViewModel;

    public DepartmentListingViewModel DepartmentListingViewModels { get; set; }

    public EmployeeListingViewModel EmployeeListingViewModel { get; set; }
    public IEnumerable<DepartmentListingItemViewModel> DepartmentListingItemViewModels => _departmentListingViewModel.DepartmentListingItemViewModels;
 

    public TopMenuViewModel(
        EmployeeListingViewModel employeeListingViewModel,
        EmployeeStore employeeStore,
        ModalNavigationStore modalNavigationStore,
        EmployeesDbContextFactory contextFactory,
        SectorStore sectorStore,
        DepartmentStore departmentStore,
        EducationStore educationStore,
        MilitaryStore militaryStore,
        MaritialStore maritialStore)

    {
        _employeeListingViewModel = employeeListingViewModel;
        _contextFactory = contextFactory;

        DepartmentListingViewModels = DepartmentListingViewModel.LoadDepartments(departmentStore);
        _departmentListingViewModel = new DepartmentListingViewModel(departmentStore);

        AddEmployeeCommand = new OpenAddEmployeeCommand(employeeStore, modalNavigationStore, contextFactory, sectorStore, departmentStore, educationStore, militaryStore, maritialStore);
    }


    private string _textToFilter;
    public string TextToFilter
    {
        get { return _textToFilter; }
        set
        {
            _textToFilter = value;
            OnPropertyChanged(nameof(TextToFilter));

            _employeeListingViewModel.EmployeeCollection.Filter = FilterByName;

        }
    }


    private bool _isCheckedRadioActive = true;
    public bool IsCheckedRadioActive
    {
        get { return _isCheckedRadioActive; }
        set
        {
            _isCheckedRadioActive = value;
            OnPropertyChanged(nameof(IsCheckedRadioActive));
            TextToFilter = string.Empty;
            _employeeListingViewModel.EmployeeCollection.Filter = FilterByStatus;
        }
    }

    private bool _isCheckedRadioDeactive =true;
    public bool IsCheckedRadioDeactive
    {
        get { return _isCheckedRadioDeactive; }
        set
        {
            _isCheckedRadioDeactive = value;
            OnPropertyChanged(nameof(IsCheckedRadioDeactive));
            TextToFilter = string.Empty;
            _employeeListingViewModel.EmployeeCollection.Filter = FilterByStatus;
        }
    }

    private bool _isCheckedAllDepartment = true;
    public bool IsCheckedAllDepartment
    {
        get { return _isCheckedAllDepartment; }
        set
        {
            _isCheckedAllDepartment = value;
            OnPropertyChanged(nameof(IsCheckedAllDepartment));
            TextToFilter = string.Empty;
            if (_isCheckedAllDepartment == true)
                SelectedDepartmentName = null;
            _employeeListingViewModel.EmployeeCollection.Filter = FilterByStatus;
        }
    }

    private DepartmentListingItemViewModel _selectedDepartment;
    public DepartmentListingItemViewModel SelectedDepartment
    {
        get { return _selectedDepartment; }
        set
        {
            _selectedDepartment = value;

            TextToFilter = string.Empty;
            SelectedDepartmentName = _selectedDepartment.DepartmentName;
            IsCheckedAllDepartment = false;

            _employeeListingViewModel.EmployeeCollection.Filter = FilterByDepartment;

            OnPropertyChanged(nameof(SelectedDepartment));
        }
    }

    private string _selectedDepartmentName;

    public string SelectedDepartmentName
    {
        get { return _selectedDepartmentName; }
        set
        {
            _selectedDepartmentName = value;
            OnPropertyChanged(nameof(SelectedDepartmentName));
        }
    }


    private bool FilterByName(object emp)
    {
        var empDetail = emp as EmployeeListingItemViewModel;

            if (IsCheckedRadioActive)
            {

                if (string.IsNullOrEmpty(SelectedDepartmentName))
                {
                    return empDetail.Durum.Equals(true)
                           && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
                }
                return empDetail.Durum.Equals(true)
                       && empDetail.Departman.Contains(SelectedDepartmentName)
                       && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));

            }

            if (IsCheckedRadioDeactive)
            {

                if (string.IsNullOrEmpty(SelectedDepartmentName))
                {
                    return empDetail.Durum.Equals(false)
                       && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
                }
                return empDetail.Durum.Equals(false)
                       && empDetail.Departman.Contains(SelectedDepartmentName)
                       && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));

            }

            if (IsCheckedRadioActive && IsCheckedRadioDeactive)
            {
                return empDetail.Departman.Contains(SelectedDepartmentName)
                       && empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter);
            }    


        return true;
    }

    private bool FilterByStatus(object emp)
    {
        var empDetail = emp as EmployeeListingItemViewModel;

        if (IsCheckedRadioActive)
        {
            if (string.IsNullOrEmpty(SelectedDepartmentName))
                return empDetail.Durum.Equals(true);

            return empDetail.Durum.Equals(true) && empDetail.Departman.Contains(SelectedDepartmentName);
        }

        if (IsCheckedRadioDeactive)
        {
            if (string.IsNullOrEmpty(SelectedDepartmentName))
                return empDetail.Durum.Equals(false);

            return empDetail.Durum.Equals(false) && empDetail.Departman.Contains(SelectedDepartmentName);
        }

        if (IsCheckedRadioActive && IsCheckedRadioDeactive)
        {
            if (string.IsNullOrEmpty(SelectedDepartmentName))
                return empDetail != null;
            return empDetail.Departman.Contains(SelectedDepartmentName);
        }
        return true;

    }

    private bool FilterByDepartment(object emp)
    {
        if (IsCheckedRadioActive)
        {
            var empDetail = emp as EmployeeListingItemViewModel;
            return empDetail.Durum.Equals(true) && empDetail.Departman.Contains(SelectedDepartmentName);
        }

        if (IsCheckedRadioDeactive)
        {
            var empDetail = emp as EmployeeListingItemViewModel;
            return empDetail.Durum.Equals(false) && empDetail.Departman.Contains(SelectedDepartmentName);
        }

        if (IsCheckedAllDepartment)
        {
            var empDetail = emp as EmployeeListingItemViewModel;
            return empDetail != null && empDetail.Departman.Contains(SelectedDepartmentName);
        }
        return true;

    }



}
