using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Data {
    public abstract class UniqueData{
        public static string NewId=> Guid.NewGuid().ToString();
        public static byte[] empty=>Array.Empty<byte>();
        public string Id { get; set; } = NewId;
        [Timestamp] public byte[] Token { get; set; } = empty;
    }
}
