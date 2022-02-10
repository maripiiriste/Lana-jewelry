using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Data.Party
{
    public class CostumerData
    {
        public string Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DoB { get; set; }
        public string? Email { get; set; }
    }
}
