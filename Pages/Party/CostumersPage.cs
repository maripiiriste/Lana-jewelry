using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Microsoft.AspNetCore.Authorization;

namespace Lana_jewelry.Pages.Party {
    [Authorize]
    public class CostumersPage : PagedPage<CostumerView, Costumer, ICostumersRepo> {
        public CostumersPage(ICostumersRepo r) : base(r) { }
        protected override Costumer toObject(CostumerView? item) => new CostumerViewFactory().Create(item);
        protected override CostumerView toView(Costumer? entity) => new CostumerViewFactory().Create(entity);
        public override string[] IndexColumns { get; } = new[] {
         nameof(CostumerView.FirstName),
         nameof(CostumerView.LastName),
         nameof(CostumerView.DoB),
         nameof(CostumerView.Email)
        };
    }
}



