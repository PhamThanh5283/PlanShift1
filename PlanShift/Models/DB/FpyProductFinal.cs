using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("FPY_Product_Final")]
public partial class FpyProductFinal
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("_Week")]
    [StringLength(270)]
    public string Week { get; set; } = null!;

    [Column("_Type")]
    [StringLength(3)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(255)]
    public string? Product { get; set; }

    public int? Input { get; set; }

    public int? Pass { get; set; }

    [Column("FPY", TypeName = "decimal(17, 10)")]
    public decimal? Fpy { get; set; }
}
