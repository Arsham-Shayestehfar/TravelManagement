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
        TravelCheckList Create(TravelerCheckListId id,TravelerCheckListName name,Destination destination);
        TravelCheckList CreateWithDefailtItems(TravelerCheckListId id, TravelerCheckListName name, Destination destination
          ,Temperature temperature ,Gender gender,TravelDays days );
    }
}
