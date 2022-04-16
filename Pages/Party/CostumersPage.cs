using Lana_jewelry.Aids;
using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;

namespace Lana_jewelry.Pages.Party
{
    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public class CostumersPage : PagedPage<CostumerView, Costumer, ICostumersRepo> {
        public CostumersPage(ICostumersRepo r) : base(r) { }
        protected override Costumer toObject(CostumerView? item) => new CostumerViewFactory().Create(item);
        protected override CostumerView toView(Costumer? entity) => new CostumerViewFactory().Create(entity);
        public override string[] IndexColumns { get; }= new[] {
         nameof(CostumerView.FirstName),
         nameof(CostumerView.LastName),
         nameof(CostumerView.DoB),
         nameof(CostumerView.Email)
        };
    }
}



