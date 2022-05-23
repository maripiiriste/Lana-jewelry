using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Infra.Initializers
{
    public sealed class TransportShoppingBagInitializer : BaseInitializer<TransportShoppingBagData>
    {
        public TransportShoppingBagInitializer(Lana_jewelryDb? db) : base(db, db?.TransportShoppingBags) { }
        protected override IEnumerable<TransportShoppingBagData> getEntities
        {
        }

        internal static TransportShoppingBagData createEntity(string shoppingBagId, string transportId)
            => new()
            {
                Id = UniqueData.NewId,
                TransportId = transportId,
                ShoppingBagId = shoppingBagId
            };
    }
}
