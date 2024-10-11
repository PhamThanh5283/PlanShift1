using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class TimeFrame
{
    [Column("Line_no")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LineNo { get; set; }

    [Column("Time_Spane", TypeName = "datetime")]
    public DateTime? TimeSpane { get; set; }
}
