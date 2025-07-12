using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Exceptios;

namespace TravelManagemnet.Domain.ValueObject
{
    public record TravelerItem
    {
        public string Name { get;  }
        public uint Quantity { get;  }
        public bool IsTaken { get; init; }
          public TravelerItem(string name ,uint quantity,bool isTaken = false)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new TravelerItemNameException();
            }
             
            this.Name = name;
                
            this.Quantity = quantity;
            this.IsTaken = isTaken;

        }
    }
}
