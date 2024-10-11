using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Headcount")]
public partial class Headcount
{
    [Column("_Date", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("SKU")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Sku { get; set; }

    [Column("_Shift")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Shift { get; set; }

    [Column("OT_Time")]
    public double? OtTime { get; set; }

    public int? Quantity { get; set; }
}
