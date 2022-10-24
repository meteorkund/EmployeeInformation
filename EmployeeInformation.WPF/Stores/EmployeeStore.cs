using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Models;
using EmployeeInformation.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class EmployeeStore
    {
        readonly IGetAllEmployeesQuery _getAllEmployeesQuery;
        readonly ICreateEmployeeCommand _createEmployeeCommand;
        readonly IUpdateEmployeeCommand _updateEmployeeCommand;
        readonly IDeleteEmployeeCommand _deleteEmployeeCommand;

        readonly List<Employee> _employees;
        public IEnumerable<Employee> Employees => _employees;



        public event Action EmployeesLoaded;
        public event Action<Employee> EmployeeAdded;
        public event Action<Employee> EmployeeUpdated;
        public event Action<Guid> EmployeeDeleted;


        public EmployeeStore(IGetAllEmployeesQuery getAllEmployeesQuery, ICreateEmployeeCommand createEmployeeCommand, IUpdateEmployeeCommand updateEmployeeCommand, IDeleteEmployeeCommand deleteEmployeeCommand)
        {
            _getAllEmployeesQuery = getAllEmployeesQuery;
            _createEmployeeCommand = createEmployeeCommand;
            _updateEmployeeCommand = updateEmployeeCommand;
            _deleteEmployeeCommand = deleteEmployeeCommand;

            _employees = new List<Employee>();
        }

        public async Task Add(Employee employee)
        {
            await _createEmployeeCommand.Execute(employee);

            _employees.Add(employee);

            EmployeeAdded?.Invoke(employee);
        }

        public async Task Update(Employee employee)
        {
            await _updateEmployeeCommand.Execute(employee);

            int currentIndex = _employees.FindIndex(e => e.Id == employee.Id);

            if (currentIndex != -1)
                _employees[currentIndex] = employee;
            else
                _employees.Add(employee);

            EmployeeUpdated?.Invoke(employee);
        }

        public async Task Load()
        {
            IEnumerable<Employee> employees = await _getAllEmployeesQuery.Execute();

            _employees.Clear();
            _employees.AddRange(employees);

            EmployeesLoaded?.Invoke();
        }

        public async Task Delete(Guid id)
        {
            await _deleteEmployeeCommand.Execute(id);

            _employees.RemoveAll(e => e.Id == id);

            EmployeeDeleted?.Invoke(id);
        }
    }
}
