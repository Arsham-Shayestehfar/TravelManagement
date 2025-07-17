using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Factories;
using TravelManagemnet.Domain.Policies;
using TravelManagement.Shared.Commands;

namespace TravelManagemnet.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddCommands();
            services.AddSingleton<ITravelCheckListFactory, TravelCheckListFactory>();

            services.Scan(b => b.FromAssemblies(typeof(ITravelPolicy).Assembly)
                .AddClasses(c => c.AssignableTo<ITravelPolicy>())
                .AsImplementedInterfaces()
                .WithSingletonLifetime());

            return services;
        }
    }
}
