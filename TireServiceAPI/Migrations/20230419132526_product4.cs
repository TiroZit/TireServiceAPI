using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class product4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WheelCategory",
                table: "Wheels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TireCategory",
                table: "Tires",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_WheelCategory",
                table: "Wheels",
                column: "WheelCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Tires_TireCategory",
                table: "Tires",
                column: "TireCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Tires_TireCategories_TireCategory",
                table: "Tires",
                column: "TireCategory",
                principalTable: "TireCategories",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_WheelCategories_WheelCategory",
                table: "Wheels",
                column: "WheelCategory",
                principalTable: "WheelCategories",
                principalColumn: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tires_TireCategories_TireCategory",
                table: "Tires");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_WheelCategories_WheelCategory",
                table: "Wheels");

            migrationBuilder.DropTable(
                name: "TireCategories");

            migrationBuilder.DropTable(
                name: "WheelCategories");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_WheelCategory",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Tires_TireCategory",
                table: "Tires");

            migrationBuilder.DropColumn(
                name: "WheelCategory",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "TireCategory",
                table: "Tires");
        }
    }
}
