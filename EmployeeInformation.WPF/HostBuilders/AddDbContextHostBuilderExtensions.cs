using EmployeeInformation.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeInformation.WPF.HostBuilders;

public static class AddDbContextHostBuilderExtensions
{
    public static IHostBuilder AddDbContext(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((context, services) =>
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=EmployeeInformationDB;Trusted_Connection=True;";

            services.AddSingleton<DbContextOptions>(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options);
            services.AddSingleton<EmployeesDbContextFactory>();
        });

        return hostBuilder;
    }
}