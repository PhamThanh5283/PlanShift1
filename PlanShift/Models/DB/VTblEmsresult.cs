using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VTblEmsresult
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("Line_no")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LineNo { get; set; }

    [StringLength(255)]
    public string? Result { get; set; }

    public double? Quantity { get; set; }
}
