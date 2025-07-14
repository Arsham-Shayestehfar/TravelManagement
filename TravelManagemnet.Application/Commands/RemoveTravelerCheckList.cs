using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Commands;

namespace TravelManagemnet.Application.Commands
{
    public record RemoveTravelerCheckList(Guid Id) : Icommand;
}
