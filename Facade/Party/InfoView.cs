using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Facade.Party {
    
    public sealed class InfoView : BaseView {
        [DisplayName("Country")] [Required] public string? Country { get; set; }
        [DisplayName("City")] [Required] public string? City { get; set; }
        [DisplayName("Region")] [Required] public string? Region { get; set; }
        [DisplayName("Street")] [Required] public string? Street { get; set; }
        [DisplayName("Street number")] [Required] public string? StreetNumber { get; set; }
        [DisplayName("Zip code")] [Required] public string? ZipCode { get; set; }
        [DisplayName("Phone number")] [Required] public string? PhoneNumber { get; set; }
        [DisplayName("Email")] [Required] public string? EmailAddress { get; set; }
    }
    public sealed class InfoViewFactory : BaseViewFactory<InfoView, Info, InfoData> {
        protected override Info toEntity(InfoData d) => new(d);
    }
}
