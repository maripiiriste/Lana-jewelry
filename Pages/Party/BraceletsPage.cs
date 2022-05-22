using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party {
    public class BraceletsPage : PagedPage<BraceletView, Bracelet, IBraceletRepo> {
        public BraceletsPage(IBraceletRepo r) : base(r) { }
        protected override Bracelet toObject(BraceletView? item) => new BraceletViewFactory().Create(item);
        protected override BraceletView toView(Bracelet? entity) => new BraceletViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(BraceletView.Name),
         nameof(BraceletView.Price),
         nameof(BraceletView.Quantity)
        };
    }
}



