using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Exceptios;

namespace TravelManagemnet.Domain.ValueObject
{
    public class TravelerCheckListName
    {
        public string Value { get;  }
        public TravelerCheckListName( string value)
        {
            if (value == null) throw new TravelerCheckListNameException();
            this.Value = value;
        }

        public static implicit operator string (TravelerCheckListName name)
        => name.Value;
        public static implicit operator TravelerCheckListName (string name)
            => new(name);
    }
}
