using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Target_LaborEff_Weekly")]
public partial class TargetLaborEffWeekly
{
    [Column("WeekFY")]
    [StringLength(255)]
    public string? WeekFy { get; set; }

    public double? Target { get; set; }
}
