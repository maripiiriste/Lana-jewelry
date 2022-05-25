using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;

namespace Lana_jewelry.Pages.Shipment{
    public class JewelriesPage : PagedPage<JewelryView, Jewelry, IJewelryRepo>
    {
        public JewelriesPage(IJewelryRepo r) : base(r) { }
        protected override Jewelry toObject(JewelryView? item) => new JewelryViewFactory().Create(item);
        protected override JewelryView toView(Jewelry? entity) => new JewelryViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(JewelryView.Ring),
         nameof(JewelryView.Bracelet),
         nameof(JewelryView.Necklace),
         nameof(JewelryView.Earring)
        };
    }
}
