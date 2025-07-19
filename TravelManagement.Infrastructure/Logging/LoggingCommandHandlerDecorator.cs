using TravelManagement.Shared.Abbstraction.Commands;
using Microsoft.Extensions.Logging;


namespace Final_SophieTravelManagement.Infrastructure.Logging
{
    internal sealed class LoggingCommandHandlerDecorator<TCommand> : IcommandHandler<TCommand> where TCommand : class, Icommand
    {
        private readonly IcommandHandler<TCommand> _commandHandler;
        private readonly ILogger<LoggingCommandHandlerDecorator<TCommand>> _logger;

        public LoggingCommandHandlerDecorator(IcommandHandler<TCommand> commandHandler,
            ILogger<LoggingCommandHandlerDecorator<TCommand>> logger)
        {
            _commandHandler = commandHandler;
            _logger = logger;
        }

        public async Task HandleAsync(TCommand command)
        {
            var commandType = command.GetType().Name;

            try
            {
                _logger.LogInformation($"Started processing {commandType} command.");
                await _commandHandler.HandleAsync(command);
                _logger.LogInformation($"Finished processing {commandType} command.");

            }
            catch
            {
                _logger.LogError($"Failed to process {commandType} command.");
                throw;
            }
        }
    }
}
