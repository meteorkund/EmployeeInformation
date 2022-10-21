using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Models;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF;
using EmployeeInformation.EF.Commands;
using EmployeeInformation.EF.Queries;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        readonly SelectedEmployeeStore _selectedEmployeeStore;
        readonly ModalNavigationStore _modalNavigationStore;
        readonly EmployeeStore _employeeStore;

        readonly EmployeesDbContextFactory _employeesDbContextFactory;

        readonly IGetAllEmployeesQuery _getAllEmployeesQuery;
        readonly ICreateEmployeeCommand _createEmployeeCommand;
        readonly IUpdateEmployeeCommand _updateEmployeeCommand;
        readonly IDeleteEmployeeCommand _deleteEmployeeCommand;


        public App()
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=EmployeeInformationDB;Trusted_Connection=True;";

            _modalNavigationStore = new ModalNavigationStore();

            _employeesDbContextFactory = new EmployeesDbContextFactory(
                new DbContextOptionsBuilder().UseSqlServer(connectionString).Options);

            _getAllEmployeesQuery = new GetAllEmployeesQuery(_employeesDbContextFactory);
            _createEmployeeCommand = new CreateEmployeeCommand(_employeesDbContextFactory);
            _updateEmployeeCommand = new UpdateEmployeeCommand(_employeesDbContextFactory);
            _deleteEmployeeCommand = new DeleteEmployeeCommand(_employeesDbContextFactory);
            _employeeStore = new EmployeeStore(_getAllEmployeesQuery,_createEmployeeCommand,_updateEmployeeCommand,_deleteEmployeeCommand);
            _selectedEmployeeStore = new SelectedEmployeeStore(_employeeStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            EmployeesViewModel employeesViewModel = new EmployeesViewModel(
                _employeeStore,
                _selectedEmployeeStore, 
                _modalNavigationStore
                );

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, employeesViewModel)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
