using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VFpyRtyProduct
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("_Week")]
    [Unicode(false)]
    public string? Week { get; set; }

    [StringLength(255)]
    public string? Product { get; set; }

    [Column("SFT", TypeName = "decimal(38, 15)")]
    public decimal? Sft { get; set; }

    [Column("EMS", TypeName = "decimal(38, 15)")]
    public decimal? Ems { get; set; }

    [Column("RTY", TypeName = "decimal(38, 6)")]
    public decimal? Rty { get; set; }
}
