using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class NecklacesInitializer : BaseInitializer<NecklaceData> {
        public NecklacesInitializer(Lana_jewelryDb? db) : base(db, db?.Necklaces) { }
        internal static NecklaceData createNecklace(string name, double price, int quantity) {
            var necklace= new NecklaceData {
                Id = name,
                Name = name,
                Price = price,
                Quantity = quantity
            };
            return necklace;
        }
        protected override IEnumerable<NecklaceData> getEntities => new[] {
            createNecklace("Gold ring", 130.99, 1),
            createNecklace("Silver ring", 115.99, 1),
            createNecklace("Pearl ring", 99.99, 1),
        };
    }
}
