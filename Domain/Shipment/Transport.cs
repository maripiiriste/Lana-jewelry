using Lana_jewelry.Data.Shipment;
using Lana_jewelry.Domain.Party;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Domain.Shipment{
    public interface ITransportsRepo : IRepo<Transport> { }
    public class Transport: UniqueEntity<TransportData> {
        public Transport() : this(new ()) { }
        public Transport(TransportData d) : base(d) { }
        public string Street => getValue(Data?.Street);
        public string City => getValue(Data?.City);
        public string ZipCode => getValue(Data?.ZipCode);
        public string CountryId => getValue(Data?.CountryId);
        public DateTime TransportDuration => getValue(Data?.Duration);
        public double TransportPrice => getValue(Data?.Price);
        public override string ToString() => $"{Street} {City} {ZipCode} {CountryId}";

        public Country? Country { get; set; }
    }
}
