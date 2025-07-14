using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagemnet.Application.DTO
{
    public class TravelItemDto
    {
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public bool IsTaken { get; set; }
    }
}
