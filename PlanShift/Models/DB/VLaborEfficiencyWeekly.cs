using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VLaborEfficiencyWeekly
{
    [Column("_WeekFY")]
    [StringLength(270)]
    public string WeekFy { get; set; } = null!;

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

    public double? Earnhour { get; set; }

    public double? Efficiency { get; set; }

    public int? Inx { get; set; }
}
