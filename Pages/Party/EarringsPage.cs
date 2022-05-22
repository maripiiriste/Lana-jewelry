using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party {
    public class EarringsPage : PagedPage<EarringView, Earring, IEarringRepo> {
        public EarringsPage(IEarringRepo r) : base(r) { }
        protected override Earring toObject(EarringView? item) => new EarringViewFactory().Create(item);
        protected override EarringView toView(Earring? entity) => new EarringViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(EarringView.Name),
         nameof(EarringView.Price),
         nameof(EarringView.Quantity)
        };
    }
}



