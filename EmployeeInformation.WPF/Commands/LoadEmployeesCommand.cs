using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeeInformation.WPF.Commands
{
    public class LoadEmployeesCommand : CommandBase
    {
        readonly EmployeeListingViewModel _employeeListingViewModel;
        readonly EmployeeStore _employeeStore;


        public LoadEmployeesCommand(EmployeeListingViewModel employeeListingViewModel, EmployeeStore employeeStore)
        {
            _employeeListingViewModel = employeeListingViewModel;
            _employeeStore = employeeStore;
        }

        public override async void Execute(object? parameter)
        {
            _employeeListingViewModel.ErrorMessage = null;
            _employeeListingViewModel.IsLoading = true;
            try
            {
                await _employeeStore.Load();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //_employeeListingViewModel.ErrorMessage = "Personeller yüklenirken bir hatayla karşılaşıldı! \n Lütfen uygulamayı yeniden başlatın.";
            }
            finally
            {
                _employeeListingViewModel.IsLoading = false;

            }
        }
    }
}
