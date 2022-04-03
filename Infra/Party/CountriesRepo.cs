using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CountriesRepo : Repo<Country, CountryData>, ICountriesRepo {
        public CountriesRepo(Lana_jewelryDb? db) : base(db, db?.Countries) { }
        protected override Country toDomain(CountryData d) => new (d);
        internal override IQueryable<CountryData> addFilter(IQueryable<CountryData> q) {
            var y = CurrentFilter;
            if (string.IsNullOrWhiteSpace(y)) return q;
            return q.Where(
                x => x.Code.Contains(y)
                || x.Id.Contains(y)
                || x.Name.Contains(y)
                || x.Description.Contains(y));
        }
    }
}
