using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public sealed class CountryCurrenciesRepo : Repo<CountryCurrency, CountryCurrencyData>, ICountryCurrenciesRepo {
        public CountryCurrenciesRepo(Lana_jewelryDb? db) : base(db, db?.CountryCurrencies) { }
        protected internal override CountryCurrency toDomain(CountryCurrencyData d) => new(d);
        internal override IQueryable<CountryCurrencyData> addFilter(IQueryable<CountryCurrencyData> q) {
            var y = CurrentFilter;
            return string.IsNullOrWhiteSpace(y)
                ? q : q.Where(
                 x =>  x.Id.Contains(y)
                || x.Code.Contains(y)
                || x.Name.Contains(y)
                || x.Description.Contains(y)
                || x.CountryId.Contains(y)
                || x.CurrencyId.Contains(y)); ;
        }
    }
}
