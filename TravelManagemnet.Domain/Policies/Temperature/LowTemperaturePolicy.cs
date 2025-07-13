using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Policies.Temperature
{
    public class LowTemperaturePolicy : ITravelPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
            {
                new("scarf",1),
                 new ("gloves",1)
            };


        public bool IsApplicable(PolicyData data)
         => data.Temperature < 10D;
    }
}
