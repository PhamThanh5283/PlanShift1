using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Week_of_FY")]
public partial class WeekOfFy
{
    [StringLength(10)]
    [Unicode(false)]
    public string? Date { get; set; }

    [Column("_WeekFY")]
    [StringLength(270)]
    public string WeekFy { get; set; } = null!;
}
