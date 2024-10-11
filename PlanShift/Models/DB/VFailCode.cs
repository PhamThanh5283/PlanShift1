using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VFailCode
{
    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }

    [Column("_Type")]
    [StringLength(3)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [StringLength(255)]
    public string? Product { get; set; }

    [Column("Description_code")]
    [StringLength(255)]
    public string? DescriptionCode { get; set; }

    public int? Quantity { get; set; }

    [Column("%ofQty")]
    public double? OfQty { get; set; }
}
