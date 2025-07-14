using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Application.Exceptions;
using TravelManagemnet.Application.Services;
using TravelManagemnet.Domain.Factories;
using TravelManagemnet.Domain.Repositories;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Application.Commands.Handler
{
    internal sealed class CreateTravelerCheckListWithItemsHandler
    {
        private readonly ITravelerCheckListRepository _repository;
        private readonly ITravelCheckListFactory _factory;
        private readonly IWeatherService _weatherService;
        



        public CreateTravelerCheckListWithItemsHandler(ITravelerCheckListRepository repository, ITravelCheckListFactory factory,
            IWeatherService weatherService)
        {
            _repository = repository;
            _factory = factory;
            _weatherService = weatherService;
         
        }

        public async Task HandleAsync(CreateTravelerCheckListWithItems command)
        {
            var (id, name, days, gender, DestinationWriteModel) = command;


            //if (await _readService.ExistsByNameAsync(name))
            //{
            //    throw new TravelerCheckListAlreadyExistsException(name);
            //}


            var destination = new Destination(DestinationWriteModel.City, DestinationWriteModel.Country);
            var weather = await _weatherService.GetWeatherAsync(destination);

            if (weather is null)
            {
                throw new MissingDestinationWeatherException(destination);
            }

            var TravelerCheckList = _factory.CreateWithDefaultItems(id, name, days, gender, weather.temperature,
                destination);

            await _repository.AddAsync(TravelerCheckList);
        }
    }
}
