using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Infrastructure.EF.Contexts;
using TravelManagemnet.Domain.Entities;
using TravelManagemnet.Domain.Repositories;
using TravelManagemnet.Domain.ValueObject;

namespace TravelManagement.Infrastructure.EF.Repositories
{
    internal class TravelCheckListRepository:ITravelerCheckListRepository
    {
        private readonly DbSet<TravelCheckList> _travelerCheckList;
        private readonly WriteDbContext _writeDbContext;

        public TravelCheckListRepository(WriteDbContext writeDbContext)
        {
            _travelerCheckList = writeDbContext.TravelerCheckLists;
            _writeDbContext = writeDbContext;
        }

        public Task<TravelCheckList> GetAsync(TravelerCheckListId id)
            => _travelerCheckList.Include("_items").SingleOrDefaultAsync(pl => pl.Id == id);

        public async Task AddAsync(TravelCheckList travelerCheckList)
        {
            await _travelerCheckList.AddAsync(travelerCheckList);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TravelCheckList travelerCheckList)
        {
            _travelerCheckList.Update(travelerCheckList);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TravelCheckList travelerCheckList)
        {
            _travelerCheckList.Remove(travelerCheckList);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}
