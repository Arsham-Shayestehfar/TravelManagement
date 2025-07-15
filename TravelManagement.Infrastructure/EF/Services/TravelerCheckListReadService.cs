using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Infrastructure.EF.Contexts;
using TravelManagement.Infrastructure.EF.Models;
using TravelManagemnet.Application.Services;

namespace TravelManagement.Infrastructure.EF.Services
{
    internal class TravelerCheckListReadService:ITravelerReadCheckList
    {
        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;

        public TravelerCheckListReadService(ReadDbContext context)
            => _travelerCheckList = context.TravelerCheckList;



        public Task<bool> ExistByNameAsync(string name)
            => _travelerCheckList.AnyAsync(pl => pl.Name == name);
    }
}
