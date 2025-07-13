using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Exeptions;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Exceptios
{
    public class InvalidTemperatureException : Exception
    {
        public double Value { get; set; }
        public InvalidTemperatureException(double value) : base($"Value '{value}' is invalid")
        => Value = value;
    }
}
