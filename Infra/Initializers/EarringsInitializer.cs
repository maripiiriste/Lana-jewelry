using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class EarringsInitializer : BaseInitializer<EarringData> {
        public EarringsInitializer(Lana_jewelryDb? db) : base(db, db?.Earrings) { }
        internal static EarringData createEarring(string name, double price, int quantity) {
            var earring = new EarringData {
                Id = name,
                Name = name,
                Price = price,
                Quantity = quantity
            };
            return earring;
        }
        protected override IEnumerable<EarringData> getEntities => new[] {
            createEarring("Gold ring", 130.99, 1),
            createEarring("Silver ring", 115.99, 1),
            createEarring("Pearl ring", 99.99, 1),
        };
    }
}
