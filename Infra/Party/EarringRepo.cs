using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class EarringRepo : Repo<Earring, EarringData>, IEarringRepo {
        public EarringRepo(Lana_jewelryDb? db) : base(db, db?.Earrings) { }
        protected internal override Earring toDomain(EarringData d) => new(d);
        internal override IQueryable<EarringData> addFilter(IQueryable<EarringData> q) {
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
