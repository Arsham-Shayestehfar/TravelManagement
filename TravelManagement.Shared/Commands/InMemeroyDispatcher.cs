using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TravelManagement.Shared.Abbstraction.Commands;

namespace TravelManagement.Shared.Commands
{
    internal sealed class InMemeroyDispatcher: ICommandDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public InMemeroyDispatcher(IServiceProvider serviceProvider)
            => _serviceProvider = serviceProvider;

        public async Task DispatchAsync<TCommand>(TCommand command) where TCommand : class, Icommand
        {
            using var scope = _serviceProvider.CreateScope();
            var handler = scope.ServiceProvider.GetRequiredService<IcommandHandler<TCommand>>();

            await handler.HandleAsync(command);
        }
    }
}
