using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CostumerData> Costumers { get; set; }
        public DbSet<TransportData> Transports { get; set; }
    }
}