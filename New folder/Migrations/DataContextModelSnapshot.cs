﻿// <auto-generated />
using System;
using MIS.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace MIS.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MIS.Entity.Author", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Genre")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool?>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MIS.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Region")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<bool?>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MIS.Entity.Manager", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime?>("Dob")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Gender")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("MIS.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("AuthorobjId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Category")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long?>("Price")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long?>("RemainingQuantity")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long?>("SoldQuantity")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long?>("WarehouseId")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorobjId");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MIS.Entity.Shop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("MIS.Entity.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("MIS.Entity.StaffManager", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.HasKey("id");

                    b.ToTable("StaffManagers");
                });

            modelBuilder.Entity("MIS.Entity.StaffProduct", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("StaffId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffProducts");
                });

            modelBuilder.Entity("MIS.Entity.StaffStatistic", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<int?>("StaffId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("StatisticId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("id");

                    b.HasIndex("StaffId");

                    b.HasIndex("StatisticId");

                    b.ToTable("StaffStatistics");
                });

            modelBuilder.Entity("MIS.Entity.Statistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Type")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long?>("WarehouseId")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("MIS.Entity.StatisticCustomer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<long>("MoneySpent")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("Quantity")
                        .HasColumnType("NUMBER(19)");

                    b.Property<int?>("StatisticId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StatisticId");

                    b.ToTable("StatisticsCustomer");
                });

            modelBuilder.Entity("MIS.Entity.StatisticManager", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<long?>("Managerid")
                        .HasColumnType("NUMBER(19)");

                    b.Property<int?>("StatisticId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("id");

                    b.HasIndex("Managerid");

                    b.HasIndex("StatisticId");

                    b.ToTable("StatisticManagers");
                });

            modelBuilder.Entity("MIS.Entity.Warehouse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Description")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long?>("ShopId")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.HasIndex("ShopId");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("MIS.Entity.Product", b =>
                {
                    b.HasOne("MIS.Entity.Author", "Authorobj")
                        .WithMany()
                        .HasForeignKey("AuthorobjId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MIS.Entity.Warehouse", "Warehouse")
                        .WithMany("products")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("Authorobj");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("MIS.Entity.StaffProduct", b =>
                {
                    b.HasOne("MIS.Entity.Product", null)
                        .WithMany("staffProducts")
                        .HasForeignKey("ProductId");

                    b.HasOne("MIS.Entity.Staff", null)
                        .WithMany("staffProducts")
                        .HasForeignKey("StaffId");
                });

            modelBuilder.Entity("MIS.Entity.StaffStatistic", b =>
                {
                    b.HasOne("MIS.Entity.Staff", null)
                        .WithMany("staffStatistics")
                        .HasForeignKey("StaffId");

                    b.HasOne("MIS.Entity.Statistic", null)
                        .WithMany("staffStatistics")
                        .HasForeignKey("StatisticId");
                });

            modelBuilder.Entity("MIS.Entity.Statistic", b =>
                {
                    b.HasOne("MIS.Entity.Warehouse", "Warehouse")
                        .WithMany("statistics")
                        .HasForeignKey("WarehouseId");

                    b.Navigation("Warehouse");
                });

            modelBuilder.Entity("MIS.Entity.StatisticCustomer", b =>
                {
                    b.HasOne("MIS.Entity.Customer", null)
                        .WithMany("statisticCustomers")
                        .HasForeignKey("CustomerId");

                    b.HasOne("MIS.Entity.Statistic", null)
                        .WithMany("statisticCustomers")
                        .HasForeignKey("StatisticId");
                });

            modelBuilder.Entity("MIS.Entity.StatisticManager", b =>
                {
                    b.HasOne("MIS.Entity.Manager", null)
                        .WithMany("statisticManagers")
                        .HasForeignKey("Managerid");

                    b.HasOne("MIS.Entity.Statistic", null)
                        .WithMany("statisticManagers")
                        .HasForeignKey("StatisticId");
                });

            modelBuilder.Entity("MIS.Entity.Warehouse", b =>
                {
                    b.HasOne("MIS.Entity.Shop", "Shop")
                        .WithMany("warehouses")
                        .HasForeignKey("ShopId");

                    b.Navigation("Shop");
                });

            modelBuilder.Entity("MIS.Entity.Customer", b =>
                {
                    b.Navigation("statisticCustomers");
                });

            modelBuilder.Entity("MIS.Entity.Manager", b =>
                {
                    b.Navigation("statisticManagers");
                });

            modelBuilder.Entity("MIS.Entity.Product", b =>
                {
                    b.Navigation("staffProducts");
                });

            modelBuilder.Entity("MIS.Entity.Shop", b =>
                {
                    b.Navigation("warehouses");
                });

            modelBuilder.Entity("MIS.Entity.Staff", b =>
                {
                    b.Navigation("staffProducts");

                    b.Navigation("staffStatistics");
                });

            modelBuilder.Entity("MIS.Entity.Statistic", b =>
                {
                    b.Navigation("staffStatistics");

                    b.Navigation("statisticCustomers");

                    b.Navigation("statisticManagers");
                });

            modelBuilder.Entity("MIS.Entity.Warehouse", b =>
                {
                    b.Navigation("products");

                    b.Navigation("statistics");
                });
#pragma warning restore 612, 618
        }
    }
}
