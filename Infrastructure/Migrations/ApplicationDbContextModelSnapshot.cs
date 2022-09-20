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

                    b.Property<double?>("CAmount1")
                        .HasColumnType("float");

                    b.Property<double?>("CAmount2")
                        .HasColumnType("float");

                    b.Property<double?>("CAmount3")
                        .HasColumnType("float");

                    b.Property<double?>("CAmount4")
                        .HasColumnType("float");

                    b.Property<string>("CAmountToString1")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CAmountToString2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CAmountToString3")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("CAmountToString4")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("CMoneyCount1")
                        .HasColumnType("int");

                    b.Property<int?>("CMoneyCount2")
                        .HasColumnType("int");

                    b.Property<int?>("CMoneyCount3")
                        .HasColumnType("int");

                    b.Property<int?>("CMoneyCount4")
                        .HasColumnType("int");

                    b.Property<int?>("CMoneyType1")
                        .HasColumnType("int");

                    b.Property<int?>("CMoneyType2")
                        .HasColumnType("int");

                    b.Property<int?>("CMoneyType3")
                        .HasColumnType("int");

                    b.Property<int?>("CMoneyType4")
                        .HasColumnType("int");

                    b.Property<double?>("CTotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("CTotalAmountToString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CassetteSeries")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Creator")
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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DAmountToString2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DAmountToString3")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DAmountToString4")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

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
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("LetterNo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestType")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<double?>("RjAmount1")
                        .HasColumnType("float");

                    b.Property<double?>("RjAmount2")
                        .HasColumnType("float");

                    b.Property<double?>("RjAmount3")
                        .HasColumnType("float");

                    b.Property<double?>("RjAmount4")
                        .HasColumnType("float");

                    b.Property<string>("RjAmountToString1")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RjAmountToString2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RjAmountToString3")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RjAmountToString4")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("RjMoneyCount1")
                        .HasColumnType("int");

                    b.Property<int?>("RjMoneyCount2")
                        .HasColumnType("int");

                    b.Property<int?>("RjMoneyCount3")
                        .HasColumnType("int");

                    b.Property<int?>("RjMoneyCount4")
                        .HasColumnType("int");

                    b.Property<int?>("RjMoneyType1")
                        .HasColumnType("int");

                    b.Property<int?>("RjMoneyType2")
                        .HasColumnType("int");

                    b.Property<int?>("RjMoneyType3")
                        .HasColumnType("int");

                    b.Property<int?>("RjMoneyType4")
                        .HasColumnType("int");

                    b.Property<double?>("RjTotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("RjTotalAmountToString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("RtAmount1")
                        .HasColumnType("float");

                    b.Property<double?>("RtAmount2")
                        .HasColumnType("float");

                    b.Property<double?>("RtAmount3")
                        .HasColumnType("float");

                    b.Property<double?>("RtAmount4")
                        .HasColumnType("float");

                    b.Property<string>("RtAmountToString1")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RtAmountToString2")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RtAmountToString3")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RtAmountToString4")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("RtMoneyCount1")
                        .HasColumnType("int");

                    b.Property<int?>("RtMoneyCount2")
                        .HasColumnType("int");

                    b.Property<int?>("RtMoneyCount3")
                        .HasColumnType("int");

                    b.Property<int?>("RtMoneyCount4")
                        .HasColumnType("int");

                    b.Property<int?>("RtMoneyType1")
                        .HasColumnType("int");

                    b.Property<int?>("RtMoneyType2")
                        .HasColumnType("int");

                    b.Property<int?>("RtMoneyType3")
                        .HasColumnType("int");

                    b.Property<int?>("RtMoneyType4")
                        .HasColumnType("int");

                    b.Property<double?>("RtTotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("RtTotalAmountToString")
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Creator")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

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
