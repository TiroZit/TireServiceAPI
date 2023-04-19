﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TireServiceAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230419121943_product3")]
    partial class product3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TireServiceAPI.Models.Product.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Diameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Diameters");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.Tire", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Diameter")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("TireProfile")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TireSeason")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Brand");

                    b.HasIndex("Diameter");

                    b.HasIndex("TireProfile");

                    b.HasIndex("TireSeason");

                    b.HasIndex("Width");

                    b.ToTable("Tires");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("TireProfiles");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireSeason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("TireSeasons");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Wheel.Wheel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Diameter")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("WheelType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Brand");

                    b.HasIndex("Diameter");

                    b.HasIndex("WheelType");

                    b.HasIndex("Width");

                    b.ToTable("Wheels");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Wheel.WheelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("WheelTypes");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Width", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("Widths");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.Tire", b =>
                {
                    b.HasOne("TireServiceAPI.Models.Product.Brand", "Brands")
                        .WithMany("Tires")
                        .HasForeignKey("Brand")
                        .HasPrincipalKey("Name");

                    b.HasOne("TireServiceAPI.Models.Product.Diameter", "Diameters")
                        .WithMany("Tires")
                        .HasForeignKey("Diameter")
                        .HasPrincipalKey("Name");

                    b.HasOne("TireServiceAPI.Models.Product.Types.Tire.TireProfile", "TireProfiles")
                        .WithMany("Tires")
                        .HasForeignKey("TireProfile")
                        .HasPrincipalKey("Name");

                    b.HasOne("TireServiceAPI.Models.Product.Types.Tire.TireSeason", "TireSeasons")
                        .WithMany("Tires")
                        .HasForeignKey("TireSeason")
                        .HasPrincipalKey("Name");

                    b.HasOne("TireServiceAPI.Models.Product.Width", "Widths")
                        .WithMany("Tires")
                        .HasForeignKey("Width")
                        .HasPrincipalKey("Name");

                    b.Navigation("Brands");

                    b.Navigation("Diameters");

                    b.Navigation("TireProfiles");

                    b.Navigation("TireSeasons");

                    b.Navigation("Widths");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Wheel.Wheel", b =>
                {
                    b.HasOne("TireServiceAPI.Models.Product.Brand", "Brands")
                        .WithMany("Wheels")
                        .HasForeignKey("Brand")
                        .HasPrincipalKey("Name");

                    b.HasOne("TireServiceAPI.Models.Product.Diameter", "Diameters")
                        .WithMany("Wheels")
                        .HasForeignKey("Diameter")
                        .HasPrincipalKey("Name");

                    b.HasOne("TireServiceAPI.Models.Product.Types.Wheel.WheelType", "WheelTypes")
                        .WithMany("Wheels")
                        .HasForeignKey("WheelType")
                        .HasPrincipalKey("Name");

                    b.HasOne("TireServiceAPI.Models.Product.Width", "Widths")
                        .WithMany("Wheels")
                        .HasForeignKey("Width")
                        .HasPrincipalKey("Name");

                    b.Navigation("Brands");

                    b.Navigation("Diameters");

                    b.Navigation("WheelTypes");

                    b.Navigation("Widths");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Brand", b =>
                {
                    b.Navigation("Tires");

                    b.Navigation("Wheels");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Diameter", b =>
                {
                    b.Navigation("Tires");

                    b.Navigation("Wheels");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireProfile", b =>
                {
                    b.Navigation("Tires");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireSeason", b =>
                {
                    b.Navigation("Tires");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Wheel.WheelType", b =>
                {
                    b.Navigation("Wheels");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Width", b =>
                {
                    b.Navigation("Tires");

                    b.Navigation("Wheels");
                });
#pragma warning restore 612, 618
        }
    }
}
