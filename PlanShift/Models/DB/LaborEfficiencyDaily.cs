using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Labor_Efficiency_Daily")]
public partial class LaborEfficiencyDaily
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("SKU")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Sku { get; set; }

    [Column("_Shift")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Shift { get; set; }

    public double? Workhour { get; set; }

    public int? Headcount { get; set; }

    [Column("OT")]
    public double? Ot { get; set; }

    public int? Output { get; set; }

    public int Target { get; set; }

    public double? EarnHour { get; set; }

    public double? Efficiency { get; set; }
}
