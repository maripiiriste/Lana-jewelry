using Lana_jewelry.Data.Party;

namespace Lana_jewelry.Domain.Party
{
    public interface ICostumersCountryRepo : IRepo<CostumerCountry> { }
    public sealed class CostumerCountry : NamedEntity<CostumerCountryData>{
        public CostumerCountry() : this(new CostumerCountryData()) { }
        public CostumerCountry(CostumerCountryData d) : base(d) { }
        public string CountryId => getValue(Data?.CountryId);
        public string CostumerId => getValue(Data?.CostumerId);
        public Country? Country => GetRepo.Instance<ICountriesRepo>()?.Get(CountryId);
        public Costumer? Costumer => GetRepo.Instance<ICostumersRepo>()?.Get(CostumerId);
    }
}
