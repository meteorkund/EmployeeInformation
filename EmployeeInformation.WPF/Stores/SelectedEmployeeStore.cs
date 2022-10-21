using EmployeeInformation.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class SelectedEmployeeStore
    {

        readonly EmployeeStore _employeeStore;
        private Employee _selectedEmployee;

        public SelectedEmployeeStore(EmployeeStore employeeStore)
        {
            _employeeStore = employeeStore;

            _employeeStore.EmployeeUpdated += EmployeeStore_EmployeeUpdated;
        }

        private void EmployeeStore_EmployeeUpdated(Employee employee)
        {
            if (employee.Id == SelectedEmployee?.Id)
                SelectedEmployee = employee;
        }

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                SelectedEmployeeChanged?.Invoke();
            }
        }
        public event Action SelectedEmployeeChanged;



    }
}
