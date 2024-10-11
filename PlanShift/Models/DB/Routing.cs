using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Routing")]
public partial class Routing
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("_Values")]
    public double? Values { get; set; }

    [Column("SKU")]
    [StringLength(255)]
    public string Sku { get; set; } = null!;

    [Column("Valid_from", TypeName = "date")]
    public DateTime? ValidFrom { get; set; }

    [Column("Valid_to", TypeName = "date")]
    public DateTime? ValidTo { get; set; }
}
