using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Table("Plan_shift")]
public partial class PlanShift
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Plan_Date", TypeName = "date")]
    public DateTime? PlanDate { get; set; }

    [Column("Actual_Date", TypeName = "date")]
    public DateTime? ActualDate { get; set; }

    [Column("Plan_Shift")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PlanShift1 { get; set; }

    [Column("Start_Time")]
    public TimeSpan? StartTime { get; set; }

    [Column("End_Time")]
    public TimeSpan? EndTime { get; set; }
}
