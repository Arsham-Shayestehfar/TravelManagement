using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Commands;
using TravelManagemnet.Application.Exceptions;
using TravelManagemnet.Domain.Repositories;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Application.Commands.Handler
{
    public class AddTravelerItemHandler : IcommandHandler<AddTravelerItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public AddTravelerItemHandler(ITravelerCheckListRepository repository)
        {
            _repository = repository;
        }
        public async Task HandleAsync(AddTravelerItem command)
        {
            var travelerCheckingList = await _repository.GetAsync(command.TravelerCheckListId);
            if (travelerCheckingList is null)
            {
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);
            }
            var travelerItem = new TravelerItem(command.Name, command.Quantity);
            travelerCheckingList.AddItem(travelerItem);
            await _repository.UpdateAsync(travelerCheckingList);


        }
    }
}
