using EmployeeInformation.WPF.Stores;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeInformation.WPF.HostBuilders;

public static class AddStoresHostBuilderExtensions
{
    public static IHostBuilder AddStores(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((context, services) =>
        {

            services.AddSingleton<ModalNavigationStore>();

            services.AddSingleton<EmployeeStore>();
            services.AddSingleton<DepartmentStore>();
            services.AddSingleton<SectorStore>();
            services.AddSingleton<EducationStore>();
            services.AddSingleton<MilitaryStore>();
            services.AddSingleton<MaritialStore>();

            services.AddSingleton<SelectedEmployeeStore>();

        });

        return hostBuilder;
    }
}
