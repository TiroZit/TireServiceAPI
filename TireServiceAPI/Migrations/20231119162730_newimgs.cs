using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TireServiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class newimgs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "tires/1.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "tires/2.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "tires/3.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "tires/4.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "tires/5.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "tires/6.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "tires/specials/1.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "tires/specials/2.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "tires/specials/3.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "tires/specials/4.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "1");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "wheels/1.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "wheels/2.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "wheels/3.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "wheels/4.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Favourites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/526/qxay6p1xp2rt8p8xv1p6sjldm9o8hfl6.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/526/qxay6p1xp2rt8p8xv1p6sjldm9o8hfl6.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/657/0h3lz2vwxee6cmw92tg8hhewa3qq461t.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/f80/mtsp0dkxvkpa8niycd4sg8wlu1i2wit0.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://roscarservis.ru/upload/resize_cache/iblock/ffc/275_275_1/pp53agkes1pl4dgg455tj5dlukvi56ww.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://roscarservis.ru/upload/resize_cache/iblock/d7a/275_275_1/inozb3hnb7klkzkrb751ixkkd0skg6tz.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://roscarservis.ru/upload/resize_cache/iblock/951/275_275_1/9wfbjqhd9qdlrqz1pgvybvh3be59f6c9.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://roscarservis.ru/upload/resize_cache/iblock/acd/275_275_1/nryvngrhcyft73ewlpj7cu58g40s669k.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://roscarservis.ru/upload/resize_cache/iblock/8cc/275_275_1/3ist0g1kbxx4sjr0jzq4fzbo6eazqu8k.png");

            migrationBuilder.UpdateData(
                table: "Tires",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://roscarservis.ru/upload/resize_cache/iblock/bb5/275_275_1/anxr0r0n9yrp54ozqv9qzzgznzx3wcp3.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/727/562hiidchq84f7yhexwrz5ihi91dyg77.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/6e0/s0iljau91fl1hdek94e8wvwjzyky93qy.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/f26/p4il5b3jxdcc3xulzhnwwq8ivppj4r4w.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://roscarservis.ru/upload/iblock/213/0j2f52wlx1xzrmlyz2j71i3uqdvtw71g.png");

            migrationBuilder.UpdateData(
                table: "Wheels",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://roscarservis.ru/upload/resize_cache/iblock/f4c/600_585_1/z9y1jdsf9n22ejxu245l1uqq61o4l3w7.png");
        }
    }
}
