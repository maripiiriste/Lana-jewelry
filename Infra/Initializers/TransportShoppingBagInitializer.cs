using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Infra.Initializers {
    public sealed class TransportShoppingBagInitializer : BaseInitializer<TransportShoppingBagData>{
        public TransportShoppingBagInitializer(Lana_jewelryDb? db) : base(db, db?.TransportShoppingBags) { }
        protected override IEnumerable<TransportShoppingBagData> getEntities => throw new NotImplementedException();

        internal static TransportShoppingBagData createEntity(string shoppingBagId, string transportId)
        => new()
        {
            Id = UniqueData.NewId,
            TransportId = transportId,
            ShoppingBagId = shoppingBagId
        };
    }
}
