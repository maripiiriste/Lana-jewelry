using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Infra{
    public sealed class TransportShoppingBagRepo : Repo<TransportShoppingBag, TransportShoppingBagData>, ITransportShoppingBagRepo{
        public TransportShoppingBagRepo(Lana_jewelryDb? db) : base(db, db?.TransportShoppingBags) { }
        protected internal override TransportShoppingBag toDomain(TransportShoppingBagData d) => new(d);
        internal override IQueryable<TransportShoppingBagData> addFilter(IQueryable<TransportShoppingBagData> q){
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Id.Contains(y)
                || x.ShoppingBagId.Contains(y)
                || x.TransportId.Contains(y)
             );
        }
    }
}
