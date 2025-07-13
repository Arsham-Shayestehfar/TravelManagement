using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Exeptions;

namespace TravelManagemnet.Domain.Exceptios
{
     
    public class InvalidTravelDaysException : TravelerCheckListException
    {
        public ushort Days { get; }
        public InvalidTravelDaysException(ushort days) : base($"value {days} is invalid")
          => Days = days;
    }
}
