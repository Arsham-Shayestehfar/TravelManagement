using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Consts;
using TravelManagemnet.Domain.Entities;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Factories
{
    public interface ITravelCheckListFactory
    {
        TravelCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);

        TravelCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Temperature temperature, Destination destination);
    }
}
