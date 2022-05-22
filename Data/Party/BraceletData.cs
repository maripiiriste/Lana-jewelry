using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Data.Party {
    public sealed class BraceletData:UniqueData {
        public string? Name { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get;set; }
    }
}
