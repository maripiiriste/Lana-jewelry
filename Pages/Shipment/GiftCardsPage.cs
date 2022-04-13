using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;

namespace Lana_jewelry.Pages
{
    public class GiftCardsPage : PagedPage<GiftCardView, GiftCard, IGiftCardRepo>
    {
        public GiftCardsPage(IGiftCardRepo r) : base(r) { }
        protected override GiftCard toObject(GiftCardView? item) => new GiftCardViewFactory().Create(item);
        protected override GiftCardView toView(GiftCard? entity) => new GiftCardViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(GiftCardView.Price)};
    }
}


