using Lana_jewelry.Data.Shipment;

namespace Lana_jewelry.Domain.Party
{
    public interface ICountriesRepo : IRepo<Country> { }
    public sealed class Country : Entity<CountryData> {
        public Country() : this(new CountryData()) { }
        public Country(CountryData d) : base(d) { }
        public string Name => getValue(Data?.Name);
        public string Code=> getValue(Data?.Code);
        public string Description => getValue(Data?.Description);
    }
}
