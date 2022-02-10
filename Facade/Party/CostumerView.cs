﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lana_jewelry.Facade.Party
{
    public class CostumerView
    {
        [Required] public string Id { get; set; }
        [DisplayName("First name")] public string? FirstName { get; set; }
        [DisplayName("Last name")] public string? LastName { get; set; }
        [DisplayName("Date of birth")] public DateTime? DoB { get; set; }
        [DisplayName("Email")] [Required] public string? Email { get; set; }
    }
}
