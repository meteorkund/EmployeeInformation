using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF.Commands;
using EmployeeInformation.EF.Queries;
using EmployeeInformation.WPF.HostBuilders;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace EmployeeInformation.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
               .AddDbContext()
               .ConfigureServices((context, services) =>
               {

                   services.AddSingleton<IGetAllEmployeesQuery, GetAllEmployeesQuery>();
                   services.AddSingleton<ICreateEmployeeCommand, CreateEmployeeCommand>();
                   services.AddSingleton<IUpdateEmployeeCommand, UpdateEmployeeCommand>();
                   services.AddSingleton<IDeleteEmployeeCommand, DeleteEmployeeCommand>();

                   services.AddSingleton<ModalNavigationStore>();
                   services.AddSingleton<EmployeeStore>();
                   services.AddSingleton<SelectedEmployeeStore>();

                   services.AddTransient<EmployeesViewModel>();
                   services.AddSingleton<MainViewModel>();

                   services.AddSingleton<MainWindow>((services) => new MainWindow
                   {
                       DataContext = services.GetRequiredService<MainViewModel>()
                   });
               })
               .Build();
        }



        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            MainWindow = _host.Services.GetRequiredService<MainWindow>();
            MainWindow.Show();
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}
