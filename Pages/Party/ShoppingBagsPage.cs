using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party {
    public class ShoppingBagsPage : PagedPage<ShoppingBagView, ShoppingBag, IShoppingBagRepo> {
        public ShoppingBagsPage(IShoppingBagRepo r) : base(r) { }
        protected override ShoppingBag toObject(ShoppingBagView? item) => new ShoppingBagViewFactory().Create(item);
        protected override ShoppingBagView toView(ShoppingBag? entity) => new ShoppingBagViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(ShoppingBagView.Total),
         nameof(ShoppingBagView.Delivery),
         nameof(ShoppingBagView.PaymentSystem),
         nameof(ShoppingBagView.DiscountCode)
        };
    }
}



