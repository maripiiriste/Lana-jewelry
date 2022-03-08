using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
using Lana_jewelry.Infra.Party;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Pages.Costumers
{
    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public class CostumersPage : PageModel
    {
        private readonly ICostumersRepo repo;
        [BindProperty] public CostumerView Costumer { get; set; }
        public string GetId=>Costumer.Id;
        public IList<CostumerView> Costumers { get; set; }
        public CostumersPage(Lana_jewelry.Data.ApplicationDbContext c) => repo = new CostumersRepo(c, c.Costumers);
        public IActionResult OnGetCreate() => Page();
        public async Task<IActionResult> OnPostCreateAsync() {
            if (!ModelState.IsValid) return Page();
            await repo.AddAsync(new CostumerViewFactory().Create(Costumer));
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Costumer = await getCostumer(id);
            return Costumer == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnGetDeleteAsync(string id)
        {
            Costumer = await getCostumer(id);
            return Costumer == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id) {
            if (id == null) return NotFound();
            await repo.DeleteAsync(id);
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Costumer = await getCostumer(id);
            return Costumer == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)return Page();
            var obj = new CostumerViewFactory().Create(Costumer);
            var updated= await repo.UpdateAsync(obj);
            if (!updated) return NotFound();
            return RedirectToPage("./Index", "Index");
        }
        public async Task<ActionResult> OnGetIndexAsync() {
            var list = await repo.GetAsync();
            Costumers = new List<CostumerView>();
            foreach (var obj in list)
            {
                var v = new CostumerViewFactory().Create(obj);
                Costumers.Add(v);
            }
            return Page();
        }
        private async Task<CostumerView> getCostumer(string id)
            => new CostumerViewFactory().Create(await repo.GetAsync(id)); 
    }
}

