﻿using EmployeeInformation.Domain.Models.Common;
using EmployeeInformation.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class DepartmentStore
    {
        readonly IGetAllDepartmentsQuery _getAllDepartments;

        readonly List<Department> _departments;
        public IEnumerable<Department> Departments => _departments;

        public event Action DepartmentsLoaded;


        public DepartmentStore(IGetAllDepartmentsQuery getAllDepartments)
        {
            _getAllDepartments = getAllDepartments;
            _departments = new List<Department>();
        }



        public async Task LoadDepartments()
        {
            IEnumerable<Department> departments = await _getAllDepartments.GetAllDepartments();

            _departments.Clear();

            IEnumerable<Department> sortedDepartments = departments.OrderBy(d=> d.DepartmentName).ToList();

            _departments.AddRange(sortedDepartments);

            DepartmentsLoaded?.Invoke();
        }

    }
}
