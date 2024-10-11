using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("CohuEMS")]
public partial class CohuEm
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

    [Column("Red Mean")]
    [StringLength(255)]
    [Unicode(false)]
    public string? RedMean { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Bin { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Result { get; set; }
}
