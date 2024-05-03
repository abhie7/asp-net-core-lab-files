using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproach.Models;

public partial class EmployeeContext : DbContext
{
    public EmployeeContext()
    {
    }

    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {}
    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     if (!optionsBuilder.IsConfigured)
    //     {
    //         optionsBuilder.UseMySql("Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;", 
    //             new MySqlServerVersion(new Version(8, 0, 21)), // replace with your Server Version
    //             mySqlOptions => mySqlOptions
    //                 .CharSetBehavior(CharSetBehavior.NeverAppend));
    //     }
    // }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PRIMARY");

            entity.ToTable("emp");

            entity.Property(e => e.EmpId)
                .HasColumnType("int(5)")
                .HasColumnName("emp_id");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .HasColumnName("emp_name");
            entity.Property(e => e.EmpSal)
                .HasColumnType("int(10)")
                .HasColumnName("emp_sal");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
