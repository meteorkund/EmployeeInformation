using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF;
using EmployeeInformation.EF.Commands;
using EmployeeInformation.EF.Queries;
using EmployeeInformation.WPF.HostBuilders;
using EmployeeInformation.WPF.Stores;
using EmployeeInformation.WPF.ViewModels;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
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
                   services.AddSingleton<IGetAllDepartmentsQuery, GetAllDepartmentsQuery>();
                   services.AddSingleton<IGetAllSectorsQuery, GetAllSectorsQuery>();

                   services.AddSingleton<ICreateEmployeeCommand, CreateEmployeeCommand>();
                   services.AddSingleton<IUpdateEmployeeCommand, UpdateEmployeeCommand>();
                   services.AddSingleton<IDeleteEmployeeCommand, DeleteEmployeeCommand>();

                   services.AddSingleton<ModalNavigationStore>();
                   services.AddSingleton<EmployeeStore>();
                   services.AddSingleton<DepartmentStore>();
                   services.AddSingleton<SectorStore>();

                   services.AddSingleton<SelectedEmployeeStore>();

                   services.AddTransient<EmployeesViewModel>();

                   services.AddTransient<EmployeeListingViewModel>(CreateEmployeeListingViewModel);
                   services.AddTransient<DepartmentListingViewModel>(CreateDepartmentListingViewModel);
                   services.AddTransient<SectorListingViewModel>(CreateSectorListingViewModel);

                   services.AddSingleton<MainViewModel>();

                   services.AddSingleton<MainWindow>((services) => new MainWindow
                   {
                       DataContext = services.GetRequiredService<MainViewModel>()
                   });
               })
               .Build();
        }

        private SectorListingViewModel CreateSectorListingViewModel(IServiceProvider services)
        {
            return SectorListingViewModel.LoadSectors
                (
                services.GetRequiredService<SectorStore>()
                );
        }
        private DepartmentListingViewModel CreateDepartmentListingViewModel(IServiceProvider services)
        {
            return DepartmentListingViewModel.LoadDepartments
                (
                services.GetRequiredService<DepartmentStore>()
                );
        }

        private EmployeeListingViewModel CreateEmployeeListingViewModel(IServiceProvider services)
        {
            return EmployeeListingViewModel.LoadViewModel
                (
                services.GetRequiredService<EmployeeStore>(),
                services.GetRequiredService<SelectedEmployeeStore>(),
                services.GetRequiredService<ModalNavigationStore>(),
                services.GetRequiredService<EmployeesDbContextFactory>(),
                services.GetRequiredService<SectorStore>(),
                services.GetRequiredService<DepartmentStore>()
                );
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            if (!AppControl.IsAppRunning("EmployeeInformation"))
            {
                MessageBox.Show("UYGULAMA ZATEN ÇALIŞIYOR!", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                Current.Shutdown();
            }
            else
            {
                _host.Start();

                MainWindow = _host.Services.GetRequiredService<MainWindow>();
                MainWindow.Show();
                base.OnStartup(e);

            }
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }
}
