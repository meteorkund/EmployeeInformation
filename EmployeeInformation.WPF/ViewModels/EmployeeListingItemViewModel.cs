using EmployeeInformation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EmployeeInformation.WPF.ViewModels
{
    public class EmployeeListingItemViewModel
    {
        public Employee Employee { get; }
        public string Isim => Employee.Isim;
        public string Soyisim => Employee.Soyisim;
        public bool Durum => Employee.Durum;
        public string Departman => Employee.Departman;
        public string Gorev => Employee.Gorev;
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public EmployeeListingItemViewModel(Employee employee)
        {
            Employee = employee;
        }
    }
}
