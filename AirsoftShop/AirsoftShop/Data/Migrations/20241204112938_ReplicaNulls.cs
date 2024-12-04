using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class ReplicaNulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WeaponGearboxType",
                table: "Replicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Manufacturer",
                table: "Replicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MagazineCapacity",
                table: "Replicas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Replicas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Manufacturer",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemMaterial",
                table: "Parts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Manufacturer",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AccessoryType",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba00bfd-8f67-411c-a3b9-e288cb64de27", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "06560c37-eb4c-4153-8656-3d29a7ffb46a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c10cd103-b9a7-47ea-b676-089aa15037ba", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "25c6ea25-94de-4c55-a534-01caeb3a0bdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0220be62-79e3-49b7-8571-786fe780c289", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "f5a43d75-7bce-4a70-8c3f-817ff7dc3641" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76eddc8d-d40b-43fb-b58a-29432a748167", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "9ae7ae2e-0ad3-49f7-8385-90fc7ce49ef4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WeaponGearboxType",
                table: "Replicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Manufacturer",
                table: "Replicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MagazineCapacity",
                table: "Replicas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Replicas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Manufacturer",
                table: "Parts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ItemMaterial",
                table: "Parts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Parts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Manufacturer",
                table: "Accessories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AccessoryType",
                table: "Accessories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dbc1090-bbb9-4190-9160-581863b16ef8", "AQAAAAIAAYagAAAAEOcq1Ef4SPAmvRwoBzlp6zQx8Hny6u0gAVnmR1zqPTG7Md+2kaH5QIthPTUJOBT7gA==", "7ef08aa5-955d-48bb-ab0e-40462ae88a45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6aabbcc-21ae-4e65-9e22-4a98abc81aba", "AQAAAAIAAYagAAAAEOcq1Ef4SPAmvRwoBzlp6zQx8Hny6u0gAVnmR1zqPTG7Md+2kaH5QIthPTUJOBT7gA==", "9b230724-63d4-4525-8e91-75845e383265" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d678a418-e826-4344-8095-122478e4e928", "AQAAAAIAAYagAAAAEOcq1Ef4SPAmvRwoBzlp6zQx8Hny6u0gAVnmR1zqPTG7Md+2kaH5QIthPTUJOBT7gA==", "31855a50-157b-4d16-a238-24dac9a50d68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b22656ce-39da-4428-846a-250f02aff275", "AQAAAAIAAYagAAAAEOcq1Ef4SPAmvRwoBzlp6zQx8Hny6u0gAVnmR1zqPTG7Md+2kaH5QIthPTUJOBT7gA==", "4d4bff16-9c14-4a2e-903f-dd8a389a2506" });
        }
    }
}
