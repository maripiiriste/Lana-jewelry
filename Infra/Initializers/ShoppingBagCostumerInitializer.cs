using Lana_jewelry.Data;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class ShoppingBagCostumerInitializer : BaseInitializer<ShoppingBagCostumerData> {
        public ShoppingBagCostumerInitializer(Lana_jewelryDb? db) : base(db, db?.ShoppingBagCostumers) { }
        protected override IEnumerable<ShoppingBagCostumerData> getEntities => throw new NotImplementedException();

        internal static ShoppingBagCostumerData createEntity(string shoppingBagId, string costumerId)
            => new() {
                Id = UniqueData.NewId,
                CostumerId = costumerId,
                ShoppingBagId = shoppingBagId
            };
    }
}
