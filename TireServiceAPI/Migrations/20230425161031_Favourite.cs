using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class Favourite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FavouriteItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FavouriteId = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TireId = table.Column<int>(type: "int", nullable: true),
                    WheelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavouriteItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavouriteItems_Favourites_FavouriteId",
                        column: x => x.FavouriteId,
                        principalTable: "Favourites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavouriteItems_Tires_TireId",
                        column: x => x.TireId,
                        principalTable: "Tires",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FavouriteItems_Wheels_WheelId",
                        column: x => x.WheelId,
                        principalTable: "Wheels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteItems_FavouriteId",
                table: "FavouriteItems",
                column: "FavouriteId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteItems_TireId",
                table: "FavouriteItems",
                column: "TireId");

            migrationBuilder.CreateIndex(
                name: "IX_FavouriteItems_WheelId",
                table: "FavouriteItems",
                column: "WheelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavouriteItems");

            migrationBuilder.DropTable(
                name: "Favourites");
        }
    }
}
