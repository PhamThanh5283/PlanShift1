using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Table("Target_FPY_RTY")]
public partial class TargetFpyRty
{
    [Key]
    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    [Column("_Week")]
    [Unicode(false)]
    public string Week { get; set; } = null!;

    [Column("Target_FPY_SFT", TypeName = "decimal(18, 0)")]
    public decimal? TargetFpySft { get; set; }

    [Column("Target_RTY", TypeName = "decimal(18, 0)")]
    public decimal? TargetRty { get; set; }
}
