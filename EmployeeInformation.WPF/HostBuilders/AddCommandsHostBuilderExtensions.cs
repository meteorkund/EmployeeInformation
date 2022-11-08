using EmployeeInformation.Domain.Commands;
using EmployeeInformation.Domain.Queries;
using EmployeeInformation.EF.Commands;
using EmployeeInformation.EF.Queries;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.HostBuilders
{
    public static class AddCommandsHostBuilderExtensions
    {
        public static IHostBuilder AddCommands(this IHostBuilder hostBuilder)
        {
            hostBuilder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<ICreateEmployeeCommand, CreateEmployeeCommand>();
                services.AddSingleton<IUpdateEmployeeCommand, UpdateEmployeeCommand>();
                services.AddSingleton<IDeleteEmployeeCommand, DeleteEmployeeCommand>();

            });

            return hostBuilder;
        }
    }
}
