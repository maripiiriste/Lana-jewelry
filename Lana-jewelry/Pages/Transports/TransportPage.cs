using Lana_jewelry.Data;
using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;

namespace Lana_jewelry.Pages.Transports
{
    public class TransportPage:PageModel
    {
        // TODO To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        // TODO To protect from overposting attacks, enable the specific properties you want to bind to.
        // TODO For more details, see https://aka.ms/RazorPagesCRUD.
        private readonly ApplicationDbContext context;
        [BindProperty] public TransportView Transport { get; set; }
        public IList<TransportView> Transports { get; set; }
        public TransportPage(ApplicationDbContext c) => context = c;
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
            var d = new TransportViewFactory().Create(Transport).Data;

            context.Transports.Add(d);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index","Index");
        }
        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Transport = await getTransport(id);
            return Transport == null ? NotFound() : Page();
        }

        private async Task<TransportView> getTransport(string id) {
            if (id == null) return null;
            var d = await context.Transports.FirstOrDefaultAsync(m => m.TransportId == id);
            if (d == null) return null;
            return new TransportViewFactory().Create(new Transport(d));
        }
        public async Task<IActionResult> OnGetDeleteAsync(string id) {
            Transport = await getTransport(id);
            return Transport == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d = await context.Transports.FindAsync(id);

            if (d != null)
            {
                context.Transports.Remove(d);
                await context.SaveChangesAsync();
            }

            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Transport = await getTransport(id);
            return Transport == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostEditAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var d = new TransportViewFactory().Create(Transport).Data;
            context.Attach(d).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!transportExists(Transport.TransportId))
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

        private bool transportExists(string id)=> context.Transports.Any(e => e.TransportId == id);
        public async Task OnGetIndexAsync()
        {
            var list = await context.Transports.ToListAsync();
            Transports = new List<TransportView>();
            foreach (var d in list)
            {
                var v = new TransportViewFactory().Create(new Transport(d));
                Transports.Add(v);
            }
        }
    }
}

