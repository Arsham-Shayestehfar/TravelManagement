using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagemnet.Application.Services
{
    public interface ITravelerReadCheckList
    {
        Task<bool> ExistByNameAsync(string name);
    }
}
