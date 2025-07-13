using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagemnet.Domain.Entities;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagemnet.Domain.Repositories
{
    public interface ITravelerCheckListRepository
    {
        Task<TravelCheckList> GetAsync(TravelerCheckListId id);
        Task AddAsync(TravelCheckList travelerCheckList);
        Task UpdateAsync(TravelCheckList travelerCheckList);
        Task DeleteAsync(TravelCheckList travelerCheckList);
    }
}
