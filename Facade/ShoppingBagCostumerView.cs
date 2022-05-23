using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Lana_jewelry.Facade {
    public class ShoppingBagCostumerView : NamedView {
        [Required] [DisplayName("ShoppingBag")] public string ShoppingBagId { get; set; } = string.Empty;
        [Required] [DisplayName("Costumer")] public string CostumerId { get; set; } = string.Empty;
    }
    public sealed class ShoppingBagCostumerViewFactory : BaseViewFactory<ShoppingBagCostumerView, ShoppingBagCostumer, ShoppingBagCostumerData> {
        protected override ShoppingBagCostumer toEntity(ShoppingBagCostumerData d) => new(d);
    }
}
