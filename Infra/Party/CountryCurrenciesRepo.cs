using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CountryCurrenciesRepo : Repo<CountryCurrency, CountryCurrencyData>, ICountryCurrenciesRepo {
        public CountryCurrenciesRepo(Lana_jewelryDb? db) : base(db, db?.CountryCurrencies) { }
        protected override CountryCurrency toDomain(CountryCurrencyData d) => new(d);
        internal override IQueryable<CountryCurrencyData> addFilter(IQueryable<CountryCurrencyData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                x => contains(x.Code, y)
                || contains(x.Id, y)
                || contains(x.CountryId, y)
                || contains(x.CurrencyId, y));
        }
    }
}
