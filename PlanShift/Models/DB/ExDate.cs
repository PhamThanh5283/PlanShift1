using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
[Table("Ex_Date")]
public partial class ExDate
{
    public int Inx { get; set; }

    [Column("_Date", TypeName = "date")]
    public DateTime? Date { get; set; }
}
