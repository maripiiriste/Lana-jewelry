using Lana_jewelry.Domain.Party;
using Lana_jewelry.Facade.Party;
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
        private readonly Lana_jewelry.Data.ApplicationDbContext context;
        [BindProperty] public CostumerView Costumer { get; set; }
        public IList<CostumerView> Costumers { get; set; }
        public CostumersPage(Lana_jewelry.Data.ApplicationDbContext c) => context = c;

        public IActionResult OnGetCreate()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostCreateAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var d = new CostumerViewFactory().Create(Costumer).Data;

            context.Costumers.Add(d);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index", "Index");
        }

        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Costumer = await getCostumer(id);
            return Costumer == null ? NotFound() : Page();
        }

        private async Task<CostumerView> getCostumer(string id)
        {
            if (id == null) return null;
            var d = await context.Costumers.FirstOrDefaultAsync(m => m.Id == id);
            if (d == null) return null;

            return new CostumerViewFactory().Create(new Costumer(d));
        }

        public async Task<IActionResult> OnGetDeleteAsync(string id)
        {
            Costumer = await getCostumer(id);
            return Costumer == null ? NotFound() : Page();
        }

        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d = await context.Costumers.FindAsync(id);

            if (d != null)
            {
                context.Costumers.Remove(d);
                await context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Costumer = await getCostumer(id);
            return Costumer == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var d = new CostumerViewFactory().Create(Costumer).Data;
            context.Attach(Costumer).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CostumerExists(Costumer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index", "Index");
        }
        private bool CostumerExists(string id) => context.Costumers.Any(e => e.Id == id);
        public async Task OnGetIndexAsync()
        {
            var list = await context.Costumers.ToListAsync();
            Costumers = new List<CostumerView>();
            foreach (var d in list)
            {
                var v = new CostumerViewFactory().Create(new Costumer(d));
                Costumers.Add(v);
            }
        }

    }
}

