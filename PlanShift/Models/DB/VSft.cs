using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VSft
{
    [StringLength(255)]
    public string? M { get; set; }

    [Column("Machine Type")]
    [StringLength(255)]
    public string? MachineType { get; set; }

    [Column("Machine ID")]
    [StringLength(255)]
    public string? MachineId { get; set; }

    [StringLength(255)]
    public string? Product { get; set; }

    [StringLength(255)]
    public string? Version { get; set; }

    [Column("Date & Time")]
    [StringLength(255)]
    public string? DateTime { get; set; }

    [Column("Red Vf")]
    [StringLength(255)]
    public string? RedVf { get; set; }

    [Column("IR Vf")]
    [StringLength(255)]
    public string? IrVf { get; set; }

    [StringLength(255)]
    public string? Rcal { get; set; }

    [Column("LED Current Sense")]
    [StringLength(255)]
    public string? LedCurrentSense { get; set; }

    [Column("UUT IR Response")]
    [StringLength(255)]
    public string? UutIrResponse { get; set; }

    [Column("UUT Red Response")]
    [StringLength(255)]
    public string? UutRedResponse { get; set; }

    [Column("Dark Current")]
    [StringLength(255)]
    public string? DarkCurrent { get; set; }

    [Column("UUT Det Vf")]
    [StringLength(255)]
    public string? UutDetVf { get; set; }

    [Column("UUT Noise RMS")]
    [StringLength(255)]
    public string? UutNoiseRms { get; set; }

    [StringLength(255)]
    public string? Bin { get; set; }

    [StringLength(255)]
    public string? Result { get; set; }

    [Column("Serial Number")]
    [StringLength(255)]
    public string? SerialNumber { get; set; }

    [Column("Datalog Result Code")]
    [StringLength(255)]
    public string? DatalogResultCode { get; set; }

    [Column("Digical Fail Code")]
    [StringLength(255)]
    public string? DigicalFailCode { get; set; }

    [StringLength(255)]
    public string? Priority { get; set; }

    [Column("Line_no")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LineNo { get; set; }

    [Column("Time_frame")]
    [StringLength(15)]
    [Unicode(false)]
    public string TimeFrame { get; set; } = null!;

    [Column("Description_code")]
    [StringLength(255)]
    public string? DescriptionCode { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string Month { get; set; } = null!;

    [Column("WEEK")]
    public int? Week { get; set; }

    [Column(TypeName = "date")]
    public DateTime? Date { get; set; }
}
