using TravelManagemnet.Domain.Entities;
using TravelManagemnet.Domain.ValueObject;
using TravelManagement.Infrastructure.EF.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelManagement.Infrastructure.EF.Contexts
{
    internal sealed class WriteDbContext : DbContext
    {
        public DbSet<TravelCheckList> TravelerCheckLists { get; set; }




        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TravelerCheckList");

            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<TravelCheckList>(configuration);
            modelBuilder.ApplyConfiguration<TravelerItem>(configuration);
        }
    }
}
