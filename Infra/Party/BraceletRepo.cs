using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class BraceletRepo : Repo<Bracelet, BraceletData>, IBraceletRepo {
        public BraceletRepo(Lana_jewelryDb? db) : base(db, db?.Bracelets) { }
        protected internal override Bracelet toDomain(BraceletData d) => new(d);
        internal override IQueryable<BraceletData> addFilter(IQueryable<BraceletData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Price.ToString().Contains(y)
                || x.Name.Contains(y)
                || x.Id.Contains(y)
                || x.Quantity.ToString().Contains(y));
        }
    }
}
