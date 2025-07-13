using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Consts;
using TravelManagemnet.Domain.Entities;
using TravelManagemnet.Domain.Policies;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Factories
{
    public sealed class TravelCheckListFactory:ITravelCheckListFactory
    {
        private readonly IEnumerable<ITravelPolicy> _policies;


        public TravelCheckListFactory(IEnumerable<ITravelPolicy> policies)
            => _policies = policies;

        public TravelCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
            => new(id, name, destination);

        public TravelCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Temperature temperature, Destination destination)
        {
            var data = new PolicyData(days, gender, temperature, destination);
            var applicablePolicies = _policies.Where(p => p.IsApplicable(data));

            var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
            var travelerCheckingList = Create(id, name, destination);

            travelerCheckingList.AddItems(items);

            return travelerCheckingList;
        }
    }
}
