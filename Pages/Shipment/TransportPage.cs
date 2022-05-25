using Lana_jewelry.Domain.Party;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages{
    public class TransportPage : PagedPage<TransportView, Transport, ITransportsRepo>{
        private readonly  ICountriesRepo countries;
        public TransportPage(ITransportsRepo r, ICountriesRepo c) : base(r)=> countries= c;
        protected override Transport toObject(TransportView? item) => new TransportViewFactory().Create(item);
        protected override TransportView toView(Transport? entity) => new TransportViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(TransportView.Street),
         nameof(TransportView.City),
         nameof(TransportView.ZipCode),
         nameof(TransportView.CountryId),
         nameof(TransportView.TransportPrice),
         nameof(TransportView.TransportDuration)
        };
        public IEnumerable<SelectListItem> Countries
            => countries?.GetAll(x => x.Name)?
            .Select(x => new SelectListItem(x.Name, x.Id))
            ?? new List<SelectListItem>();
        public string CountryName(string? countryId=null)
    => Countries?.FirstOrDefault(x=> x.Value == (countryId?? string.Empty))?.Text??"Unspecified";

        public override object? GetValue(string name, TransportView v){
            var r = base.GetValue(name, v);
            return name == nameof(TransportView.CountryId)? CountryName(r as string) : r;
        }
    }
}


