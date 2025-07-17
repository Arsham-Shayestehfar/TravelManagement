using TravelManagemnet.Application.DTO.External;
using TravelManagemnet.Application.Services;
using TravelManagemnet.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagement.Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Destination destination)
            => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}
