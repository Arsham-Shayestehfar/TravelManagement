﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Queries;

namespace TravelManagement.Shared.Queries
{
    public static class Extensions
    {
        public static IServiceCollection AddQueries(this IServiceCollection services)
        {
            var assembly = Assembly.GetCallingAssembly();

            services.AddSingleton<IQueryDispatcher, InMemoryQueryDispatcher>();
            services.Scan(s => s.FromAssemblies(assembly)
                .AddClasses(c => c.AssignableTo(typeof(IQueryHandler<,>)))
                .AsImplementedInterfaces()
                .WithScopedLifetime());

            return services;
        }
    }
}
