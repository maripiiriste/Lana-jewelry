#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lana_jewelry.Data;
using Lana_jewelry.Facade.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Pages.Transports
{
    public class EditModel : PageModel
    {
        private readonly Lana_jewelry.Data.ApplicationDbContext _context;

        public EditModel(Lana_jewelry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TransportView Transport { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var d = await _context.Transports.FirstOrDefaultAsync(m => m.TansportId == id);

            if (d == null)
            {
                return NotFound();
            }
            Transport = new TransportViewFactory().Greate(new Transport(d));
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Transport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransportExists(Transport.TansportId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TransportExists(string id)
        {
            return _context.Transports.Any(e => e.TansportId == id);
        }
    }
}
