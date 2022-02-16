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
    public class IndexModel : PageModel
    {
        private readonly Lana_jewelry.Data.ApplicationDbContext _context;

        public IndexModel(Lana_jewelry.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TransportView> Transport { get;set; }

        public async Task OnGetAsync()
        {
            var list = await _context.Transports.ToListAsync();
            Transport = new List<TransportView>();
            foreach(var d in list)
            {
                var v = new TransportViewFactory().Create(new Transport(d));
                Transport.Add(v);
            }
        }
    }
}
