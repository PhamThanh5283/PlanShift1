using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VTblResultSft
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("Line_no")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LineNo { get; set; }

    public int? Pass { get; set; }

    public int? Fail { get; set; }

    [Column("%Fail")]
    public double? Fail1 { get; set; }
}
