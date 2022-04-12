using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages.Party {
    public class CountryCurrenciesPage : PagedPage<CountryCurrencyView, CountryCurrency, ICountryCurrenciesRepo> {
        private readonly ICountriesRepo countries;
        private readonly ICurrenciesRepo currencies;
        public CountryCurrenciesPage(ICountryCurrenciesRepo r, ICountriesRepo c, ICurrenciesRepo cu) : base(r) {
            countries = c;
            currencies = cu;
        } 
        protected override CountryCurrency toObject(CountryCurrencyView? item) => new CountryCurrencyViewFactory().Create(item);
        protected override CountryCurrencyView toView(CountryCurrency? entity) => new CountryCurrencyViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
        nameof(CountryCurrencyView.Code),
        nameof(CountryCurrencyView.Name),
        nameof(CountryCurrencyView.CountryId),
        nameof(CountryCurrencyView.CurrencyId)
        };

        public IEnumerable<SelectListItem> Countries
            => countries?.GetAll(x => x.Name)?
            .Select(x => new SelectListItem(x.Name, x.Id))
            ?? new List<SelectListItem>();
        public IEnumerable<SelectListItem> Currencies
            => currencies?.GetAll(x => x.Name)?
            .Select(x => new SelectListItem(x.Name, x.Id))
            ?? new List<SelectListItem>();

        public string CountryName(string? countryId = null)
            => Countries?.FirstOrDefault(x => x.Value == (countryId ?? string.Empty))?.Text ?? "Unspecified";

        public string CurrencyName(string? currencyId = null)
            => Currencies?.FirstOrDefault(x => x.Value == (currencyId ?? string.Empty))?.Text ?? "Unspecified";

        public override object? GetValue(string name, CountryCurrencyView v) {
            var r = base.GetValue(name, v);
            return name == nameof(CountryCurrencyView.CountryId) ? CountryName(r as string)
                : name == nameof(CountryCurrencyView.CurrencyId) ? CurrencyName(r as string)
                : r;
        }
    }
}



