using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class RingRepo : Repo<Ring, RingData>, IRingRepo {
        public RingRepo(Lana_jewelryDb? db) : base(db, db?.Rings) { }
        protected internal override Ring toDomain(RingData d) => new(d);
        internal override IQueryable<RingData> addFilter(IQueryable<RingData> q) {
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
