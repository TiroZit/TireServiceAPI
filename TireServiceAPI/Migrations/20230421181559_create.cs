using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                    table.UniqueConstraint("AK_Brands_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diameters", x => x.Id);
                    table.UniqueConstraint("AK_Diameters_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "TireCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TireCategories", x => x.Id);
                    table.UniqueConstraint("AK_TireCategories_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "TireProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TireProfiles", x => x.Id);
                    table.UniqueConstraint("AK_TireProfiles_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "TireSeasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TireSeasons", x => x.Id);
                    table.UniqueConstraint("AK_TireSeasons_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "WheelCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelCategories", x => x.Id);
                    table.UniqueConstraint("AK_WheelCategories_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "WheelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelTypes", x => x.Id);
                    table.UniqueConstraint("AK_WheelTypes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Widths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widths", x => x.Id);
                    table.UniqueConstraint("AK_Widths_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Tires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Diameter = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TireSeason = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TireProfile = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TireCategory = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tires_Brands_Brand",
                        column: x => x.Brand,
                        principalTable: "Brands",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Tires_Diameters_Diameter",
                        column: x => x.Diameter,
                        principalTable: "Diameters",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Tires_TireCategories_TireCategory",
                        column: x => x.TireCategory,
                        principalTable: "TireCategories",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Tires_TireProfiles_TireProfile",
                        column: x => x.TireProfile,
                        principalTable: "TireProfiles",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Tires_TireSeasons_TireSeason",
                        column: x => x.TireSeason,
                        principalTable: "TireSeasons",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Tires_Widths_Width",
                        column: x => x.Width,
                        principalTable: "Widths",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Wheels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Width = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Diameter = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WheelType = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WheelCategory = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wheels_Brands_Brand",
                        column: x => x.Brand,
                        principalTable: "Brands",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Wheels_Diameters_Diameter",
                        column: x => x.Diameter,
                        principalTable: "Diameters",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Wheels_WheelCategories_WheelCategory",
                        column: x => x.WheelCategory,
                        principalTable: "WheelCategories",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Wheels_WheelTypes_WheelType",
                        column: x => x.WheelType,
                        principalTable: "WheelTypes",
                        principalColumn: "Name");
                    table.ForeignKey(
                        name: "FK_Wheels_Widths_Width",
                        column: x => x.Width,
                        principalTable: "Widths",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TireId = table.Column<int>(type: "int", nullable: false),
                    wheelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Tires_TireId",
                        column: x => x.TireId,
                        principalTable: "Tires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Wheels_wheelId",
                        column: x => x.wheelId,
                        principalTable: "Wheels",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "KAMA" },
                    { 2, "ROYALBLACK" },
                    { 3, "FORMULA" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Diameters",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "12" },
                    { 2, "13" },
                    { 3, "14" },
                    { 4, "15" },
                    { 5, "16" },
                    { 6, "17" },
                    { 7, "18" },
                    { 8, "19" },
                    { 9, "20" }
                });

            migrationBuilder.InsertData(
                table: "TireCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Легковые" },
                    { 2, "Легкогрузовые" },
                    { 3, "Грузовые" },
                    { 4, "Сельхозшины" },
                    { 5, "Спецшины" }
                });

            migrationBuilder.InsertData(
                table: "TireProfiles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "50" },
                    { 2, "55" },
                    { 3, "60" },
                    { 4, "65" },
                    { 5, "70" },
                    { 6, "75" },
                    { 7, "80" },
                    { 8, "85" }
                });

            migrationBuilder.InsertData(
                table: "TireSeasons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Зимние  нешипованные" },
                    { 2, "Зимние  шипованные" },
                    { 3, "Летние" }
                });

            migrationBuilder.InsertData(
                table: "WheelCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Легковые" },
                    { 2, "Грузовые" }
                });

            migrationBuilder.InsertData(
                table: "WheelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Легкосплавный" },
                    { 2, "Стальной" }
                });

            migrationBuilder.InsertData(
                table: "Widths",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "135" },
                    { 2, "155" },
                    { 3, "175" },
                    { 4, "185" },
                    { 5, "195" },
                    { 6, "205" }
                });

            migrationBuilder.InsertData(
                table: "Tires",
                columns: new[] { "Id", "Brand", "Diameter", "Image", "Name", "Price", "TireCategory", "TireProfile", "TireSeason", "Width" },
                values: new object[,]
                {
                    { 1, "KAMA", "14", "https://roscarservis.ru/upload/iblock/526/qxay6p1xp2rt8p8xv1p6sjldm9o8hfl6.png", "Breeze (НК-132) TL", 2640, "Легковые", "65", "Летние", "175" },
                    { 2, "KAMA", "13", "https://roscarservis.ru/upload/iblock/526/qxay6p1xp2rt8p8xv1p6sjldm9o8hfl6.png", "Breeze (НК-132) TL", 2660, "Легковые", "70", "Летние", "175" },
                    { 3, "KAMA", "14", "https://roscarservis.ru/upload/iblock/657/0h3lz2vwxee6cmw92tg8hhewa3qq461t.png", "Кама-365 (НК-241) TL", 2700, "Легковые", "65", "Летние", "175" },
                    { 4, "ROYALBLACK", "15", "https://roscarservis.ru/upload/iblock/f80/mtsp0dkxvkpa8niycd4sg8wlu1i2wit0.png", "Royalmile TL", 2710, "Легковые", "70", "Летние", "175" },
                    { 5, "KAMA", "17", "https://roscarservis.ru/upload/resize_cache/iblock/ffc/275_275_1/pp53agkes1pl4dgg455tj5dlukvi56ww.png", "Кама-365 (НК-241) TL", 3011, "Легковые", "55", "Летние", "195" },
                    { 6, "KAMA", "13", "https://roscarservis.ru/upload/resize_cache/iblock/d7a/275_275_1/inozb3hnb7klkzkrb751ixkkd0skg6tz.png", "Grant (НК-241) TL", 2988, "Легковые", "60", "Зимние  нешипованные", "205" },
                    { 7, "FORMULA", "15", "https://roscarservis.ru/upload/resize_cache/iblock/951/275_275_1/9wfbjqhd9qdlrqz1pgvybvh3be59f6c9.png", "ОШЗ ИЯ-112А", 10600, "Грузовые", "50", "Зимние  шипованные", "135" },
                    { 8, "FORMULA", "15", "https://roscarservis.ru/upload/resize_cache/iblock/acd/275_275_1/nryvngrhcyft73ewlpj7cu58g40s669k.png", "ОШЗ У-2", 12033, "Грузовые", "65", "Летние", "155" },
                    { 9, "ROYALBLACK", "17", "https://roscarservis.ru/upload/resize_cache/iblock/8cc/275_275_1/3ist0g1kbxx4sjr0jzq4fzbo6eazqu8k.png", "BKT FL-252", 4481, "Спецшины", "70", "Летние", "195" },
                    { 10, "FORMULA", "14", "https://roscarservis.ru/upload/resize_cache/iblock/bb5/275_275_1/anxr0r0n9yrp54ozqv9qzzgznzx3wcp3.png", "solid /std/ Starco Tusker TL", 5442, "Спецшины", "55", "Зимние  нешипованные", "195" }
                });

            migrationBuilder.InsertData(
                table: "Wheels",
                columns: new[] { "Id", "Brand", "Diameter", "Image", "Name", "Price", "WheelCategory", "WheelType", "Width" },
                values: new object[,]
                {
                    { 1, "FORMULA", "13", "https://roscarservis.ru/upload/iblock/727/562hiidchq84f7yhexwrz5ihi91dyg77.png", "T.Corolla (53A38R) box Silver (TREBL)", 2640, "Легковые", "Легкосплавный", "175" },
                    { 2, "KAMA", "17", "https://roscarservis.ru/upload/iblock/6e0/s0iljau91fl1hdek94e8wvwjzyky93qy.png", "ВАЗ-2112 Silver (ТЗСК, Тольятти)", 2660, "Легковые", "Легкосплавный", "195" },
                    { 3, "ROYALBLACK", "13", "https://roscarservis.ru/upload/iblock/f26/p4il5b3jxdcc3xulzhnwwq8ivppj4r4w.png", "Skoda, VW (63H37D-PCR14605100R) S (Eurodisk)", 4040, "Грузовые", "Стальной", "205" },
                    { 4, "ROYALBLACK", "15", "https://roscarservis.ru/upload/iblock/213/0j2f52wlx1xzrmlyz2j71i3uqdvtw71g.png", "Royalmile TL", 2710, "Грузовые", "Стальной", "175" },
                    { 5, "KAMA", "14", "https://roscarservis.ru/upload/resize_cache/iblock/f4c/600_585_1/z9y1jdsf9n22ejxu245l1uqq61o4l3w7.png", "(AR006) box Silver (TREBL)", 46040, "Легковые", "Легкосплавный", "175" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_TireId",
                table: "CartItems",
                column: "TireId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_wheelId",
                table: "CartItems",
                column: "wheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_Brand",
                table: "Tires",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_Diameter",
                table: "Tires",
                column: "Diameter");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_TireCategory",
                table: "Tires",
                column: "TireCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_TireProfile",
                table: "Tires",
                column: "TireProfile");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_TireSeason",
                table: "Tires",
                column: "TireSeason");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_Width",
                table: "Tires",
                column: "Width");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_Brand",
                table: "Wheels",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_Diameter",
                table: "Wheels",
                column: "Diameter");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_WheelCategory",
                table: "Wheels",
                column: "WheelCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_WheelType",
                table: "Wheels",
                column: "WheelType");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_Width",
                table: "Wheels",
                column: "Width");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Tires");

            migrationBuilder.DropTable(
                name: "Wheels");

            migrationBuilder.DropTable(
                name: "TireCategories");

            migrationBuilder.DropTable(
                name: "TireProfiles");

            migrationBuilder.DropTable(
                name: "TireSeasons");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Diameters");

            migrationBuilder.DropTable(
                name: "WheelCategories");

            migrationBuilder.DropTable(
                name: "WheelTypes");

            migrationBuilder.DropTable(
                name: "Widths");
        }
    }
}
