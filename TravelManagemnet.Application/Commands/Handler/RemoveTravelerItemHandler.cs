using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Commands;
using TravelManagemnet.Application.Exceptions;
using TravelManagemnet.Domain.Repositories;

namespace TravelManagemnet.Application.Commands.Handler
{
    internal sealed class RemoveTravelerItemHandler:IcommandHandler<RemoveTravelerItem>
    {
        private readonly ITravelerCheckListRepository _repository;

        public RemoveTravelerItemHandler(ITravelerCheckListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(RemoveTravelerItem command)
        {
            var travelerCheckingList = await _repository.GetAsync(command.TravelerCheckListId);

            if (travelerCheckingList is null)
            {
                throw new TravelerCheckListNotFound(command.TravelerCheckListId);
            }

            travelerCheckingList.RemoveItem(command.Name);

            await _repository.UpdateAsync(travelerCheckingList);
        }

    }
}
