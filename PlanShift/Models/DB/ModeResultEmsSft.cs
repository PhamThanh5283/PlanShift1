using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Table("Mode_result_EMS_SFT")]
public partial class ModeResultEmsSft
{
    [Column("ID")]
    public int? Id { get; set; }

    [Key]
    [Column("Datalog_Fail_Code")]
    [StringLength(255)]
    public string DatalogFailCode { get; set; } = null!;

    [Column("_Description")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("Type_Machine")]
    [StringLength(255)]
    [Unicode(false)]
    public string? TypeMachine { get; set; }
}
