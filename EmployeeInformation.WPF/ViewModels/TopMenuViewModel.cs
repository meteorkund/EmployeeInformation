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


    private string _textToFilter = string.Empty;
    public string TextToFilter
    {
        get { return _textToFilter; }
        set
        {
            _textToFilter = value;
            OnPropertyChanged(nameof(TextToFilter));

            _employeeListingViewModel.EmployeeCollection.Filter = FilterEmployee;

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
            _employeeListingViewModel.EmployeeCollection.Filter = FilterEmployee;
        }
    }

    private bool _isCheckedRadioDeactive = true;
    public bool IsCheckedRadioDeactive
    {
        get { return _isCheckedRadioDeactive; }
        set
        {
            _isCheckedRadioDeactive = value;
            OnPropertyChanged(nameof(IsCheckedRadioDeactive));
            _employeeListingViewModel.EmployeeCollection.Filter = FilterEmployee;
        }
    }

    private bool _isVisibleCBox;
    public bool IsVisibleCBox
    {
        get { return !_isCheckedAllDepartment; }
        set
        {
            _isVisibleCBox = value;
            OnPropertyChanged(nameof(IsVisibleCBox));
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
            OnPropertyChanged(nameof(IsVisibleCBox));
            if (_isCheckedAllDepartment == true)
                SelectedDepartmentName = string.Empty;
            _employeeListingViewModel.EmployeeCollection.Filter = FilterEmployee;
        }
    }

    private DepartmentListingItemViewModel _selectedDepartment;
    public DepartmentListingItemViewModel SelectedDepartment
    {
        get { return _selectedDepartment; }
        set
        {
            _selectedDepartment = value;

            SelectedDepartmentName = _selectedDepartment.DepartmentName;

            _employeeListingViewModel.EmployeeCollection.Filter = FilterEmployee;

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


    private bool FilterEmployee(object emp)
    {
        var empDetail = emp as EmployeeListingItemViewModel;

        if (IsCheckedAllDepartment == true)
        {
            if (IsCheckedRadioActive == true && IsCheckedRadioDeactive == false)
            {
                return empDetail.Durum.Equals(true) && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
            }

            if (IsCheckedRadioDeactive == true && IsCheckedRadioActive == false)
            {
                return empDetail.Durum.Equals(false) && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
            }

            if (IsCheckedRadioActive == true && IsCheckedRadioDeactive == true)
            {
                return (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
            }

            if (IsCheckedRadioActive == false && IsCheckedRadioDeactive == false)
            {
                return false;
            }
        }

        if (IsCheckedAllDepartment == false)
        {
            if (IsCheckedRadioActive == true && IsCheckedRadioDeactive == false)
            {
                return empDetail.Durum.Equals(true)
                    && empDetail.Departman.Contains(SelectedDepartmentName)
                    && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
            }

            if (IsCheckedRadioDeactive == true && IsCheckedRadioActive == false)
            {
                return empDetail.Durum.Equals(false)
                    && empDetail.Departman.Contains(SelectedDepartmentName)
                    && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
            }

            if (IsCheckedRadioActive == true && IsCheckedRadioDeactive == true)
            {
                return empDetail.Departman.Contains(SelectedDepartmentName)
                    && (empDetail.Isim.Contains(TextToFilter) || empDetail.Soyisim.Contains(TextToFilter));
            }

            if (IsCheckedRadioActive == false && IsCheckedRadioDeactive == false)
            {
                return false;
            }
        }

        return true;
    }
}
