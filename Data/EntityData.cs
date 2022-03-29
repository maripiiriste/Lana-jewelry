

namespace Lana_jewelry.Data{
    public class EntityData{
        public static string NewId=> Guid.NewGuid().ToString();
        public string Id { get; set; } = NewId;
    }
}
