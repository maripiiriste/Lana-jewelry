using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party
{
    public class CostumersCountryRepo : Repo<CostumerCountry, CostumerCountryData>, ICostumersCountryRepo
    {
        public CostumersCountryRepo(Lana_jewelryDb? db) : base(db, db?.CostumerCountries) { }
        protected override CostumerCountry toDomain(CostumerCountryData d) => new(d);
        internal override IQueryable<CostumerCountryData> addFilter(IQueryable<CostumerCountryData> q)
        {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => x.Id.Contains(y)
                || x.Code.Contains(y)
                || x.Name.Contains(y)
                || x.Description.Contains(y)
                || x.CountryId.Contains(y)
                || x.CostumerId.Contains(y) 
             );
        }
    }
}
