using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages.Party {
    public class InfosPage : PagedPage<InfoView, Info, IInfoRepo> {
        private readonly ICountriesRepo countries;
        public InfosPage(IInfoRepo r, ICountriesRepo c) : base(r) => countries = c; 
        protected override Info toObject(InfoView? item) => new InfoViewFactory().Create(item);
        protected override InfoView toView(Info? entity) => new InfoViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
        //nameof(InfoView.Id),
        nameof(InfoView.Country),
        nameof(InfoView.City),
        nameof(InfoView.Region),
        nameof(InfoView.Street),
        nameof(InfoView.StreetNumber),
        nameof(InfoView.ZipCode),
        nameof(InfoView.PhoneNumber),
        nameof(InfoView.EmailAddress)
        };

        public IEnumerable<SelectListItem> Countries
            => countries?.GetAll(x => x.Name)?
            .Select(x => new SelectListItem(x.Name, x.Id))
            ?? new List<SelectListItem>();

        public string CountryName(string? countryId=null)
            => Countries?.FirstOrDefault(x => x.Value == (countryId?? string.Empty))?.Text ?? "Unspecified";

        public override object? GetValue(string name, InfoView v) {
            var r=base.GetValue(name, v);
            if (name == nameof(InfoView.Country)) return CountryName(r as string);
            return r;
        }
    }
}



