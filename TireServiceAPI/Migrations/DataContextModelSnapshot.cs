﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace TireServiceAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TireServiceAPI.Models.Cart.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("TireServiceAPI.Models.Cart.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TireId")
                        .HasColumnType("int");

                    b.Property<int?>("wheelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("TireId");

                    b.HasIndex("wheelId");

                    b.ToTable("CartItems");
                });

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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "KAMA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "ROYALBLACK"
                        },
                        new
                        {
                            Id = 3,
                            Name = "FORMULA"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "12"
                        },
                        new
                        {
                            Id = 2,
                            Name = "13"
                        },
                        new
                        {
                            Id = 3,
                            Name = "14"
                        },
                        new
                        {
                            Id = 4,
                            Name = "15"
                        },
                        new
                        {
                            Id = 5,
                            Name = "16"
                        },
                        new
                        {
                            Id = 6,
                            Name = "17"
                        },
                        new
                        {
                            Id = 7,
                            Name = "18"
                        },
                        new
                        {
                            Id = 8,
                            Name = "19"
                        },
                        new
                        {
                            Id = 9,
                            Name = "20"
                        });
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

                    b.Property<string>("TireCategory")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TireProfile")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TireSeason")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Brand");

                    b.HasIndex("Diameter");

                    b.HasIndex("TireCategory");

                    b.HasIndex("TireProfile");

                    b.HasIndex("TireSeason");

                    b.HasIndex("Width");

                    b.ToTable("Tires");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "KAMA",
                            Diameter = "14",
                            Image = "https://roscarservis.ru/upload/iblock/526/qxay6p1xp2rt8p8xv1p6sjldm9o8hfl6.png",
                            Name = "Breeze (НК-132) TL",
                            Price = 2640,
                            TireCategory = "Легковые",
                            TireProfile = "65",
                            TireSeason = "Летние",
                            Width = "175"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "KAMA",
                            Diameter = "13",
                            Image = "https://roscarservis.ru/upload/iblock/526/qxay6p1xp2rt8p8xv1p6sjldm9o8hfl6.png",
                            Name = "Breeze (НК-132) TL",
                            Price = 2660,
                            TireCategory = "Легковые",
                            TireProfile = "70",
                            TireSeason = "Летние",
                            Width = "175"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "KAMA",
                            Diameter = "14",
                            Image = "https://roscarservis.ru/upload/iblock/657/0h3lz2vwxee6cmw92tg8hhewa3qq461t.png",
                            Name = "Кама-365 (НК-241) TL",
                            Price = 2700,
                            TireCategory = "Легковые",
                            TireProfile = "65",
                            TireSeason = "Летние",
                            Width = "175"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "ROYALBLACK",
                            Diameter = "15",
                            Image = "https://roscarservis.ru/upload/iblock/f80/mtsp0dkxvkpa8niycd4sg8wlu1i2wit0.png",
                            Name = "Royalmile TL",
                            Price = 2710,
                            TireCategory = "Легковые",
                            TireProfile = "70",
                            TireSeason = "Летние",
                            Width = "175"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "KAMA",
                            Diameter = "17",
                            Image = "https://roscarservis.ru/upload/resize_cache/iblock/ffc/275_275_1/pp53agkes1pl4dgg455tj5dlukvi56ww.png",
                            Name = "Кама-365 (НК-241) TL",
                            Price = 3011,
                            TireCategory = "Легковые",
                            TireProfile = "55",
                            TireSeason = "Летние",
                            Width = "195"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "KAMA",
                            Diameter = "13",
                            Image = "https://roscarservis.ru/upload/resize_cache/iblock/d7a/275_275_1/inozb3hnb7klkzkrb751ixkkd0skg6tz.png",
                            Name = "Grant (НК-241) TL",
                            Price = 2988,
                            TireCategory = "Легковые",
                            TireProfile = "60",
                            TireSeason = "Зимние  нешипованные",
                            Width = "205"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "FORMULA",
                            Diameter = "15",
                            Image = "https://roscarservis.ru/upload/resize_cache/iblock/951/275_275_1/9wfbjqhd9qdlrqz1pgvybvh3be59f6c9.png",
                            Name = "ОШЗ ИЯ-112А",
                            Price = 10600,
                            TireCategory = "Грузовые",
                            TireProfile = "50",
                            TireSeason = "Зимние  шипованные",
                            Width = "135"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "FORMULA",
                            Diameter = "15",
                            Image = "https://roscarservis.ru/upload/resize_cache/iblock/acd/275_275_1/nryvngrhcyft73ewlpj7cu58g40s669k.png",
                            Name = "ОШЗ У-2",
                            Price = 12033,
                            TireCategory = "Грузовые",
                            TireProfile = "65",
                            TireSeason = "Летние",
                            Width = "155"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "ROYALBLACK",
                            Diameter = "17",
                            Image = "https://roscarservis.ru/upload/resize_cache/iblock/8cc/275_275_1/3ist0g1kbxx4sjr0jzq4fzbo6eazqu8k.png",
                            Name = "BKT FL-252",
                            Price = 4481,
                            TireCategory = "Спецшины",
                            TireProfile = "70",
                            TireSeason = "Летние",
                            Width = "195"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "FORMULA",
                            Diameter = "14",
                            Image = "https://roscarservis.ru/upload/resize_cache/iblock/bb5/275_275_1/anxr0r0n9yrp54ozqv9qzzgznzx3wcp3.png",
                            Name = "solid /std/ Starco Tusker TL",
                            Price = 5442,
                            TireCategory = "Спецшины",
                            TireProfile = "55",
                            TireSeason = "Зимние  нешипованные",
                            Width = "195"
                        });
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("TireCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Легковые"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Легкогрузовые"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Грузовые"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Сельхозшины"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Спецшины"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "50"
                        },
                        new
                        {
                            Id = 2,
                            Name = "55"
                        },
                        new
                        {
                            Id = 3,
                            Name = "60"
                        },
                        new
                        {
                            Id = 4,
                            Name = "65"
                        },
                        new
                        {
                            Id = 5,
                            Name = "70"
                        },
                        new
                        {
                            Id = 6,
                            Name = "75"
                        },
                        new
                        {
                            Id = 7,
                            Name = "80"
                        },
                        new
                        {
                            Id = 8,
                            Name = "85"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Зимние  нешипованные"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Зимние  шипованные"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Летние"
                        });
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

                    b.Property<string>("WheelCategory")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WheelType")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Width")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Brand");

                    b.HasIndex("Diameter");

                    b.HasIndex("WheelCategory");

                    b.HasIndex("WheelType");

                    b.HasIndex("Width");

                    b.ToTable("Wheels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "FORMULA",
                            Diameter = "13",
                            Image = "https://roscarservis.ru/upload/iblock/727/562hiidchq84f7yhexwrz5ihi91dyg77.png",
                            Name = "T.Corolla (53A38R) box Silver (TREBL)",
                            Price = 2640,
                            WheelCategory = "Легковые",
                            WheelType = "Легкосплавный",
                            Width = "175"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "KAMA",
                            Diameter = "17",
                            Image = "https://roscarservis.ru/upload/iblock/6e0/s0iljau91fl1hdek94e8wvwjzyky93qy.png",
                            Name = "ВАЗ-2112 Silver (ТЗСК, Тольятти)",
                            Price = 2660,
                            WheelCategory = "Легковые",
                            WheelType = "Легкосплавный",
                            Width = "195"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "ROYALBLACK",
                            Diameter = "13",
                            Image = "https://roscarservis.ru/upload/iblock/f26/p4il5b3jxdcc3xulzhnwwq8ivppj4r4w.png",
                            Name = "Skoda, VW (63H37D-PCR14605100R) S (Eurodisk)",
                            Price = 4040,
                            WheelCategory = "Грузовые",
                            WheelType = "Стальной",
                            Width = "205"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "ROYALBLACK",
                            Diameter = "15",
                            Image = "https://roscarservis.ru/upload/iblock/213/0j2f52wlx1xzrmlyz2j71i3uqdvtw71g.png",
                            Name = "Royalmile TL",
                            Price = 2710,
                            WheelCategory = "Грузовые",
                            WheelType = "Стальной",
                            Width = "175"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "KAMA",
                            Diameter = "14",
                            Image = "https://roscarservis.ru/upload/resize_cache/iblock/f4c/600_585_1/z9y1jdsf9n22ejxu245l1uqq61o4l3w7.png",
                            Name = "(AR006) box Silver (TREBL)",
                            Price = 46040,
                            WheelCategory = "Легковые",
                            WheelType = "Легкосплавный",
                            Width = "175"
                        });
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Wheel.WheelCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.ToTable("WheelCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Легковые"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Грузовые"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Легкосплавный"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Стальной"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "135"
                        },
                        new
                        {
                            Id = 2,
                            Name = "155"
                        },
                        new
                        {
                            Id = 3,
                            Name = "175"
                        },
                        new
                        {
                            Id = 4,
                            Name = "185"
                        },
                        new
                        {
                            Id = 5,
                            Name = "195"
                        },
                        new
                        {
                            Id = 6,
                            Name = "205"
                        });
                });

            modelBuilder.Entity("TireServiceAPI.Models.Cart.CartItem", b =>
                {
                    b.HasOne("TireServiceAPI.Models.Cart.Cart", "Carts")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TireServiceAPI.Models.Product.Types.Tire.Tire", "Tire")
                        .WithMany("cartItems")
                        .HasForeignKey("TireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TireServiceAPI.Models.Product.Types.Wheel.Wheel", "wheel")
                        .WithMany()
                        .HasForeignKey("wheelId");

                    b.Navigation("Carts");

                    b.Navigation("Tire");

                    b.Navigation("wheel");
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

                    b.HasOne("TireServiceAPI.Models.Product.Types.Tire.TireCategory", "TireCategories")
                        .WithMany("Tires")
                        .HasForeignKey("TireCategory")
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

                    b.Navigation("TireCategories");

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

                    b.HasOne("TireServiceAPI.Models.Product.Types.Wheel.WheelCategory", "WheelCategories")
                        .WithMany("Wheels")
                        .HasForeignKey("WheelCategory")
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

                    b.Navigation("WheelCategories");

                    b.Navigation("WheelTypes");

                    b.Navigation("Widths");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Cart.Cart", b =>
                {
                    b.Navigation("CartItems");
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

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.Tire", b =>
                {
                    b.Navigation("cartItems");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireCategory", b =>
                {
                    b.Navigation("Tires");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireProfile", b =>
                {
                    b.Navigation("Tires");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Tire.TireSeason", b =>
                {
                    b.Navigation("Tires");
                });

            modelBuilder.Entity("TireServiceAPI.Models.Product.Types.Wheel.WheelCategory", b =>
                {
                    b.Navigation("Wheels");
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
