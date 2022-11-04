using EmployeeInformation.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels
{
    public class DepartmentListingItemViewModel : ViewModelBase
    {
        public Department Department { get; private set; }

        public int DepartmentId => Department.Id;
        public string DepartmentName => Department.DepartmentName;

        public DepartmentListingItemViewModel(Department department)
        {
            Department = department;
        }

    }
}
