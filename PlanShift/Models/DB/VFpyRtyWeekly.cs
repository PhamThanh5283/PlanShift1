using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VFpyRtyWeekly
{
    [Column("_Week")]
    [Unicode(false)]
    public string? Week { get; set; }

    public int? Inx { get; set; }

    [Column("FPY SFT", TypeName = "decimal(38, 15)")]
    public decimal? FpySft { get; set; }

    [Column("RTY", TypeName = "decimal(38, 6)")]
    public decimal? Rty { get; set; }
}
