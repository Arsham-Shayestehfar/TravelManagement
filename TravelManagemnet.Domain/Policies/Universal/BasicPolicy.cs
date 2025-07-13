using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Policies.Universal
{
    public class BasicPolicy : ITravelPolicy
    {
        private const uint MaximumQuantityOfClothes = 7;
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
            {
                new("pants",Math.Min(data.Days,MaximumQuantityOfClothes)),
                 new ("gloves",Math.Min(data.Days,MaximumQuantityOfClothes)),
                 new("toothpaste",1)
            };


        public bool IsApplicable(PolicyData data)
         => true;
    }
}
