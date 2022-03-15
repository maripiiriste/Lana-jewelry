using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Party {
    public class InfoView : BaseView {
        [Required] public string Country { get; set; }
        [Required] public string City { get; set; }
        [Required] public string Region { get; set; }
        [Required] public string Street { get; set; }
        [Required] public string StreetNumber { get; set; }
        [Required] public string ZipCode { get; set; }
        [Required] public string PhoneNumber { get; set; }
        [Required] public string EmailAddress { get; set; }
    }
}
