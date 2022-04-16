using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Domain.Party
{
    public interface ICountriesRepo : IRepo<Country> { }
    public sealed partial class Country : NamedEntity<CountryData>
    {
        public Country() : this(new()) { }
        public Country(CountryData d) : base(d) { }
        public List<CountryCurrency> CountryCurrencies
            => GetRepo.Instance<ICountryCurrenciesRepo>()?
            .GetAll(x => x.CountryId)?
            .Where(x => x.CountryId == Id)?
            .ToList() ?? new List<CountryCurrency>();
        public List<Currency?> Currencies
            => CountryCurrencies
            .Select(x => x.Currency)
            .ToList() ?? new List<Currency?>();
        public List<CostumerCountry> CostumersCountry
            => GetRepo.Instance<ICostumersCountryRepo>()?
            .GetAll(x => x.CountryId)?
            .Where(x => x.CountryId == Id)?
            .ToList() ?? new List<CostumerCountry>();
        public List<Costumer?> Costumers
            => CostumersCountry
           .Select(x => x.Costumer)
           .ToList() ?? new List<Costumer?>();
    }
}
