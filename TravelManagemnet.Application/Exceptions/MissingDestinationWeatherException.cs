using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Exeptions;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Application.Exceptions
{
    internal class MissingDestinationWeatherException: TravelerCheckListException
    {
        public Destination Destination { get; }

        public MissingDestinationWeatherException(Destination destination)
            : base($"Couldn't fetch weather data for Destination '{destination.country}/{destination.city}'.")
        {
            Destination = destination;
        }
    }
}
