using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Policies.Temperature
{
    public class HighTemperaturePolicy : ITravelPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
        => new List<TravelerItem>
        {
            new("hat",1),
            new("sunglasses",1),
            new("suncream",1)
        };

        public bool IsApplicable(PolicyData data)
=> data.Temperature > 25D;
    }
}
