using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Time_Shift(Efficiency)")]
public partial class TimeShiftEfficiency
{
    [Column("ID", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("Plan_Shift")]
    [StringLength(255)]
    public string? PlanShift { get; set; }

    [Column("Start_time")]
    public TimeSpan? StartTime { get; set; }

    [Column("End_Time")]
    public TimeSpan? EndTime { get; set; }
}
