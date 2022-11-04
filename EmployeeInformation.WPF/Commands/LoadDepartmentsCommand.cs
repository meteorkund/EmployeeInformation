using EmployeeInformation.WPF.Stores;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands
{
    public class LoadDepartmentsCommand : CommandBase
    {
        readonly DepartmentStore _departmentStore;
        public LoadDepartmentsCommand(DepartmentStore departmentStore)
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
                MessageBox.Show("HATA");
            }
        }
    }
}
