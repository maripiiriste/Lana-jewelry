using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Domain.Party
{
    public interface ICountriesRepo : IRepo<Country> { }
    public sealed partial class Country : NamedEntity<CountryData>, IComparable{
        public Country() : this(new()) { }
        public Country(CountryData d) : base(d) { }
        public Lazy<List<CountryCurrency>> CountryCurrencies {
            get {
                var l=GetRepo.Instance<ICountryCurrenciesRepo>()?
                    .GetAll(x => x.CountryId)?
                    .Where(x => x.CountryId == Id)?
                    .ToList() ?? new List<CountryCurrency>();
                return new Lazy<List<CountryCurrency>>(l);
            }
        }
        public Lazy<List<Currency?>> Currencies {
            get {
               var l=CountryCurrencies.Value
                .Select(x => x.Currency)
                .ToList() ?? new List<Currency?>();
                return new Lazy<List<Currency?>>(l);
            } 
        }
        public Lazy<List<CostumerCountry>> CostumersCountry{
            get{
                var l = GetRepo.Instance<ICostumersCountryRepo>()?
                   .GetAll(x => x.CountryId)?
                   .Where(x => x.CountryId == Id)?
                   .ToList() ?? new List<CostumerCountry>();
                return new Lazy<List<CostumerCountry>>(l);
            }
        }
        public Lazy<List<Costumer?>> Costumers{
            get{
                var l = CostumersCountry. Value
                   .Select(x => x.Costumer)
                   .ToList() ?? new List<Costumer?>();
                return new Lazy<List<Costumer?>>(l);
            }
        }

        public int CompareTo(object? x) => compareTo(x as Country);
        private int compareTo(Country? c) => Name.CompareTo(c?.Name);
    }
}
