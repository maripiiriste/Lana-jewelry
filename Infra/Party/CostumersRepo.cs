using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class CostumersRepo : Repo<Costumer, CostumerData>, ICostumersRepo
    {
        public CostumersRepo(Lana_jewelryDb? db) : base(db, db?.Costumers) { }
        protected internal override Costumer toDomain(CostumerData d) => new(d);
        internal override IQueryable<CostumerData> addFilter(IQueryable<CostumerData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.FirstName.Contains(y)
                || x.LastName.Contains(y)
                || x.Id.Contains(y)
                || x.Email.Contains(y)
                || x.DoB.ToString().Contains(y));
        }
    }
}
