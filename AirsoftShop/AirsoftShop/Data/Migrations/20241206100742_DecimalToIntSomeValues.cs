using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class DecimalToIntSomeValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Replicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Lenght",
                table: "Replicas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "BarrelLenght",
                table: "Replicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Parts",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemLenght",
                table: "Parts",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BearingDiameter",
                table: "Parts",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Accessories",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "Replicas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Lenght",
                table: "Replicas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "BarrelLenght",
                table: "Replicas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "Parts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ItemLenght",
                table: "Parts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BearingDiameter",
                table: "Parts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Weight",
                table: "Accessories",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                values: new object[] { "657f08e6-01eb-467d-85a5-0dbfd07f6d20", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "07783109-bff9-40f1-956c-02fdf37fae08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7212201-0fa7-41cf-9d0f-1e8456bd5212", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "ef361cd2-dee8-4b2d-8b20-36a2489d0819" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fb00e75-3638-46c5-a0de-04d51433f5b1", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "4b500cf2-5795-40b6-bca8-a430b9c91d53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8f4b8e5-c686-4fb9-99ee-db12b79c3636", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "8603a364-a0dd-4cf8-bc4d-2702691e1564" });
        }
    }
}
