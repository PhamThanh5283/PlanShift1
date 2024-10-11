using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Pivot_EMS")]
public partial class PivotEm
{
    public int? Week { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Date { get; set; }

    [StringLength(255)]
    public string? Product { get; set; }

    [Column("Serial Number")]
    [StringLength(255)]
    public string? SerialNumber { get; set; }

    public int? Fail { get; set; }

    public int? Pass { get; set; }
}
