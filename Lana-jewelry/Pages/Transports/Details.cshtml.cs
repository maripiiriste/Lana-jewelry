#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lana_jewelry.Data;
using Lana_jewelry.Facade.Shipment;
using Lana_jewelry.Domain.Shipment;

namespace Lana_jewelry.Pages.Transports
{
    public class DetailsModel : PageModel
    {
        private readonly Lana_jewelry.Data.ApplicationDbContext _context;

        public DetailsModel(Lana_jewelry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
