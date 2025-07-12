using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Exeptions;

namespace TravelManagemnet.Domain.Exceptios
{
    public class TravelerCheckListNameException : TravelerCheckListException
    {
        public TravelerCheckListNameException() : base("traveler CheckList name can not be empty")
        {
        }
    }
}
