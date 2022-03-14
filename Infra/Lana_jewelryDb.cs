using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra{
   public sealed class Lana_jewelryDb:DbContext{
        public Lana_jewelryDb(DbContextOptions<Lana_jewelryDb> options) : base(options) { }
        public DbSet<TransportData> Transports { get; set; }
        public DbSet<CostumerData> Costumers { get; set; }
        protected override void OnModelCreating(ModelBuilder model) {
            base.OnModelCreating(model);
            InitializeTables(model);
        }
        public static void InitializeTables(ModelBuilder model) {
            model?.Entity<CostumerData>()?.ToTable(nameof(Costumers), nameof(Lana_jewelryDb).Substring(0, 14));
            model?.Entity<TransportData>()?.ToTable(nameof(Transports), nameof(Lana_jewelryDb).Substring(0, 14));
        }
    }   
}

