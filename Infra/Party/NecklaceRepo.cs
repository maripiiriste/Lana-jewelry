using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class NecklaceRepo : Repo<Necklace, NecklaceData>, INecklaceRepo {
        public NecklaceRepo(Lana_jewelryDb? db) : base(db, db?.Necklaces) { }
        protected internal override Necklace toDomain(NecklaceData d) => new(d);
        internal override IQueryable<NecklaceData> addFilter(IQueryable<NecklaceData> q) {
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
