using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Exeptions;

namespace TravelManagemnet.Domain.Exceptios
{
    public class TravelerCheckListIdException : TravelerCheckListException
    {
        public TravelerCheckListIdException() : base("traveler CheckList ID can not be empty")
        {
        }
    }
}
