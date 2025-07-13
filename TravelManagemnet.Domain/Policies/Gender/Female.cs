using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Policies.Gender
{
    public class Female : ITravelPolicy
    {
        public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
         => new List<TravelerItem>
         {
             new("Lipstick",1),
             new ("Powder",1),
             new("EyeLiner",1)

         };

        public bool IsApplicable(PolicyData data)
            => data.Gender is Consts.Gender.Female;

        
    }
}
