using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Queries;
using TravelManagemnet.Application.DTO;

namespace TravelManagemnet.Application.Queries
{
    public class GetTravelerCheckList : IQuery<TravelCheckListDto>
    {
        public Guid  Id { get; set; }
    }
}
