using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Infra.Shipment;

namespace Lana_jewelry.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            Lana_jewelryDb.CreateTable(builder);
        }
    }
}