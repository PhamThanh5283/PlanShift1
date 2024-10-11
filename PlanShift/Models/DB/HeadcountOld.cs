using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Headcount(old)")]
public partial class HeadcountOld
{
    [Column("_Date", TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("Work_center")]
    public string? WorkCenter { get; set; }

    public string? Position { get; set; }

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
