﻿// <auto-generated />
using CodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstApproach.Migrations
{
    [DbContext(typeof(EmployeeDBContext))]
    [Migration("20240416144600_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirstApproach.Models.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Desig")
                        .HasColumnType("longtext");

                    b.Property<string>("Ename")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Empname");

                    b.HasKey("Eid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CodeFirstApproach.Models.ErrorViewModel", b =>
                {
                    b.Property<string>("RequestId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("RequestId");

                    b.ToTable("ErrorViewModel");
                });
#pragma warning restore 612, 618
        }
    }
}