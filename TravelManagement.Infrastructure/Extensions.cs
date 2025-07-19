using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Infrastructure.EF;
using TravelManagement.Infrastructure.Services;
using TravelManagement.Shared.Abbstraction.Commands;
using TravelManagement.Shared.Queries;
using TravelManagemnet.Application.Services;

namespace TravelManagement.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSQLDB(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, DumbWeatherService>();

            services.TryDecorate(typeof(IcommandHandler<>), typeof(Final_SophieTravelManagement.Infrastructure.Logging.LoggingCommandHandlerDecorator<>));

            return services;
        }
    }
}
