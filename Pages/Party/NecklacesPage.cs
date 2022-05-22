using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party {
    public class NecklacesPage : PagedPage<NecklaceView, Necklace, INecklaceRepo> {
        public NecklacesPage(INecklaceRepo r) : base(r) { }
        protected override Necklace toObject(NecklaceView? item) => new NecklaceViewFactory().Create(item);
        protected override NecklaceView toView(Necklace? entity) => new NecklaceViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof( NecklaceView.Name),
         nameof( NecklaceView.Price),
         nameof( NecklaceView.Quantity)
        };
    }
}



