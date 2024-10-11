using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Target_FNY")]
public partial class TargetFny
{
    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    [Column("_Week")]
    [Unicode(false)]
    public string Week { get; set; } = null!;

    [Column("SFT", TypeName = "decimal(18, 0)")]
    public decimal? Sft { get; set; }

    [Column("EMS", TypeName = "decimal(18, 0)")]
    public decimal? Ems { get; set; }
}
