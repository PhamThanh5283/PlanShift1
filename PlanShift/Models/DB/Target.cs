using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Target")]
public partial class Target
{
    [Column("ID")]
    public string? Id { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("Line_no")]
    [Unicode(false)]
    public string? LineNo { get; set; }

    public string? Product { get; set; }

    [Column("Time_frame")]
    [StringLength(15)]
    [Unicode(false)]
    public string TimeFrame { get; set; } = null!;

    [Column("Target")]
    public int? Target1 { get; set; }
}
