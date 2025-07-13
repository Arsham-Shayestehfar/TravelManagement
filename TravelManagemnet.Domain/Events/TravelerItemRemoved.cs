using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Domain;
using TravelManagemnet.Domain.Entities;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Events
{
    public record TravelerItemRemoved(TravelCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent;

}
