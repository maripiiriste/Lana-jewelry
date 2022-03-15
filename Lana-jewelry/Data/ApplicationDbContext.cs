using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lana_jewelry.Infra.Shipment;
using Lana_jewelry.Infra;

namespace Lana_jewelry.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder model) {
            base.OnModelCreating(model);
            InitializeTables(model);
        }
        private static void InitializeTables(ModelBuilder model) {
            Lana_jewelryDb.InitializeTables(model);
        }
    }
}