using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Target_Week_of_FY")]
public partial class TargetWeekOfFy
{
    [Column("_WeekFY")]
    [StringLength(270)]
    public string WeekFy { get; set; } = null!;

    [Column("RTY Target", TypeName = "decimal(18, 0)")]
    public decimal? RtyTarget { get; set; }

    [Column("FPY SFT Target", TypeName = "decimal(18, 0)")]
    public decimal? FpySftTarget { get; set; }
}
