using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Departments;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.EducationDegrees;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.MilitaryServices;
using EmployeeInformation.WPF.ViewModels.ComboBoxesViewModels.Sectors;
using EmployeeInformation.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using EmployeeInformation.EF;
using EmployeeInformation.WPF.Stores;

namespace EmployeeInformation.WPF.HostBuilders;

public static class AddViewModelsHostBuilderExtensions
{
    public static IHostBuilder AddViewModels(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((context, services) =>
        {

            services.AddSingleton<MainViewModel>();
            services.AddTransient<EmployeesViewModel>();

            services.AddTransient<EmployeeListingViewModel>(CreateEmployeeListingViewModel);
            services.AddTransient<DepartmentListingViewModel>(CreateDepartmentListingViewModel);
            services.AddTransient<SectorListingViewModel>(CreateSectorListingViewModel);
            services.AddTransient<EducationListingViewModel>(CreateEducationListingViewModel);
            services.AddTransient<EducationListingViewModel>(CreateEducationListingViewModel);
            services.AddTransient<MilitaryListingViewModel>(CreateMilitaryListingViewModel);


        });

        return hostBuilder;
    }

    private static MilitaryListingViewModel CreateMilitaryListingViewModel(IServiceProvider services)
    {
        return MilitaryListingViewModel.LoadMilitaryServices
            (
            services.GetRequiredService<MilitaryStore>()
            );
    }

    private static EducationListingViewModel CreateEducationListingViewModel(IServiceProvider services)
    {
        return EducationListingViewModel.LoadEducations
            (
            services.GetRequiredService<EducationStore>()
            );
    }

    private static SectorListingViewModel CreateSectorListingViewModel(IServiceProvider services)
    {
        return SectorListingViewModel.LoadSectors
            (
            services.GetRequiredService<SectorStore>()
            );
    }
    private static DepartmentListingViewModel CreateDepartmentListingViewModel(IServiceProvider services)
    {
        return DepartmentListingViewModel.LoadDepartments
            (
            services.GetRequiredService<DepartmentStore>()
            );
    }

    private static EmployeeListingViewModel CreateEmployeeListingViewModel(IServiceProvider services)
    {
        return EmployeeListingViewModel.LoadViewModel
            (
            services.GetRequiredService<EmployeeStore>(),
            services.GetRequiredService<SelectedEmployeeStore>(),
            services.GetRequiredService<ModalNavigationStore>(),
            services.GetRequiredService<EmployeesDbContextFactory>(),
            services.GetRequiredService<SectorStore>(),
            services.GetRequiredService<DepartmentStore>(),
            services.GetRequiredService<EducationStore>(),
            services.GetRequiredService<MilitaryStore>(),
            services.GetRequiredService<MaritialStore>()
            );
    }
}
