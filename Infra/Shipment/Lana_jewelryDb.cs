using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Microsoft.EntityFrameworkCore;
namespace Lana_jewelry.Infra.Shipment
{
   public sealed class Lana_jewelryDb:DbContext{
        public Lana_jewelryDb(DbContextOptions<Lana_jewelryDb> options) : base(options) { }
        public static void CreateTable(ModelBuilder model) { model.Entity<TransportData>().ToTable("Transport");
            model.Entity<CostumerData>().ToTable("Costumer"); }
        public DbSet<TransportData> Transports { get; set; }
        public DbSet<CostumerData> Costumers { get; set; }
    }
}
