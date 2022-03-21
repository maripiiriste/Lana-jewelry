using Lana_jewelry.Data.Shipment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Domain.Shipment{
    public interface ITransportsRepo : IRepo<Transport> { }
    public class Transport: Entity<TransportData> {
        public Transport() : this(new TransportData()) { }
        public Transport(TransportData d) : base(d) { }
        public string CostumerAddress => getValue(Data?.CostumerAddress);
        public DateTime TransportDuration => getValue(Data?.Duration);
        public double TransportPrice => getValue(Data?.Price);
    }
}
