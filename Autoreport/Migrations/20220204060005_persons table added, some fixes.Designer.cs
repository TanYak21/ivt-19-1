﻿// <auto-generated />
using System;
using Autoreport.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Autoreport.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220204060005_persons table added, some fixes")]
    partial class personstableaddedsomefixes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Autoreport.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Autoreport.Models.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Deposits");
                });

            modelBuilder.Entity("Autoreport.Models.Disk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<int>("Current_count")
                        .HasColumnType("int");

                    b.Property<int>("General_count")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Disks");
                });

            modelBuilder.Entity("Autoreport.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DiskId")
                        .HasColumnType("int");

                    b.Property<int?>("FilmCountyId")
                        .HasColumnType("int");

                    b.Property<int?>("FilmDirectorId")
                        .HasColumnType("int");

                    b.Property<int?>("FilmStudioId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("DiskId");

                    b.HasIndex("FilmCountyId");

                    b.HasIndex("FilmDirectorId");

                    b.HasIndex("FilmStudioId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Autoreport.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("Autoreport.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("double");

                    b.Property<int?>("OrderClientId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderDepositId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderEmployeerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("Return_date")
                        .HasColumnType("datetime");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderClientId");

                    b.HasIndex("OrderDepositId");

                    b.HasIndex("OrderEmployeerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Autoreport.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("First_name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Second_name")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Autoreport.Models.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("Autoreport.Models.Client", b =>
                {
                    b.HasBaseType("Autoreport.Models.Person");

                    b.Property<int>("Debt_count")
                        .HasColumnType("int");

                    b.Property<int>("Order_count")
                        .HasColumnType("int");

                    b.Property<string>("Phone_number1")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Phone_number2")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Autoreport.Models.Director", b =>
                {
                    b.HasBaseType("Autoreport.Models.Person");

                    b.HasDiscriminator().HasValue("Director");
                });

            modelBuilder.Entity("Autoreport.Models.Employeer", b =>
                {
                    b.HasBaseType("Autoreport.Models.Person");

                    b.Property<int>("Passport_number")
                        .HasColumnType("int");

                    b.Property<int>("Passport_serial")
                        .HasColumnType("int");

                    b.Property<string>("Phone_number")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasDiscriminator().HasValue("Employeer");
                });

            modelBuilder.Entity("Autoreport.Models.Disk", b =>
                {
                    b.HasOne("Autoreport.Models.Order", null)
                        .WithMany("Disks")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("Autoreport.Models.Film", b =>
                {
                    b.HasOne("Autoreport.Models.Disk", null)
                        .WithMany("Films")
                        .HasForeignKey("DiskId");

                    b.HasOne("Autoreport.Models.Country", "FilmCounty")
                        .WithMany()
                        .HasForeignKey("FilmCountyId");

                    b.HasOne("Autoreport.Models.Director", "FilmDirector")
                        .WithMany()
                        .HasForeignKey("FilmDirectorId");

                    b.HasOne("Autoreport.Models.Studio", "FilmStudio")
                        .WithMany()
                        .HasForeignKey("FilmStudioId");

                    b.Navigation("FilmCounty");

                    b.Navigation("FilmDirector");

                    b.Navigation("FilmStudio");
                });

            modelBuilder.Entity("Autoreport.Models.Genre", b =>
                {
                    b.HasOne("Autoreport.Models.Film", null)
                        .WithMany("Genres")
                        .HasForeignKey("FilmId");
                });

            modelBuilder.Entity("Autoreport.Models.Order", b =>
                {
                    b.HasOne("Autoreport.Models.Client", "OrderClient")
                        .WithMany()
                        .HasForeignKey("OrderClientId");

                    b.HasOne("Autoreport.Models.Deposit", "OrderDeposit")
                        .WithMany()
                        .HasForeignKey("OrderDepositId");

                    b.HasOne("Autoreport.Models.Employeer", "OrderEmployeer")
                        .WithMany()
                        .HasForeignKey("OrderEmployeerId");

                    b.Navigation("OrderClient");

                    b.Navigation("OrderDeposit");

                    b.Navigation("OrderEmployeer");
                });

            modelBuilder.Entity("Autoreport.Models.Disk", b =>
                {
                    b.Navigation("Films");
                });

            modelBuilder.Entity("Autoreport.Models.Film", b =>
                {
                    b.Navigation("Genres");
                });

            modelBuilder.Entity("Autoreport.Models.Order", b =>
                {
                    b.Navigation("Disks");
                });
#pragma warning restore 612, 618
        }
    }
}
