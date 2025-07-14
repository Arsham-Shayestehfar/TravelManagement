using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Commands;
using TravelManagemnet.Domain.Consts;

namespace TravelManagemnet.Application.Commands
{
    public record CreateTravelerCheckListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
        DestinationWriteModel Destionation) : Icommand;

    public record DestinationWriteModel(string City, string Country);
}
