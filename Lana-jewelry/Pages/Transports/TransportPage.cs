using Lana_jewelry.Domain.Shipment;
using Lana_jewelry.Facade.Shipment;
using Lana_jewelry.Infra;
using Lana_jewelry.Infra.Shipment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lana_jewelry.Pages.Transports{
    public class TransportPage:PageModel
    {
        private readonly ITransportsRepo repo;
        [BindProperty] public TransportView Item { get; set; }
        public string ItemId=> Item?.Id?? string.Empty;
        public IList<TransportView> Items { get; set; }
        public TransportPage(Lana_jewelryDb c) => repo = new TransportsRepo(c, c.Transports);
        public IActionResult OnGetCreate() => Page();
        public async Task<IActionResult> OnPostCreateAsync(){
            if (!ModelState.IsValid)return Page();
            await repo.AddAsync(new TransportViewFactory().Create(Item));
            return RedirectToPage("./Index","Index");
        }
        public async Task<IActionResult> OnGetDetailsAsync(string id)
        {
            Item = await getTransport(id);
            return Item == null ? NotFound() : Page();
        }
        private async Task<TransportView> getTransport(string id) 
            => new TransportViewFactory().Create(await repo.GetAsync(id)); 
        public async Task<IActionResult> OnGetDeleteAsync(string id) {
            Item = await getTransport(id);
            return Item == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostDeleteAsync(string id){
            if (id == null) return NotFound();
            await repo.DeleteAsync(id);
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetEditAsync(string id)
        {
            Item = await getTransport(id);
            return Item == null ? NotFound() : Page();
        }
        public async Task<IActionResult> OnPostEditAsync(){
            if (!ModelState.IsValid) return Page();
            var obj = new TransportViewFactory().Create(Item);
            var updated= await repo.UpdateAsync(obj);
            if(!updated) return NotFound();
            return RedirectToPage("./Index", "Index");
        }
        public async Task<IActionResult> OnGetIndexAsync(){
            var list = await repo.GetAsync();
            Items = new List<TransportView>();
            foreach (var obj in list){
                var v = new TransportViewFactory().Create(obj);
                Items.Add(v);
            }
            return Page();
        }
    }
}

