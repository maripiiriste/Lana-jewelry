using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages.Shipment {
    public class ShoppingBagCostumersPage : PagedPage<ShoppingBagCostumerView, ShoppingBagCostumer, IShoppingBagCostumerRepo> {
        private readonly IShoppingBagRepo shoppingBag;
        private readonly ICostumersRepo costumer;
        public ShoppingBagCostumersPage(IShoppingBagCostumerRepo r, ICostumersRepo g, IShoppingBagRepo s) : base(r) {
            shoppingBag = s; //p
            costumer = g; //c
        }
        protected override ShoppingBagCostumer toObject(ShoppingBagCostumerView? item) => new ShoppingBagCostumerViewFactory().Create(item);
        protected override ShoppingBagCostumerView toView(ShoppingBagCostumer? entity) => new ShoppingBagCostumerViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(ShoppingBagCostumerView.ShoppingBagId),
         nameof(ShoppingBagCostumerView.CostumerId),
        };
        public IEnumerable<SelectListItem> Costumer
          => costumer?.GetAll(x => x.ToString())?
         .Select(x => new SelectListItem(x.ToString(), x.Id))
          ?? new List<SelectListItem>();
    }
}
