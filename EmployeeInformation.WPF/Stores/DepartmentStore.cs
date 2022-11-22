using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Departments;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class DepartmentStore : ViewModelBase
    {
        readonly IGetAllDepartmentsQuery _getAllDepartments;

        readonly List<Department> _departments;
        public IEnumerable<Department> Departments => _departments;

        public ObservableCollection<DepartmentListingItemViewModel> _departmentListingItemViewModels;

        public event Action DepartmentsLoaded;


        public DepartmentStore(IGetAllDepartmentsQuery getAllDepartments)
        {
            _getAllDepartments = getAllDepartments;
            _departments = new List<Department>();

            _departmentListingItemViewModels = new ObservableCollection<DepartmentListingItemViewModel>();

            DepartmentsLoaded += DepartmentStore_DepartmentsLoaded;

        }



        public async Task LoadDepartments()
        {
            IEnumerable<Department> departments = await _getAllDepartments.GetAllDepartments();

            _departments.Clear();

            IEnumerable<Department> sortedDepartments = departments.OrderBy(d => d.DepartmentName).ToList();

            _departments.AddRange(sortedDepartments);

            DepartmentsLoaded?.Invoke();
        }


        private void DepartmentStore_DepartmentsLoaded()
        {
            _departmentListingItemViewModels.Clear();
            foreach (Department department in Departments)
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
            DepartmentsLoaded -= DepartmentStore_DepartmentsLoaded;

            base.Dispose();
        }

    }
}
