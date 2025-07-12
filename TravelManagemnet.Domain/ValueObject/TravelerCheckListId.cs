using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Exceptios;

namespace TravelManagemnet.Domain.ValueObject
{
    public record TravelerCheckListId
    {
        public Guid Value { get; }
        public TravelerCheckListId(Guid value)
        {
            if(value ==null)
                throw new TravelerCheckListIdException();
            Value = value;
        }

        public static implicit operator Guid(TravelerCheckListId id) 
            => id.Value;

        public static implicit operator TravelerCheckListId(Guid id)
          => new(id);
    }
}
