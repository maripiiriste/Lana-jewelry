using Lana_jewelry.Data.Party;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Domain.Party
{
    public class Costumer
    {
        private const string defaultStr = "Undefined";
        private DateTime defaultDate => DateTime.MinValue;
        private CostumerData data;
        public Costumer(): this(new CostumerData()) { }
        public Costumer(CostumerData d) => data = d;
        public string Id=>data?.Id?? defaultStr;
        public string FirstName => data?.FirstName ?? defaultStr;
        public string LastName => data?.LastName ?? defaultStr;
        public DateTime DoB => data?.DoB ?? defaultDate;
        public string Email=>data?.Email ?? defaultStr;
        public CostumerData Data => data;
        public override string ToString() => $"{FirstName} {LastName} {Email} ({DoB})";

    }
}
