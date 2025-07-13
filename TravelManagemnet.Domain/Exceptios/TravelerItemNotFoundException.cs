using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Exeptions;

namespace TravelManagemnet.Domain.Exceptios
{
    public class TravelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; set; }
        public TravelerItemNotFoundException(string itemName) : base($"Traveler Item '{itemName}' is empty")
            => ItemName = itemName;
    }
}
