using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Policies
{
    public record PolicyData(TravelDays Days,Consts.Gender Gender,ValueObject.Temperature Temperature,
        Destination Destination )
    {
    }
}
