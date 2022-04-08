using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CountriesRepo : Repo<Country, CountryData>, ICountriesRepo {
        public CountriesRepo(Lana_jewelryDb? db) : base(db, db?.Countries) { }
        protected override Country toDomain(CountryData d) => new (d);
        internal override IQueryable<CountryData> addFilter(IQueryable<CountryData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => contains(x.Code, y)
                || contains(x.Id,y)
                || contains(x.Name, y)
                || contains(x.Description,y));
        }
    }
}
