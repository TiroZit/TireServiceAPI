using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class product2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_Brands_BrandId",
                table: "Wheels");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_Diameters_DiameterId",
                table: "Wheels");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_WheelTypes_WheelTypeId",
                table: "Wheels");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_Widths_WidthId",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_BrandId",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_DiameterId",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_WheelTypeId",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_WidthId",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "DiameterId",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "WheelTypeId",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "WidthId",
                table: "Wheels");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WheelTypes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Wheels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Diameter",
                table: "Wheels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WheelType",
                table: "Wheels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Width",
                table: "Wheels",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_WheelTypes_Name",
                table: "WheelTypes",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_Brand",
                table: "Wheels",
                column: "Brand");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_Diameter",
                table: "Wheels",
                column: "Diameter");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_WheelType",
                table: "Wheels",
                column: "WheelType");

            migrationBuilder.CreateIndex(
                name: "IX_Wheels_Width",
                table: "Wheels",
                column: "Width");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_Brands_Brand",
                table: "Wheels",
                column: "Brand",
                principalTable: "Brands",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_Diameters_Diameter",
                table: "Wheels",
                column: "Diameter",
                principalTable: "Diameters",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_WheelTypes_WheelType",
                table: "Wheels",
                column: "WheelType",
                principalTable: "WheelTypes",
                principalColumn: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_Widths_Width",
                table: "Wheels",
                column: "Width",
                principalTable: "Widths",
                principalColumn: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_Brands_Brand",
                table: "Wheels");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_Diameters_Diameter",
                table: "Wheels");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_WheelTypes_WheelType",
                table: "Wheels");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_Widths_Width",
                table: "Wheels");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_WheelTypes_Name",
                table: "WheelTypes");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_Brand",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_Diameter",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_WheelType",
                table: "Wheels");

            migrationBuilder.DropIndex(
                name: "IX_Wheels_Width",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "WheelType",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Wheels");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "WheelTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Wheels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DiameterId",
                table: "Wheels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WheelTypeId",
                table: "Wheels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WidthId",
                table: "Wheels",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_Brands_BrandId",
                table: "Wheels",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_Diameters_DiameterId",
                table: "Wheels",
                column: "DiameterId",
                principalTable: "Diameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_WheelTypes_WheelTypeId",
                table: "Wheels",
                column: "WheelTypeId",
                principalTable: "WheelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_Widths_WidthId",
                table: "Wheels",
                column: "WidthId",
                principalTable: "Widths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
