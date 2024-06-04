﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_web.ClassroomData;

#nullable disable

namespace Student_web.Migrations.ClassroomDb
{
    [DbContext(typeof(ClassroomDbContext))]
    partial class ClassroomDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("student_platformdb.Appointment_record", b =>
                {
                    b.Property<int>("Record_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("text");

                    b.Property<string>("Classroom_id")
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("TIMESTAMP");

                    b.Property<string>("Reason")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ReservationTime")
                        .HasColumnType("DateTime");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("TIMESTAMP");

                    b.Property<sbyte?>("State")
                        .HasColumnType("TINYINT");

                    b.Property<string>("Student_id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Student_name")
                        .HasColumnType("text");

                    b.Property<string>("Use")
                        .HasColumnType("text");

                    b.HasKey("Record_id");

                    b.ToTable("Appointment_record");
                });

            modelBuilder.Entity("student_platformdb.borrow_key", b =>
                {
                    b.Property<int>("borrow_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Class")
                        .HasColumnType("text");

                    b.Property<string>("Classroom_id")
                        .HasColumnType("text");

                    b.Property<string>("Student_id")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Student_name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("borrow_time")
                        .HasColumnType("TIMESTAMP");

                    b.Property<DateTime?>("return_time")
                        .HasColumnType("DateTime");

                    b.HasKey("borrow_id");

                    b.ToTable("borrow_key");
                });

            modelBuilder.Entity("student_platformdb.Classroom_information", b =>
                {
                    b.Property<int>("Classinformation_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Capacity")
                        .HasColumnType("text");

                    b.Property<string>("Classroom_id")
                        .HasColumnType("text");

                    b.Property<sbyte?>("Classroom_state")
                        .HasColumnType("TINYINT");

                    b.Property<string>("Equipment")
                        .HasColumnType("text");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<string>("remark")
                        .HasColumnType("text");

                    b.HasKey("Classinformation_id");

                    b.ToTable("Classroom_information");
                });

            modelBuilder.Entity("student_platformdb.Fixed_classschedule", b =>
                {
                    b.Property<int>("Classchedule_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Classroom_id")
                        .HasColumnType("text");

                    b.Property<string>("Course_name")
                        .HasColumnType("text");

                    b.Property<string>("Teacher_name")
                        .HasColumnType("text");

                    b.Property<sbyte?>("Week")
                        .HasColumnType("TINYINT");

                    b.Property<TimeSpan?>("endtime_course")
                        .HasColumnType("TIME");

                    b.Property<TimeSpan?>("starttime_course")
                        .HasColumnType("TIME");

                    b.HasKey("Classchedule_id");

                    b.ToTable("Fixed_classschedule");
                });

            modelBuilder.Entity("student_platformdb.usage_rules", b =>
                {
                    b.Property<int>("rules_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("rules")
                        .HasColumnType("text");

                    b.HasKey("rules_id");

                    b.ToTable("usage_rules");
                });
#pragma warning restore 612, 618
        }
    }
}
