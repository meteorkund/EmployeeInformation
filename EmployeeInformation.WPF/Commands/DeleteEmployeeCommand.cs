using EmployeeInformation.Domain.Models;
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
    public class DeleteEmployeeCommand : AsyncCommandBase
    {
        readonly EmployeeStore _employeeStore;
        readonly EmployeeListingItemViewModel _employeeListingItemViewModel;

        public DeleteEmployeeCommand(EmployeeListingItemViewModel employeeListingItemViewModel, EmployeeStore employeeStore)
        {
            _employeeListingItemViewModel = employeeListingItemViewModel;
            _employeeStore = employeeStore;

        }

        public override async Task ExecuteAsync(object? parameter)
        {
            string message = "Personeli silmek istediğinize emin misiniz";
            string caption = "Dikkat!";
            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxImage icon = MessageBoxImage.Warning;

            if (MessageBox.Show(message, caption, buttons, icon) == MessageBoxResult.Yes)
            {
                _employeeListingItemViewModel.IsDeleting = true;

                Employee employee = _employeeListingItemViewModel.Employee;

                try
                {
                    await _employeeStore.Delete(employee.Id);

                }
                catch (Exception)
                {
                    MessageBox.Show("Personel silinirken hatayla karşılaşıldı!", "Hata!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                finally
                {
                    _employeeListingItemViewModel.IsDeleting = false;

                }

            }




        }
    }
}
