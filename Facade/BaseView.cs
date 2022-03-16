using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade {
    public class BaseView {
        [Required] public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
