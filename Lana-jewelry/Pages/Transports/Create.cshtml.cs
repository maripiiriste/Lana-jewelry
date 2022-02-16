#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lana_jewelry.Data;
using Lana_jewelry.Facade.Shipment;

namespace Lana_jewelry.Pages.Transports
{
    public class CreateModel : PageModel
    {
        private readonly Lana_jewelry.Data.ApplicationDbContext _context;

        public CreateModel(Lana_jewelry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
            var d = new TransportViewFactory().Greate(Transport).Data;
            _context.Transports.Add(d);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
