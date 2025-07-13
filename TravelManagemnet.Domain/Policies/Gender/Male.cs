using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Policies.Gender
{
    public class Male : ITravelPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
            => new List<TravelerItem>
            {
                new("Laptop",1),
                new("book",(uint) Math.Ceiling(data.Days/7m)),
                new("Drink",1)
            };

        public bool IsApplicable(PolicyData data)
         => data.Gender is Consts.Gender.Male;

    }
}
