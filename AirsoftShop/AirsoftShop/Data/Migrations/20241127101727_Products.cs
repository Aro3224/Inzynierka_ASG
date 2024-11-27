using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Replicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponType = table.Column<int>(type: "int", nullable: false),
                    WeaponAge = table.Column<int>(type: "int", nullable: false),
                    WeaponFireType = table.Column<int>(type: "int", nullable: false),
                    ItemMaterial = table.Column<int>(type: "int", nullable: false),
                    MagazineType = table.Column<int>(type: "int", nullable: false),
                    WeaponGearboxType = table.Column<int>(type: "int", nullable: false),
                    MagazineCapacity = table.Column<int>(type: "int", nullable: false),
                    HasBattery = table.Column<bool>(type: "bit", nullable: false),
                    HasHopUp = table.Column<bool>(type: "bit", nullable: false),
                    HasBlowBack = table.Column<bool>(type: "bit", nullable: false),
                    Lenght = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BarrelLenght = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FPS = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    WarrantyPeriodMonths = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replicas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a52205-0baf-4f5b-be52-bddfa2ef61de", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "60d1e647-7f76-4d07-a645-2498f89ca4dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a2b5c4-fedb-4a9f-81d9-06aa4f8530f0", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "9a291b56-de81-4073-825e-f7563c7a4f47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc858f74-2c61-4b22-a386-3bed46961a1a", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "d5c9d923-978f-45c8-8943-a703dfb08599" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83fd53e1-50ae-47e0-8be4-66f0c841d040", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "4c59b3de-562b-4ac6-abd0-ad54e75bd87a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Replicas");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17f09af6-adb2-40c2-bc6c-55894edb2bc6", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "2a5f0feb-d40f-46a7-be94-48310209ef09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac7d9de-abc0-4c56-8336-fc4491b70723", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "39919466-2d83-4237-b6c0-66b131342044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d2150a0-3c4f-4dc1-a726-5072d69bb96e", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "445a0d9a-3664-401d-919f-df42b1519546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c05bdbfc-d974-4df0-9b64-e39a7b5e2afd", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "3aedc4f4-0369-45dd-88fa-5de6dbb05cd3" });
        }
    }
}
