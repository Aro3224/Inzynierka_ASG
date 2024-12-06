using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class IntToDecimalForBBWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "BbWeight",
                table: "Accessories",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a9cfc2-4b32-494a-919e-b55d2dfc9353", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "fcb5d6e0-99ae-4070-a55c-25da02c2efad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18b60b0-2c76-47ae-8156-42ad11cbe516", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "aa98da9b-a049-4679-acfd-3c017adb8e6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e21491b1-c03b-46c6-bafe-2d879b8e149a", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "bf585a6d-b503-4951-9a78-a5bdc838e497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33cb122c-ba4a-46e4-bb42-7a41324233d7", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "3afd05c5-daeb-4c0a-9335-3390de8df21e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BbWeight",
                table: "Accessories",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a08fbb6-a04a-4b2d-ae95-086d16d72dfe", "AQAAAAIAAYagAAAAEIrNCFh6jDgbyx9gnuPTxX+J4jveQhNQjO4miyJEG3npnxCXRzTnxiKXW1J23q28Yg==", "97350a3c-2ee4-42c6-ac4f-988c321514f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29cb9768-962e-4d7a-a6af-57e8a128ffa0", "AQAAAAIAAYagAAAAEIrNCFh6jDgbyx9gnuPTxX+J4jveQhNQjO4miyJEG3npnxCXRzTnxiKXW1J23q28Yg==", "53e67b02-6179-4f5b-bf25-0b2ad39ec963" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90c5cb70-0a5b-4ff6-9015-7772191efa7d", "AQAAAAIAAYagAAAAEIrNCFh6jDgbyx9gnuPTxX+J4jveQhNQjO4miyJEG3npnxCXRzTnxiKXW1J23q28Yg==", "fdfbb03e-2816-45ee-aec3-370b4e68b84d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe06b98f-1e37-46f3-9347-87f7dd0fa529", "AQAAAAIAAYagAAAAEIrNCFh6jDgbyx9gnuPTxX+J4jveQhNQjO4miyJEG3npnxCXRzTnxiKXW1J23q28Yg==", "df4c1a9c-8d9a-4bd6-95ba-484ff7cb39c2" });
        }
    }
}
