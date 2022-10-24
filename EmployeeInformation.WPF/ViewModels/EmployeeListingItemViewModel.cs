using EmployeeInformation.Domain.Models;
using EmployeeInformation.WPF.Commands;
using EmployeeInformation.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeListingItemViewModel : ViewModelBase
    {
        public Employee Employee { get; private set; }
        public int DosyaNo => Employee.Id;
        public string Isim => Employee.Isim;
        public string Soyisim => Employee.Soyisim;
        public bool Durum => Employee.Durum;
        public string Departman => Employee.Departman;
        public string Gorev => Employee.Gorev;
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



        public EmployeeListingItemViewModel(Employee employee, EmployeeStore employeeStore, ModalNavigationStore modalNavigationStore)
        {
            Employee = employee;
            EditCommand = new OpenEditEmployeeCommand(this, employeeStore, modalNavigationStore);
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
}
