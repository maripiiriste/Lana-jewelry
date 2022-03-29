using Lana_jewelry.Data.Party;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Infra.Party {
    public class CostumersRepo : Repo<Costumer, CostumerData>, ICostumersRepo {
        public CostumersRepo(Lana_jewelryDb? db) : base(db, db?.Costumers) {}
        protected override Costumer toDomain(CostumerData d) => new Costumer(d);
    }
    public class CountriesRepo : Repo<Country, CountryData>, ICountriesRepo {
        public CountriesRepo(Lana_jewelryDb? db) : base(db, db?.Countries) { }
        protected override Country toDomain(CountryData d) => new Country(d);
    }
    public class CurrenciesRepo : Repo<Currency, CurrencyData>, ICurrenciesRepo {
        public CurrenciesRepo(Lana_jewelryDb? db) : base(db, db?.Currencies) { }
        protected override Currency toDomain(CurrencyData d) => new Currency(d);
    }
}
