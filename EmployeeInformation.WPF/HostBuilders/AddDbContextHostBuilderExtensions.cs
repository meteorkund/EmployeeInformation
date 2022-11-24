using EmployeeInformation.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace EmployeeInformation.WPF.HostBuilders;

public static class AddDbContextHostBuilderExtensions
{
    public static IHostBuilder AddDbContext(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((context, services) =>
        {
            var connectionString = $"DataSource={Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PERSONEL_DB\\personelData.db;";


            services.AddSingleton<DbContextOptions>(new DbContextOptionsBuilder().UseSqlite(connectionString).Options);
            services.AddSingleton<EmployeesDbContextFactory>();
        });

        return hostBuilder;
    }
}