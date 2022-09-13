﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.AtmCrs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("AtmCrs");
                });

            modelBuilder.Entity("Core.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AtmCrsId")
                        .HasColumnType("int");

                    b.Property<int>("CassetteSeries")
                        .HasColumnType("int");

                    b.Property<double?>("DAmount1")
                        .HasColumnType("float");

                    b.Property<double?>("DAmount2")
                        .HasColumnType("float");

                    b.Property<double?>("DAmount3")
                        .HasColumnType("float");

                    b.Property<double?>("DAmount4")
                        .HasColumnType("float");

                    b.Property<string>("DAmountToString1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DAmountToString2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DAmountToString3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DAmountToString4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DMoneyCount1")
                        .HasColumnType("int");

                    b.Property<int?>("DMoneyCount2")
                        .HasColumnType("int");

                    b.Property<int?>("DMoneyCount3")
                        .HasColumnType("int");

                    b.Property<int?>("DMoneyCount4")
                        .HasColumnType("int");

                    b.Property<int?>("DMoneyType1")
                        .HasColumnType("int");

                    b.Property<int?>("DMoneyType2")
                        .HasColumnType("int");

                    b.Property<int?>("DMoneyType3")
                        .HasColumnType("int");

                    b.Property<int?>("DMoneyType4")
                        .HasColumnType("int");

                    b.Property<double?>("DTotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("DTotalAmountToString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LetterNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AtmCrsId");

                    b.HasIndex("StatusId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("Core.Entities.RequestStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int?>("RequestId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.HasIndex("StatusId");

                    b.ToTable("RequestStatus");
                });

            modelBuilder.Entity("Core.Entities.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Core.Entities.Request", b =>
                {
                    b.HasOne("Core.Entities.AtmCrs", null)
                        .WithMany("Request")
                        .HasForeignKey("AtmCrsId");

                    b.HasOne("Core.Entities.Status", null)
                        .WithMany("Request")
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("Core.Entities.RequestStatus", b =>
                {
                    b.HasOne("Core.Entities.Request", null)
                        .WithMany("RequestStatus")
                        .HasForeignKey("RequestId");

                    b.HasOne("Core.Entities.Status", null)
                        .WithMany("RequestStatus")
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("Core.Entities.AtmCrs", b =>
                {
                    b.Navigation("Request");
                });

            modelBuilder.Entity("Core.Entities.Request", b =>
                {
                    b.Navigation("RequestStatus");
                });

            modelBuilder.Entity("Core.Entities.Status", b =>
                {
                    b.Navigation("Request");

                    b.Navigation("RequestStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
