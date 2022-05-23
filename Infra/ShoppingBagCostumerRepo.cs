using Lana_jewelry.Data;
using Lana_jewelry.Domain;

namespace Lana_jewelry.Infra.Party {
    public sealed class ShoppingBagCostumerRepo : Repo<ShoppingBagCostumer, ShoppingBagCostumerData>, IShoppingBagCostumerRepo {
        public ShoppingBagCostumerRepo(Lana_jewelryDb? db) : base(db, db?.ShoppingBagCostumers) { }
        protected internal override ShoppingBagCostumer toDomain(ShoppingBagCostumerData d) => new(d);
        internal override IQueryable<ShoppingBagCostumerData> addFilter(IQueryable<ShoppingBagCostumerData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Id.Contains(y)
                || x.ShoppingBagId.Contains(y)
                || x.CostumerId.Contains(y)
             );
        }
    }
}
