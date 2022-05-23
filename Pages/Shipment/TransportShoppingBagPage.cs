using Lana_jewelry.Domain.Party;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages.Shipment
{
    public class TransportShoppingBagPage : PagedPage<TransportShoppingBagView, TransportShoppingBag, ITransportShoppingBagRepo>
    {
        private readonly ITransportsRepo transports;
        private readonly IShoppingBagRepo shoppingBags;
        public TransportShoppingBagPage(ITransportShoppingBagRepo r, ITransportsRepo t, IShoppingBagRepo s) : base(r)
        {
            transports = t;
            shoppingBags = s;
        }
        protected override TransportShoppingBag toObject(TransportShoppingBagView? item) => new TransportShoppingBagViewFactory().Create(item);
        protected override TransportShoppingBagView toView(TransportShoppingBag? entity) => new TransportShoppingBagViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(TransportShoppingBagView.TransportId),
         nameof(TransportShoppingBagView.ShoppingBagId)
        };

        public IEnumerable<SelectListItem> Transports
          => transports?.GetAll(x => x.ToString())?
         .Select(x => new SelectListItem(x.ToString(), x.Id))
          ?? new List<SelectListItem>();
        public IEnumerable<SelectListItem> ShoppingBags
          => shoppingBags?.GetAll(x => x.ToString())?
         .Select(x => new SelectListItem(x.ToString(), x.Id))
          ?? new List<SelectListItem>();
        public string TransportName(string? transportId = null)
            => Transports?.FirstOrDefault(x => x.Value == (transportId ?? string.Empty))?.Text ?? "Unspecified";
        public string ShoppingBagName(string? shoppingBagId = null)
            => ShoppingBags?.FirstOrDefault(x => x.Value == (shoppingBagId ?? string.Empty))?.Text ?? "Unspecified";
        public override object? GetValue(string name, TransportShoppingBagView v)
        {
            var r = base.GetValue(name, v);
            return name == nameof(TransportShoppingBagView.TransportId) ? TransportName(r as string)
                 : name == nameof(TransportShoppingBagView.ShoppingBagId) ? ShoppingBagName(r as string)
                 : r;
        }

    }
}
