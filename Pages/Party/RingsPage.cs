using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party {
    public class RingsPage : PagedPage<RingView, Ring, IRingRepo> {
        public RingsPage(IRingRepo r) : base(r) { }
        protected override Ring toObject(RingView? item) => new RingViewFactory().Create(item);
        protected override RingView toView(Ring? entity) => new RingViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(RingView.Name),
         nameof(RingView.Price),
         nameof(RingView.Quantity)
        };
    }
}



