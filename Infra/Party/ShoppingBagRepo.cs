using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class ShoppingBagRepo : Repo<ShoppingBag, ShoppingBagData>, IShoppingBagRepo {
        public ShoppingBagRepo(Lana_jewelryDb? db) : base(db, db?.ShoppingBags) { }
        protected internal override ShoppingBag toDomain(ShoppingBagData d) => new(d);
        internal override IQueryable<ShoppingBagData> addFilter(IQueryable<ShoppingBagData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Total.ToString().Contains(y)
                || x.Delivery.Contains(y)
                || x.Id.Contains(y)
                || x.PaymentSystem.Contains(y)
                || x.DiscountCode.Contains(y));
        }
    }
}
