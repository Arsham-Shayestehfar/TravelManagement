using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Policies
{
    public interface ITravelPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<TravelerItem> GenerateItems(PolicyData data);
    }
}
