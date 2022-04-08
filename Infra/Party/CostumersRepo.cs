using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CostumersRepo : Repo<Costumer, CostumerData>, ICostumersRepo {
        public CostumersRepo(Lana_jewelryDb? db) : base(db, db?.Costumers) {}
        protected override Costumer toDomain(CostumerData d) => new (d);
        internal override IQueryable<CostumerData> addFilter(IQueryable<CostumerData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q: q.Where(
                x => contains(x.FirstName,y)
                || contains(x.Id,y)
                || contains(x.LastName,y)
                || contains(x.Email,y)
                || contains(x.DoB.ToString(),y));
        }
    }
}
