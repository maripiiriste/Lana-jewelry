using Lana_jewelry.Data;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Infra{
   public sealed class Lana_jewelryDb:DbContext{
        public Lana_jewelryDb(DbContextOptions<Lana_jewelryDb> options) : base(options) { }
        public DbSet<TransportData>? Transports { get; set; } //tabelid
        public DbSet<CostumerData>? Costumers { get; set; }
        public DbSet<InfoData>? Infos { get; set; }
        public DbSet<JewelryData>? Jewelries { get; set; }
        public DbSet<ShoppingBagData>? ShoppingBags{ get; set; }
        public DbSet<EarringData>? Earrings { get; set; }
        public DbSet<RingData>? Rings { get; set; }
        public DbSet<NecklaceData>? Necklaces { get; set; }
        public DbSet<BraceletData>? Bracelets { get; set; }
        public DbSet<GiftCardData>? GiftCards { get; set; }
        public DbSet<CountryData>? Countries { get; set; }
        public DbSet<CurrencyData>? Currencies { get; set; }
        public DbSet<CountryCurrencyData>? CountryCurrencies { get; set; }
        public DbSet<ShoppingBagGiftCardData>? ShoppingBagGiftCards { get; set; }
        public DbSet<TransportShoppingBagData>? TransportShoppingBags { get; set; }
        public DbSet<ShoppingBagCostumerData>? ShoppingBagCostumers { get; set; }

        protected override void OnModelCreating(ModelBuilder b) {
            base.OnModelCreating(b);
            InitializeTables(b);
        }
        public static void InitializeTables(ModelBuilder b) {
            var s = nameof(Lana_jewelryDb)[0..^2];
            _ = (b?.Entity<CostumerData>()?.ToTable(nameof(Costumers), s));
            _ = (b?.Entity<InfoData>()?.ToTable(nameof(Infos), s));
            _ = (b?.Entity<JewelryData>()?.ToTable(nameof(Jewelries), s));
            _ = (b?.Entity<TransportData>()?.ToTable(nameof(Transports),s));
             _= (b?.Entity<GiftCardData>()?.ToTable(nameof(GiftCards), s));
            _ = (b?.Entity<CountryData>()?.ToTable(nameof(Countries), s));
            _ = (b?.Entity<CurrencyData>()?.ToTable(nameof(Currencies), s));
            _ = (b?.Entity<CountryCurrencyData>()?.ToTable(nameof(CountryCurrencies), s));
            _ = (b?.Entity<TransportShoppingBagData>()?.ToTable(nameof(TransportShoppingBags), s));
        }
    }   
}

