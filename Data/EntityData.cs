
using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Data{
    public class EntityData{
        [Key] public string TransportId { get; set; }
        public string Id { get; set; }
    }
}
