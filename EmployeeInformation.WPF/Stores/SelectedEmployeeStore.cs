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
        private Employee _selectedEmployee;

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
