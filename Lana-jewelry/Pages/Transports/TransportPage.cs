using Lana_jewelry.Data;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web.Mvc;

namespace Lana_jewelry.Pages.Transports
{
    public class TransportPage:PageModel
    {
        private readonly ApplicationDbContext context;

        public TransportPage(ApplicationDbContext c) => context = c;

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TransportView Transport { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var d = new TransportViewFactory().Create(Transport).Data;

            context.Transports.Add(d);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
