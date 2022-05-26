using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Data.Shipment{
    public sealed class TransportShoppingBagData : NamedData{
        public string ShoppingBagId { get; set; } = string.Empty;
        public string TransportId { get; set; } = string.Empty;
    }
}
