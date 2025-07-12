using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Exeptions;

namespace TravelManagemnet.Domain.Exceptios
{
    public class TravelerItemNameException : TravelerCheckListException
    {
        public TravelerItemNameException() : base("traveler item name can not be empty")
        {
        }
    }
}
