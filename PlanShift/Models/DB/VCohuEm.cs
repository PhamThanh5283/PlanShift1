using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VCohuEm
{
    [Column("Machine Type")]
    [StringLength(255)]
    [Unicode(false)]
    public string? MachineType { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Product { get; set; }

    [Column("Date & Time")]
    [StringLength(255)]
    [Unicode(false)]
    public string? DateTime { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    public TimeSpan? Time { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string Timeframe { get; set; } = null!;

    [Column("Red Mean")]
    [StringLength(255)]
    [Unicode(false)]
    public string? RedMean { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Bin { get; set; }

    [Column("LSL")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Lsl { get; set; }

    [Column("USL")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Usl { get; set; }
}
