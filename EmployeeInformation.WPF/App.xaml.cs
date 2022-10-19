using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
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
        public App()
        {
            _selectedEmployeeStore = new SelectedEmployeeStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new EmployeesViewModel(_selectedEmployeeStore)
            };
            MainWindow.Topmost = true;
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
