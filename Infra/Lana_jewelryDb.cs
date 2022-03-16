using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra{
   public sealed class Lana_jewelryDb:DbContext{
        public Lana_jewelryDb(DbContextOptions<Lana_jewelryDb> options) : base(options) { }
        public DbSet<TransportData>? Transports { get; set; }
        public DbSet<CostumerData>? Costumers { get; set; }
        public DbSet<InfoData>? Infos { get; set; }

        protected override void OnModelCreating(ModelBuilder model) {
            base.OnModelCreating(model);
            InitializeTables(model);
        }
        public static void InitializeTables(ModelBuilder model) {
            var s = nameof(Lana_jewelryDb)[0..^2];
            _=(model.Entity<CostumerData>()?.ToTable(nameof(Costumers),s));
            _=(model.Entity<InfoData>()?.ToTable(nameof(Infos),s));
            _=(model.Entity<TransportData>()?.ToTable(nameof(Transports),s));
        }
    }   
}

