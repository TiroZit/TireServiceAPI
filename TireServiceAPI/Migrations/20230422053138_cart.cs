using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Tires_TireId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Wheels_wheelId",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "wheelId",
                table: "CartItems",
                newName: "WheelId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_wheelId",
                table: "CartItems",
                newName: "IX_CartItems_WheelId");

            migrationBuilder.AlterColumn<int>(
                name: "TireId",
                table: "CartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Tires_TireId",
                table: "CartItems",
                column: "TireId",
                principalTable: "Tires",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Wheels_WheelId",
                table: "CartItems",
                column: "WheelId",
                principalTable: "Wheels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Tires_TireId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Wheels_WheelId",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "WheelId",
                table: "CartItems",
                newName: "wheelId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_WheelId",
                table: "CartItems",
                newName: "IX_CartItems_wheelId");

            migrationBuilder.AlterColumn<int>(
                name: "TireId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Tires_TireId",
                table: "CartItems",
                column: "TireId",
                principalTable: "Tires",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Wheels_wheelId",
                table: "CartItems",
                column: "wheelId",
                principalTable: "Wheels",
                principalColumn: "Id");
        }
    }
}
