﻿using System.ComponentModel.DataAnnotations;

namespace Lana_jewelry.Facade {
    public abstract class BaseView {
        [Required] public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
