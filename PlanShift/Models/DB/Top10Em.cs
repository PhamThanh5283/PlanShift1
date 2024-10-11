using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("TOP10_EMS")]
public partial class Top10Em
{
    [Column("Machine Type")]
    [StringLength(255)]
    public string? MachineType { get; set; }

    [Column("Machine ID")]
    [StringLength(255)]
    public string? MachineId { get; set; }

    [StringLength(255)]
    public string? Product { get; set; }

    [StringLength(255)]
    public string? Version { get; set; }

    [Column("Date & Time")]
    [StringLength(255)]
    public string? DateTime { get; set; }

    [StringLength(255)]
    public string? Bin { get; set; }

    [StringLength(255)]
    public string? Result { get; set; }

    [Column("Serial Number")]
    [StringLength(255)]
    public string? SerialNumber { get; set; }

    [Column("Datalog Result Code")]
    [StringLength(255)]
    public string? DatalogResultCode { get; set; }

    [Column("Digical Fail Code")]
    [StringLength(255)]
    public string? DigicalFailCode { get; set; }

    [Column("Line_no")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LineNo { get; set; }

    [Column("Plan_Shift")]
    [StringLength(255)]
    public string? PlanShift { get; set; }

    [Column("Time_frame")]
    [StringLength(15)]
    [Unicode(false)]
    public string TimeFrame { get; set; } = null!;

    [Column("Description_code")]
    [StringLength(255)]
    public string? DescriptionCode { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string Month { get; set; } = null!;

    [Column("WEEK")]
    public int? Week { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }
}
