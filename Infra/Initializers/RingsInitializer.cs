using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class RingsInitializer : BaseInitializer<RingData> {
        public RingsInitializer(Lana_jewelryDb? db) : base(db, db?.Rings) { }
        internal static RingData createRing(string name, double price, int quantity) {
            var ring = new RingData {
                Id = name,
                Name = name,
                Price = price,
                Quantity = quantity
            };
            return ring;
        }
        protected override IEnumerable<RingData> getEntities => new[] {
            createRing("Gold ring", 99.99, 1),
            createRing("Silver ring", 79.99, 1),
            createRing("Pearl ring", 50.99, 1),
        };
    }
}
