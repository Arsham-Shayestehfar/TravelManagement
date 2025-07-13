using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Exceptios;

namespace TravelManagemnet.Domain.ValueObject
{
    public class Temperature
    {
        public double Value { get;  }
        public Temperature(double value)
        {
        if (value is < -100 or > 100)
            {
                throw new InvalidTemperatureException(value);
            }
        this.Value = value;
        }
        public static implicit operator double(Temperature temperature)
     => temperature.Value;

        public static implicit operator Temperature(double temperature)
          => new(temperature);
    }
}
