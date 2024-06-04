﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_web.Data;

#nullable disable

namespace Student_web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240413162948_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Student_web.Models.career", b =>
                {
                    b.Property<string>("company")
                        .HasColumnType("longtext");

                    b.Property<string>("department")
                        .HasColumnType("longtext");

                    b.Property<string>("grad_school")
                        .HasColumnType("longtext");

                    b.Property<string>("location")
                        .HasColumnType("longtext");

                    b.Property<string>("position")
                        .HasColumnType("longtext");

                    b.Property<string>("science")
                        .HasColumnType("longtext");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.ToTable("Career");
                });

            modelBuilder.Entity("Student_web.Models.Collection", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("collection_click_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("post_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("post_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("student_Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("student_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("collection");
                });

            modelBuilder.Entity("Student_web.Models.Files_post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("file_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("file_size")
                        .HasColumnType("bigint");

                    b.Property<string>("file_type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("post_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("post_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("upload_time")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("files_Post");
                });

            modelBuilder.Entity("Student_web.Models.Find_intern", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("company_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("item")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("keep")
                        .HasColumnType("int");

                    b.Property<int>("like")
                        .HasColumnType("int");

                    b.Property<string>("links")
                        .HasColumnType("longtext");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("salary")
                        .HasColumnType("int");

                    b.Property<string>("work_Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("find_intern");
                });

            modelBuilder.Entity("Student_web.Models.Login_History", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IP_Address")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("login_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("studentID")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Login_History");
                });

            modelBuilder.Entity("Student_web.Models.Member", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("AccessToken")
                        .HasColumnType("longtext");

                    b.Property<string>("Level")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("department")
                        .HasColumnType("longtext");

                    b.Property<string>("myPhoto")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.Property<string>("school")
                        .HasColumnType("longtext");

                    b.Property<string>("studentID")
                        .HasColumnType("longtext");

                    b.Property<string>("student_class")
                        .HasColumnType("longtext");

                    b.Property<string>("student_name")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("member");
                });

            modelBuilder.Entity("Student_web.Models.Message_post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("message_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("post_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("post_id")
                        .HasColumnType("int");

                    b.Property<string>("student_Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("student_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Message_post");
                });

            modelBuilder.Entity("Student_web.Models.Share_emp", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("dept")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("emp_status")
                        .HasColumnType("longtext");

                    b.Property<string>("item")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("keep")
                        .HasColumnType("int");

                    b.Property<int>("like")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("post")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("salary")
                        .HasColumnType("int");

                    b.Property<string>("share_intern")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("studentID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("share_emp");
                });

            modelBuilder.Entity("Student_web.Models.Share_intern", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("anonymous")
                        .HasColumnType("longtext");

                    b.Property<string>("company_name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("dept")
                        .HasColumnType("longtext");

                    b.Property<string>("experience")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("item")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("keep")
                        .HasColumnType("int");

                    b.Property<int>("like")
                        .HasColumnType("int");

                    b.Property<string>("link")
                        .HasColumnType("longtext");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<string>("post")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("salary")
                        .HasColumnType("int");

                    b.Property<string>("studentID")
                        .HasColumnType("longtext");

                    b.Property<string>("work_content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("share_intern");
                });

            modelBuilder.Entity("Student_web.Models.Thumb", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("like_click_time")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("post_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("post_id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("student_Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("student_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("thumb");
                });
#pragma warning restore 612, 618
        }
    }
}