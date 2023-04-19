using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class product : Migration
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
                name: "WheelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelTypes", x => x.Id);
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
                    TireProfile = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    WidthId = table.Column<int>(type: "int", nullable: false),
                    DiameterId = table.Column<int>(type: "int", nullable: false),
                    WheelTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wheels_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheels_Diameters_DiameterId",
                        column: x => x.DiameterId,
                        principalTable: "Diameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheels_WheelTypes_WheelTypeId",
                        column: x => x.WheelTypeId,
                        principalTable: "WheelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wheels_Widths_WidthId",
                        column: x => x.WidthId,
                        principalTable: "Widths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tires_Brand",
                table: "Tires",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_Diameter",
                table: "Tires",
                column: "Diameter");

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
                name: "IX_Wheels_BrandId",
                table: "Wheels",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_DiameterId",
                table: "Wheels",
                column: "DiameterId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_WheelTypeId",
                table: "Wheels",
                column: "WheelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_WidthId",
                table: "Wheels",
                column: "WidthId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tires");

            migrationBuilder.DropTable(
                name: "Wheels");

            migrationBuilder.DropTable(
                name: "TireProfiles");

            migrationBuilder.DropTable(
                name: "TireSeasons");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Diameters");

            migrationBuilder.DropTable(
                name: "WheelTypes");

            migrationBuilder.DropTable(
                name: "Widths");
        }
    }
}
