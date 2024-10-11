using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PlanShift.Models.DB;

public partial class EmsSftContext : DbContext
{
    public EmsSftContext()
    {
    }

    public EmsSftContext(DbContextOptions<EmsSftContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CohuEm> CohuEms { get; set; }

    public virtual DbSet<Em> Ems { get; set; }

    public virtual DbSet<ExDate> ExDates { get; set; }

    public virtual DbSet<FpyProduct> FpyProducts { get; set; }

    public virtual DbSet<FpyProductFinal> FpyProductFinals { get; set; }

    public virtual DbSet<Headcount> Headcounts { get; set; }

    public virtual DbSet<HeadcountOld> HeadcountOlds { get; set; }

    public virtual DbSet<LaborEfficiencyDaily> LaborEfficiencyDailies { get; set; }

    public virtual DbSet<LaborEfficiencyDailyTest> LaborEfficiencyDailyTests { get; set; }

    public virtual DbSet<ModeResultEmsSft> ModeResultEmsSfts { get; set; }

    public virtual DbSet<PivotEm> PivotEms { get; set; }

    public virtual DbSet<PivotSft> PivotSfts { get; set; }

    public virtual DbSet<PlanShift> PlanShifts { get; set; }

    public virtual DbSet<Routing> Routings { get; set; }

    public virtual DbSet<Sft> Sfts { get; set; }

    public virtual DbSet<Target> Targets { get; set; }

    public virtual DbSet<TargetFny> TargetFnies { get; set; }

    public virtual DbSet<TargetFpyRty> TargetFpyRties { get; set; }

    public virtual DbSet<TargetLaborEff> TargetLaborEffs { get; set; }

    public virtual DbSet<TargetLaborEffWeekly> TargetLaborEffWeeklies { get; set; }

    public virtual DbSet<TargetWeekOfFy> TargetWeekOfFies { get; set; }

    public virtual DbSet<TimeFrame> TimeFrames { get; set; }

    public virtual DbSet<TimeShift> TimeShifts { get; set; }

    public virtual DbSet<TimeShiftEfficiency> TimeShiftEfficiencies { get; set; }

    public virtual DbSet<Top10Em> Top10Ems { get; set; }

    public virtual DbSet<Top10Sft> Top10Sfts { get; set; }

    public virtual DbSet<VCohuEm> VCohuEms { get; set; }

    public virtual DbSet<VEm> VEms { get; set; }

    public virtual DbSet<VFailCode> VFailCodes { get; set; }

    public virtual DbSet<VFnyDaily> VFnyDailies { get; set; }

    public virtual DbSet<VFpyRtyDaily> VFpyRtyDailies { get; set; }

    public virtual DbSet<VFpyRtyProduct> VFpyRtyProducts { get; set; }

    public virtual DbSet<VFpyRtyWeekly> VFpyRtyWeeklies { get; set; }

    public virtual DbSet<VFpyRtyWeeklyProduct> VFpyRtyWeeklyProducts { get; set; }

    public virtual DbSet<VLaborEfficiencyWeekly> VLaborEfficiencyWeeklies { get; set; }

    public virtual DbSet<VSft> VSfts { get; set; }

    public virtual DbSet<VTblEmsresult> VTblEmsresults { get; set; }

    public virtual DbSet<VTblResultEm> VTblResultEms { get; set; }

    public virtual DbSet<VTblResultSft> VTblResultSfts { get; set; }

    public virtual DbSet<WeekOfFy> WeekOfFies { get; set; }

    public virtual DbSet<_57xxx04TestFaster> _57xxx04TestFasters { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=Default");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<ExDate>(entity =>
        {
            entity.Property(e => e.Inx).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ModeResultEmsSft>(entity =>
        {
            entity.HasKey(e => e.DatalogFailCode).HasName("PK_Datalog_Fail_Code");
        });

        modelBuilder.Entity<PlanShift>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Plan_shift_1");
        });

        modelBuilder.Entity<Routing>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TargetFpyRty>(entity =>
        {
            entity.HasKey(e => e.Date).HasName("PK_Date");
        });

        modelBuilder.Entity<TimeFrame>(entity =>
        {
            entity.ToView("TIME_FRAME");
        });

        modelBuilder.Entity<TimeShift>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TimeShiftEfficiency>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VCohuEm>(entity =>
        {
            entity.ToView("V_CohuEMS");
        });

        modelBuilder.Entity<VEm>(entity =>
        {
            entity.ToView("V_EMS");
        });

        modelBuilder.Entity<VFailCode>(entity =>
        {
            entity.ToView("V_FailCode");
        });

        modelBuilder.Entity<VFnyDaily>(entity =>
        {
            entity.ToView("V_FNY_Daily");
        });

        modelBuilder.Entity<VFpyRtyDaily>(entity =>
        {
            entity.ToView("V_FPY_RTY_Daily");
        });

        modelBuilder.Entity<VFpyRtyProduct>(entity =>
        {
            entity.ToView("V_FPY_RTY_Product");
        });

        modelBuilder.Entity<VFpyRtyWeekly>(entity =>
        {
            entity.ToView("V_FPY_RTY_Weekly");
        });

        modelBuilder.Entity<VFpyRtyWeeklyProduct>(entity =>
        {
            entity.ToView("V_FPY_RTY_Weekly_Product");
        });

        modelBuilder.Entity<VLaborEfficiencyWeekly>(entity =>
        {
            entity.ToView("V_Labor_Efficiency_Weekly");
        });

        modelBuilder.Entity<VSft>(entity =>
        {
            entity.ToView("V_SFT");
        });

        modelBuilder.Entity<VTblEmsresult>(entity =>
        {
            entity.ToView("V_Tbl_EMSResult");
        });

        modelBuilder.Entity<VTblResultEm>(entity =>
        {
            entity.ToView("V_Tbl_Result_EMS");
        });

        modelBuilder.Entity<VTblResultSft>(entity =>
        {
            entity.ToView("V_Tbl_Result_SFT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
