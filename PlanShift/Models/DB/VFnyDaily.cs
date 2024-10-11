using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VFnyDaily
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("_Week")]
    [StringLength(270)]
    public string Week { get; set; } = null!;

    [Column("FNY_SFT", TypeName = "decimal(38, 15)")]
    public decimal? FnySft { get; set; }

    [Column("FNY_EMS", TypeName = "decimal(38, 15)")]
    public decimal? FnyEms { get; set; }
}
