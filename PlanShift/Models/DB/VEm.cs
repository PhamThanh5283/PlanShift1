using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

[Keyless]
public partial class VEm
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

    [Column("Red Mean")]
    [StringLength(255)]
    public string? RedMean { get; set; }

    [Column("Red Secondary")]
    [StringLength(255)]
    public string? RedSecondary { get; set; }

    [Column("Red FWHM")]
    [StringLength(255)]
    public string? RedFwhm { get; set; }

    [Column("Red Signal")]
    [StringLength(255)]
    public string? RedSignal { get; set; }

    [Column("Red Vf")]
    [StringLength(255)]
    public string? RedVf { get; set; }

    [Column("Red ROP")]
    [StringLength(255)]
    public string? RedRop { get; set; }

    [Column("Red PTU")]
    [StringLength(255)]
    public string? RedPtu { get; set; }

    [Column("Red anV")]
    [StringLength(255)]
    public string? RedAnV { get; set; }

    [Column("Red Shunt")]
    [StringLength(255)]
    public string? RedShunt { get; set; }

    [Column("IR Mean")]
    [StringLength(255)]
    public string? IrMean { get; set; }

    [Column("IR Secondary")]
    [StringLength(255)]
    public string? IrSecondary { get; set; }

    [Column("IR FWHM")]
    [StringLength(255)]
    public string? IrFwhm { get; set; }

    [Column("IR Signal")]
    [StringLength(255)]
    public string? IrSignal { get; set; }

    [Column("IR Vf")]
    [StringLength(255)]
    public string? IrVf { get; set; }

    [Column("IR ROP")]
    [StringLength(255)]
    public string? IrRop { get; set; }

    [Column("IR PTU")]
    [StringLength(255)]
    public string? IrPtu { get; set; }

    [Column("IR anV")]
    [StringLength(255)]
    public string? IrAnV { get; set; }

    [Column("IR Shunt")]
    [StringLength(255)]
    public string? IrShunt { get; set; }

    [StringLength(255)]
    public string? Ratio { get; set; }

    [Column("Det Vf")]
    [StringLength(255)]
    public string? DetVf { get; set; }

    [Column("Det anV")]
    [StringLength(255)]
    public string? DetAnV { get; set; }

    [Column("Det caV")]
    [StringLength(255)]
    public string? DetCaV { get; set; }

    [StringLength(255)]
    public string? Rcal { get; set; }

    [Column("LED I")]
    [StringLength(255)]
    public string? LedI { get; set; }

    [Column("Dark I")]
    [StringLength(255)]
    public string? DarkI { get; set; }

    [Column("Down Switch")]
    [StringLength(255)]
    public string? DownSwitch { get; set; }

    [Column("Noise(b)")]
    [StringLength(255)]
    public string? NoiseB { get; set; }

    [Column("Noise(t)")]
    [StringLength(255)]
    public string? NoiseT { get; set; }

    [StringLength(255)]
    public string? Noise { get; set; }

    [StringLength(255)]
    public string? Temperature { get; set; }

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
