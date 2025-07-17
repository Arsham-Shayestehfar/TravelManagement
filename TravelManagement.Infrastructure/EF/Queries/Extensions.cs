using TravelManagemnet.Application.DTO;
using TravelManagement.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Infrastructure.EF.Models;
using TravelManagemnet.Application.DTO;

namespace TravelManagement.Infrastructure.EF.Queries
{
    internal static class Extensions
    {
        public static TravelCheckListDto AsDto(this TravelerCheckListReadModel readModel)
            => new()
            {
                Id = readModel.Id,
                Name = readModel.Name,
                Destination = new DestinationDto
                {
                    City = readModel.Destination?.City,
                    Country = readModel.Destination?.Country
                },
                Items = readModel.Items?.Select(pi => new TravelItemDto
                {
                    Name = pi.Name,
                    Quantity = pi.Quantity,
                    IsTaken = pi.IsTaken,
                })
            };
    }
}
