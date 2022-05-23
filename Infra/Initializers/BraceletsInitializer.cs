using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class BraceletsInitializer : BaseInitializer<BraceletData> {
        public BraceletsInitializer(Lana_jewelryDb? db) : base(db, db?.Bracelets) { }
        internal static BraceletData createBracelet(string name, double price, int quantity) {
            var bracelet = new BraceletData {
                Id = name,
                Name = name,
                Price = price,
                Quantity = quantity
            };
            return bracelet;
        }
        protected override IEnumerable<BraceletData> getEntities => new[] {
            createBracelet("Gold bracelet", 150.99, 1),
            createBracelet("Silver bracelet", 120.99, 1),
            createBracelet("Pearl bracelet", 100.99, 1),
        };
    }
}
