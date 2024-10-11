using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Target_LaborEff")]
public partial class TargetLaborEff
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public double? Target { get; set; }
}
