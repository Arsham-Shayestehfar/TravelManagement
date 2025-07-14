using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Application.DTO.External;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(Destination destination);
    }
}
