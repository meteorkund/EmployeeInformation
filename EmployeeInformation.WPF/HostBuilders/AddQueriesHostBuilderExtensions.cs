using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF.Queries;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeInformation.WPF.HostBuilders;

public static class AddQueriesHostBuilderExtensions
{
    public static IHostBuilder AddQueries(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((context, services) =>
        {

            services.AddSingleton<IGetAllEmployeesQuery, GetAllEmployeesQuery>();

            services.AddSingleton<IGetAllDepartmentsQuery, GetAllDepartmentsQuery>();
            services.AddSingleton<IGetAllSectorsQuery, GetAllSectorsQuery>();
            services.AddSingleton<IGetAllEducationsQuery, GetAllEducationsQuery>();
            services.AddSingleton<IGetAllMilitaryServicesQuery, GetAllMilitaryServicesQuery>();
            services.AddSingleton<IGetAllMaritialStatusQuery, GetAllMaritialStatusQuery>();

        });

        return hostBuilder;
    }
}
