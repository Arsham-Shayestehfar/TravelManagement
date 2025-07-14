using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagement.Shared.Abbstraction.Commands
{
    public interface IcommandHandler<in TCommand> where TCommand : class,Icommand
    {
        Task HandleAsync(TCommand command);
    }
}
