using EmployeeInformation.Domain.Models;
using EmployeeInformation.EF;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Commands.LoadCommands;
using EmployeeInformation.WPF.Stores;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeListingViewModel : ViewModelBase
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;

        readonly ObservableCollection<EmployeeListingItemViewModel> _employeeListingItemViewModels;

        readonly EmployeeStore _employeeStore;
        readonly SectorStore _sectorStore;
        readonly DepartmentStore _departmentStore;
        readonly EducationStore _educationStore;
        readonly MilitaryStore _militaryStore;
        readonly MaritialStore _maritialStore;

        readonly ModalNavigationStore _modalNavigationStore;
        readonly EmployeesDbContextFactory _contextFactory;

        public IEnumerable<EmployeeListingItemViewModel> EmployeeListingItemViewModels => _employeeListingItemViewModels;


        public EmployeeListingItemViewModel SelectedEmployeeListingItemViewModel
        {
            get
            {
                return _employeeListingItemViewModels
                    .FirstOrDefault(e => e.Employee?.Id == _selectedEmployeeStore.SelectedEmployee?.Id);

            }
            set
            {
                _selectedEmployeeStore.SelectedEmployee = value?.Employee;
                OnPropertyChanged(nameof(SelectedEmployeeListingItemViewModel));
            }
        }

        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                OnPropertyChanged(nameof(IsLoading));
            }
        }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
                OnPropertyChanged(nameof(HasErrorMessage));
            }
        }
        public bool HasErrorMessage => !string.IsNullOrWhiteSpace(ErrorMessage);


        private ICollectionView _employeeCollection;
        public ICollectionView EmployeeCollection
        {
            get { return _employeeCollection; }
            set { _employeeCollection = value; }
        }

        public TopMenuViewModel TopMenuViewModel { get; set; }

        public ICommand LoadEmployeesCommand { get; }
        public ICommand LoadComboBoxItemsCommand { get; }

        public EmployeeListingViewModel(EmployeeStore employeeStore, SelectedEmployeeStore selectedEmployeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, SectorStore sectorStore, DepartmentStore departmentStore, EducationStore educationStore, MilitaryStore militaryStore, MaritialStore maritialStore)
        {
            _contextFactory = contextFactory;

            _selectedEmployeeStore = selectedEmployeeStore;
            _modalNavigationStore = modalNavigationStore;

            _employeeStore = employeeStore;
            _sectorStore = sectorStore;
            _departmentStore = departmentStore;
            _educationStore = educationStore;
            _militaryStore = militaryStore;
            _maritialStore = maritialStore;


            _employeeListingItemViewModels = new ObservableCollection<EmployeeListingItemViewModel>();

            EmployeeCollection = CollectionViewSource.GetDefaultView(_employeeListingItemViewModels);

            LoadEmployeesCommand = new LoadEmployeesCommand(this, employeeStore);
            LoadComboBoxItemsCommand = new LoadComboBoxItemsCommand(departmentStore, educationStore, maritialStore, militaryStore, sectorStore);

            _employeeStore.EmployeesLoaded += EmployeeStore_EmployeesLoaded;
            _employeeStore.EmployeeAdded += EmployeeStore_EmployeeAdded;
            _employeeStore.EmployeeUpdated += EmployeeStore_EmployeeUpdated;
            _employeeStore.EmployeeDeleted += EmployeeStore_EmployeeDeleted;



        }

        public static EmployeeListingViewModel LoadViewModel(EmployeeStore employeeStore, SelectedEmployeeStore selectedEmployeeStore, ModalNavigationStore modalNavigationStore, EmployeesDbContextFactory contextFactory, SectorStore sectorStore, DepartmentStore departmentStore, EducationStore educationStore, MilitaryStore militaryStore, MaritialStore maritialStore)
        {
            EmployeeListingViewModel viewModel = new EmployeeListingViewModel(employeeStore, selectedEmployeeStore, modalNavigationStore, contextFactory, sectorStore, departmentStore, educationStore, militaryStore, maritialStore);
            viewModel.LoadEmployeesCommand.Execute(null);
            viewModel.LoadComboBoxItemsCommand.Execute(null);
            return viewModel;
        }


        protected override void Dispose()
        {
            _employeeStore.EmployeesLoaded -= EmployeeStore_EmployeesLoaded;
            _employeeStore.EmployeeAdded -= EmployeeStore_EmployeeAdded;
            _employeeStore.EmployeeUpdated -= EmployeeStore_EmployeeUpdated;
            _employeeStore.EmployeeDeleted -= EmployeeStore_EmployeeDeleted;

            base.Dispose();
        }


        private void EmployeeStore_EmployeesLoaded()
        {
            _employeeListingItemViewModels.Clear();
            foreach (Employee employee in _employeeStore.Employees)
            {
                AddEmployee(employee);
            }
        }
        private void EmployeeStore_EmployeeAdded(Employee employee)
        {
            AddEmployee(employee);
        }

        private void EmployeeStore_EmployeeUpdated(Employee employee)
        {
            EmployeeListingItemViewModel employeeViewModel = _employeeListingItemViewModels.FirstOrDefault(e => e.Employee.Id == employee.Id);

            if (employeeViewModel != null)
                employeeViewModel.Update(employee);
        }


        private void EmployeeStore_EmployeeDeleted(int id)
        {
            EmployeeListingItemViewModel itemViewModel = _employeeListingItemViewModels.FirstOrDefault(e => e.Employee?.Id == id);

            if (itemViewModel != null)
                _employeeListingItemViewModels.Remove(itemViewModel);

        }



        private void AddEmployee(Employee employee)
        {
            EmployeeListingItemViewModel itemViewModel = new EmployeeListingItemViewModel(employee, _employeeStore, _modalNavigationStore, _sectorStore, _departmentStore, _educationStore, _militaryStore, _maritialStore);
            _employeeListingItemViewModels.Add(itemViewModel);
        }


    }

}
