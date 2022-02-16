using Lana_jewelry.Data.Party;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Domain.Shipment
{
    public class Transport
    {
        private const string defaultStr = "Undefined";
        private const double defaultNr = 00.00;
        private DateTime defaultDate => DateTime.MinValue;
        private TransportData data;
        public Transport() : this(new TransportData()) { }
        public Transport(TransportData d) => data = d;
        public string TansportId => data?.TansportId ?? defaultStr;
        public string CostumerAddress => data?.CostumerAddress ?? defaultStr;
        public DateTime TrasnportDuration => data?.TrasnportDuration ?? defaultDate;
        public double TransportPrice => data?.TransportPrice ??defaultNr;
        public TransportData Data => data;
    }
}
