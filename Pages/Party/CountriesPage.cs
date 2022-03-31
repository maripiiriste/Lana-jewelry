using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party {
    public class CountriesPage : PagedPage<CountryView, Country, ICountriesRepo> {
        public CountriesPage(ICountriesRepo r) : base(r) { }
        protected override Country toObject(CountryView? item) => new CountryViewFactory().Create(item);
        protected override CountryView toView(Country? entity) => new CountryViewFactory().Create(entity);
    }
}



