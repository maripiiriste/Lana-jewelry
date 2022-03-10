using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Lana_jewelry.Infra.Party;
using Lana_jewelry.Infra.Shipment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lana_jewelry.Pages.Costumers
{
    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public class CostumersPage : PageModel
    {
        private readonly ICostumersRepo repo;
        [BindProperty] public CostumerView Item { get; set; }
        public string ItemId => Item?.Id ?? string.Empty;
        public IList<CostumerView> Items { get; set; }
        public CostumersPage(Lana_jewelryDb c) => repo = new CostumersRepo(c, c.Costumers);
        public IActionResult OnGetCreate() => Page();
        public async Task<IActionResult> OnPostCreateAsync() {
            if (!ModelState.IsValid) return Page();
            await repo.AddAsync(new CostumerViewFactory().Create(Item));
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Item = await getCostumer(id);
            return Item == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnGetDeleteAsync(string id)
        {
            Item = await getCostumer(id);
            return Item == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id) {
            if (id == null) return NotFound();
            await repo.DeleteAsync(id);
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Item = await getCostumer(id);
            return Item == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)return Page();
            var obj = new CostumerViewFactory().Create(Item);
            var updated= await repo.UpdateAsync(obj);
            if (!updated) return NotFound();
            return RedirectToPage("./Index", "Index");
        }
        public async Task<ActionResult> OnGetIndexAsync() {
            var list = await repo.GetAsync();
            Items = new List<CostumerView>();
            foreach (var obj in list)
            {
                var v = new CostumerViewFactory().Create(obj);
                Items.Add(v);
            }
            return Page();
        }
        private async Task<CostumerView> getCostumer(string id)
            => new CostumerViewFactory().Create(await repo.GetAsync(id)); 
    }
}

