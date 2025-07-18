﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Commands;
using TravelManagemnet.Application.Exceptions;
using TravelManagemnet.Domain.Repositories;

namespace TravelManagemnet.Application.Commands.Handler
{
     internal sealed class RemoveTravelerCheckListHandler : IcommandHandler<RemoveTravelerCheckList>, Icommand
     {
       
            private readonly ITravelerCheckListRepository _repository;
        

        public RemoveTravelerCheckListHandler(ITravelerCheckListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(RemoveTravelerCheckList command)
        {
            var TravelerCheckList = await _repository.GetAsync(command.Id);

            if (TravelerCheckList is null)
            {
                throw new TravelerCheckListNotFound(command.Id);
            }

            await _repository.DeleteAsync(TravelerCheckList);
        }
     }
    
}
