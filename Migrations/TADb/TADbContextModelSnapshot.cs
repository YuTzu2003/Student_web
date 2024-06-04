﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TA;

#nullable disable

namespace Student_web.Migrations.TADb
{
    [DbContext(typeof(TADbContext))]
    partial class TADbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TA.Feedback", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("txt")
                        .HasColumnType("varchar(50)");

                    b.HasKey("StudentID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("TA.TASchedule", b =>
                {
                    b.Property<string>("studentID")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ClassName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("studentName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("studentID");

                    b.ToTable("TASchedules");
                });

            modelBuilder.Entity("TA.TATable", b =>
                {
                    b.Property<int>("Tacourse_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INT");

                    b.Property<string>("Classroom")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CourseName")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("DATE");

                    b.Property<TimeSpan?>("Overtime")
                        .HasColumnType("TIME");

                    b.Property<bool>("Reserve")
                        .HasColumnType("TINYINT(1)");

                    b.Property<TimeSpan?>("Startime")
                        .HasColumnType("TIME");

                    b.Property<string>("TAName")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Tacourse_id");

                    b.ToTable("TATables");
                });
#pragma warning restore 612, 618
        }
    }
}
