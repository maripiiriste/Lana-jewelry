using Lana_jewelry.Data;
using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;
using Lana_jewelry.Infra.Shipment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lana_jewelry.Pages.Transports{
    public class TransportPage:PageModel
    {
        private readonly ITransportsRepo repo;
        [BindProperty] public TransportView Transport { get; set; }
        public IList<TransportView> Transports { get; set; }
        public TransportPage(ApplicationDbContext c) => repo = new TransportsRepo(c, c.Transports);
        public IActionResult OnGetCreate() => Page();
        public async Task<IActionResult> OnPostCreateAsync(){
            if (!ModelState.IsValid)return Page();
            await repo.AddAsync(new TransportViewFactory().Create(Transport));
            return RedirectToPage("./Index","Index");
        }
        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Transport = await getTransport(id);
            return Transport == null ? NotFound() : Page();
        }
        private async Task<TransportView> getTransport(string id) 
            => new TransportViewFactory().Create(await repo.GetAsync(id)); 
        public async Task<IActionResult> OnGetDeleteAsync(string id) {
            Transport = await getTransport(id);
            return Transport == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id){
            if (id == null) return NotFound();
            await repo.DeleteAsync(id);
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Transport = await getTransport(id);
            return Transport == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostEditAsync(){
            if (!ModelState.IsValid) return Page();
            var obj = new TransportViewFactory().Create(Transport);
            var updated= await repo.UpdateAsync(obj);
            if(!updated) return NotFound();
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetIndexAsync(){
            var list = await repo.GetAsync();
            Transports = new List<TransportView>();
            foreach (var obj in list){
                var v = new TransportViewFactory().Create(obj);
                Transports.Add(v);
            }
            return Page();
        }
    }
}

