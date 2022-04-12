using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Domain.Party {
    public interface ICountriesRepo : IRepo<Country> { }
    public sealed class Country : NamedEntity<CountryData> {
        public Country() : this(new()) { }
        public Country(CountryData d) : base(d) { }
    }
}
