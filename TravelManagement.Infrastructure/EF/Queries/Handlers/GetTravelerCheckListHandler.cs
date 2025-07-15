using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abbstraction.Queries;
using TravelManagemnet.Application.DTO;
using TravelManagemnet.Application.Queries;
using TravelManagemnet.Domain.Entities;
using TravelManagemnet.Domain.Repositories;

namespace TravelManagement.Infrastructure.EF.Queries.Handlers
{
    public class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelCheckListDto>
    {
        private readonly ITravelerCheckListRepository _repository;
        public GetTravelerCheckListHandler(ITravelerCheckListRepository repo)
        {
            _repository = repo;
        }
        public async Task<TravelCheckListDto> HandleAsync(GetTravelerCheckList query)
        {
           var travelerCheckCist = await _repository.GetAsync(query.Id);
            //Needs Come Back
            return null;
        }
    }
}
