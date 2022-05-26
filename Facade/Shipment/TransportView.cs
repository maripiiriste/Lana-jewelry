using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Shipment{
    public sealed class TransportView: UniqueView{
        [Required] [DisplayName("Street")] public string? Street { get; set; }
        [Required] [DisplayName("City")] public string? City { get; set; }
        [Required] [DisplayName("Zip code")] public string? ZipCode { get; set; }
        [Required] [DisplayName("Country")] public string? CountryId { get; set; }
        [Required] [DisplayName("Transportation cost")] public double TransportPrice { get; set; }
        [Required] [DisplayName("Arrival time")] public DateTime TransportDuration { get; set; }
    }
    public sealed class TransportViewFactory : BaseViewFactory<TransportView, Transport, TransportData>{
        protected override Transport toEntity(TransportData d) => new(d);
        public override Transport Create(TransportView? v){
            v ??= new TransportView();
            return base.Create(v);
        }
    }
}
