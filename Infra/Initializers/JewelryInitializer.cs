using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Infra.Initializers{
    public sealed class JewelryInitializer : BaseInitializer<JewelryData> {
        public JewelryInitializer(Lana_jewelryDb? db) : base(db, db?.Jewelries) { }
        protected override IEnumerable<JewelryData> getEntities => new[] {
          createInfo("Gold ring", "Dimond necklace", "Silver bracelet", "Pearl earrings"),
        };
        internal static JewelryData createInfo(string Ring, string Necklace, string Bracelet, string Earring){
            var jewelry = new JewelryData
            {
                Ring = Ring,
                Necklace = Necklace,
                Bracelet = Bracelet,
                Earring = Earring
            };
            return jewelry;
        }
    }
   
}

