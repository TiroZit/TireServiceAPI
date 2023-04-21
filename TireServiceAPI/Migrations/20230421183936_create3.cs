using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class create3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CartItems_TireId",
                table: "CartItems");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_TireId",
                table: "CartItems",
                column: "TireId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CartItems_TireId",
                table: "CartItems");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_TireId",
                table: "CartItems",
                column: "TireId",
                unique: true);
        }
    }
}
