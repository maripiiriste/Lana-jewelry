using Lana_jewelry.Data.Shipment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Domain.Shipment{
    public class Transport: Entity<TransportData> {
        private const string defaultStr = "Undefined";
        private const double defaultNr = 00.00;
        private DateTime defaultDate => DateTime.MinValue;
        public Transport() : this(new TransportData()) { }
        public Transport(TransportData d) : base(d) { }
        public string TransportId => Data?.TransportId ?? defaultStr;
        public string CostumerAddress => Data?.CostumerAddress ?? defaultStr;
        public DateTime TransportDuration => Data?.TransportDuration ?? defaultDate;
        public double TransportPrice => Data?.TransportPrice ??defaultNr;
    }
}
