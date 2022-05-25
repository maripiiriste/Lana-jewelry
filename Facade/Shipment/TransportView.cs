using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Shipment;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade.Shipment{
    public sealed class TransportView: UniqueView{
        [Required] [DisplayName("Street")] public string? Street { get; set; }
        [DisplayName("City")] public string? City { get; set; }
        [DisplayName("Zip code")] public string? ZipCode { get; set; }
        [DisplayName("Country")] public string? CountryId { get; set; }
        [DisplayName("Transportation cost")] [Required] public double TransportPrice { get; set; }
        [DisplayName("Arrival time")] [Required] public DateTime TransportDuration { get; set; }
    }
    public sealed class TransportViewFactory : BaseViewFactory<TransportView, Transport, TransportData>{
        protected override Transport toEntity(TransportData d) => new(d);
        public override Transport Create(TransportView? v){
            v ??= new TransportView();
            return base.Create(v);
        }
    }
}
