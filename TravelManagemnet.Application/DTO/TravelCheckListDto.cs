using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagemnet.Application.DTO
{
    public class TravelCheckListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DestinationDto Destination { get; set; }
        public IEnumerable<TravelItemDto> Items { get; set; }
    }
}
