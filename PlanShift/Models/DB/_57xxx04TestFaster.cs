using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("57XXX04_test_faster")]
public partial class _57xxx04TestFaster
{
    [StringLength(50)]
    [Unicode(false)]
    public string Sorting { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string PartNumber { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Bin { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Bucket { get; set; } = null!;

    [Column("LSL")]
    [StringLength(255)]
    [Unicode(false)]
    public string Lsl { get; set; } = null!;

    [Column("USL")]
    [StringLength(255)]
    [Unicode(false)]
    public string Usl { get; set; } = null!;
}
