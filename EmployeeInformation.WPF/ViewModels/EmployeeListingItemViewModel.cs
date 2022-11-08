using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Stores;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels;

public class EmployeeListingItemViewModel : ViewModelBase
{
    public Employee Employee { get; private set; }
    public int DosyaNo => Employee.Id;
    public string Isim => Employee.Isim;
    public string Soyisim => Employee.Soyisim;
    public bool Durum => Employee.Durum;
    public string Departman => Employee.Departman.DepartmentName;
    public string Gorev => Employee.Sector.SectorName;

    public ICommand EditCommand { get; }
    public ICommand DeleteCommand { get; }

    private bool _isDeleting;

    public bool IsDeleting
    {
        get { return _isDeleting; }
        set
        {
            _isDeleting = value;

            OnPropertyChanged(nameof(IsDeleting));
        }
    }



    public EmployeeListingItemViewModel(Employee employee, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore, SectorStore sectorStore, DepartmentStore departmentStore, EducationStore educationStore, MilitaryStore militaryStore, MaritialStore maritialStore)
    {
        Employee = employee;
        EditCommand = new OpenEditEmployeeCommand(this, employeeStore, modalNavigationStore, sectorStore, departmentStore, educationStore, militaryStore, maritialStore);
        DeleteCommand = new DeleteEmployeeCommand(this, employeeStore);
    }


    public void Update(Employee employee)
    {
        Employee = employee;
        OnPropertyChanged(nameof(Isim));
        OnPropertyChanged(nameof(Soyisim));
        OnPropertyChanged(nameof(Departman));
        OnPropertyChanged(nameof(Gorev));
    }
}
