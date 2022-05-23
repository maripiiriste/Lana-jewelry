using Lana_jewelry.Domain;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lana_jewelry.Pages {
    public class ShoppingBagGiftCardsPage : PagedPage<ShoppingBagGiftCardView, ShoppingBagGiftCard, IShoppingBagGiftCardRepo>{
        private readonly IShoppingBagRepo shoppingBag;
        private readonly IGiftCardRepo giftCard;
        public ShoppingBagGiftCardsPage(IShoppingBagGiftCardRepo r, IGiftCardRepo g, IShoppingBagRepo s) : base(r)
        {
            shoppingBag = s; 
            giftCard = g; 
        }
        protected override ShoppingBagGiftCard toObject(ShoppingBagGiftCardView? item) => new ShoppingBagGiftCardViewFactory().Create(item);
        protected override ShoppingBagGiftCardView toView(ShoppingBagGiftCard? entity) => new ShoppingBagGiftCardViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(ShoppingBagGiftCardView.ShoppingBagId),
         nameof(ShoppingBagGiftCardView.GiftCardId),
        };

        public IEnumerable<SelectListItem> GiftCard
          => giftCard?.GetAll(x => x.ToString())?
         .Select(x => new SelectListItem(x.ToString(), x.Id))
          ?? new List<SelectListItem>();

        //et lisada gifCardi price total 

    }
}
