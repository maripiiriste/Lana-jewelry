using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Party {
    public class CostumerView:BaseView
    {
        [DisplayName("First name")] public string? FirstName { get; set; }
        [DisplayName("Last name")] public string? LastName { get; set; }
        [DisplayName("Date of birth")] public DateTime? DoB { get; set; }
        [DisplayName("Email")] [Required] public string? Email { get; set; }
    }
    public sealed class CostumerViewFactory : BaseViewFactory<CostumerView, Costumer, CostumerData> {
        protected override Costumer toEntity(CostumerData d) => new(d);
    }
}
