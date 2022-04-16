using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Shipment;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages.Party
{
    public class CostumerCountryPage : PagedPage<CostumerCountryView, CostumerCountry, ICostumersCountryRepo>{
        private readonly ICountriesRepo countries;
        private readonly ICostumersRepo costumers;
        public CostumerCountryPage(ICostumersCountryRepo r, ICostumersRepo p, ICountriesRepo c ) : base(r) {
            costumers = p;
            countries = c;
        }
        protected override CostumerCountry toObject(CostumerCountryView? item) => new CostumerCountryViewFactory().Create(item);
        protected override CostumerCountryView toView(CostumerCountry? entity) => new CostumerCountryViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(CostumerCountryView.Code),
         nameof(CostumerCountryView.Name),
         nameof(CostumerCountryView.CostumerId),
         nameof(CostumerCountryView.CountryId),
         nameof(CostumerCountryView.Description)
        };

        public IEnumerable<SelectListItem> Countries
           => countries?.GetAll(x => x.Name)?
          .Select(x => new SelectListItem(x.Name, x.Id))
           ?? new List<SelectListItem>();
        public IEnumerable<SelectListItem> Costumers
          => costumers?.GetAll(x => x.ToString())?
         .Select(x => new SelectListItem(x.ToString(), x.Id))
          ?? new List<SelectListItem>();
        public string CountryName(string? countryId = null)
            => Countries?.FirstOrDefault(x => x.Value == (countryId ?? string.Empty))?.Text ?? "Unspecified";
        public string CostumerName(string? costumerId = null)
            => Costumers?.FirstOrDefault(x => x.Value == (costumerId ?? string.Empty))?.Text ?? "Unspecified";
        public override object? GetValue(string name, CostumerCountryView v)
        {
            var r = base.GetValue(name, v);
           return name == nameof(CostumerCountryView.CostumerId)? CostumerName(r as string)
                : name == nameof(CostumerCountryView.CountryId) ? CountryName(r as string)
                : r;
        }

    }
}



