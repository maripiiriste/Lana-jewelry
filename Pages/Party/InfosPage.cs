using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party {
    public class InfosPage : PagedPage<InfoView, Info, IInfoRepo> {
        public InfosPage(IInfoRepo r) : base(r) { }
        protected override Info toObject(InfoView? item) => new InfoViewFactory().Create(item);
        protected override InfoView toView(Info? entity) => new InfoViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
        //nameof(InfoView.Id),
        nameof(InfoView.Country),
        nameof(InfoView.City),
        nameof(InfoView.Region),
        nameof(InfoView.Street),
        nameof(InfoView.StreetNumber),
        nameof(InfoView.ZipCode),
        nameof(InfoView.PhoneNumber),
        nameof(InfoView.EmailAddress)
        };
    }
}



