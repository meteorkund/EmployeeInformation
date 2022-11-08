using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Departments;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands.LoadCommands
{
    public class LoadDepartmentsCommand : CommandBase
    {
        readonly DepartmentStore _departmentStore;
        public LoadDepartmentsCommand(DepartmentListingViewModel departmentListingViewModel, DepartmentStore departmentStore)
        {
            _departmentStore = departmentStore;
        }

        public override async void Execute(object? parameter)
        {
            try
            {
                await _departmentStore.LoadDepartments();
            }
            catch
            {
                MessageBox.Show("DEPARTMANLAR YÜKLENİRKEN HATAYLA KARŞILAŞILDI!");
            }
        }
    }
}
