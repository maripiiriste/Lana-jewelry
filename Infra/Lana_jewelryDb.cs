using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra{
   public sealed class Lana_jewelryDb:DbContext{
        public Lana_jewelryDb(DbContextOptions<Lana_jewelryDb> options) : base(options) { }
        public DbSet<TransportData>? Transports { get; set; }
        public DbSet<CostumerData>? Costumers { get; set; }
        public DbSet<InfoData>? Infos { get; set; }
        public DbSet<GiftCardData>? GiftCards { get; set; }

        protected override void OnModelCreating(ModelBuilder b) {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        public static void InitializeTables(ModelBuilder b) {
            var s = nameof(Lana_jewelryDb)[0..^2];
            _=(b?.Entity<TransportData>()?.ToTable(nameof(Transports),s));
            _=( b?.Entity<GiftCardData>()?.ToTable(nameof(GiftCards), s));
        }
    }   
}

