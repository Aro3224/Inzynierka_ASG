using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class AccessoryItemAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BbWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BbType = table.Column<int>(type: "int", nullable: false),
                    BbAmmount = table.Column<int>(type: "int", nullable: false),
                    GasType = table.Column<int>(type: "int", nullable: false),
                    BatteryType = table.Column<int>(type: "int", nullable: false),
                    BatteryPlug = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    WarrantyPeriodMonths = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6210cc1d-5837-451c-870d-c723bbd5c6f1", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "897856b7-b13e-419e-aa6c-097942c94a63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a37c389-95b6-4c09-906a-3e5487bd4f09", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "2c7d0492-66b8-4c29-bdb6-e03d9d66d692" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d558db0d-84d2-4f03-bbeb-3ee703fda192", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "7ad811ed-35c3-4906-94c1-cb2dd577872d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdca64a-c678-4045-9475-77298d5e499e", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "d93d83aa-cde2-40dd-a51a-654bdb33b69a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accessories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47642816-e20f-4054-ae9c-d969e4855f12", "AQAAAAIAAYagAAAAEGPH8CyS+KDZ9Pf0U6t6lPqFNQO2H8ZD6RyzGuUPA7lgfTqJexo7nMbWoOKKYof6qQ==", "9b98f779-13b8-417b-9c43-3486dd58c299" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ec76048-0f37-4e42-8783-695d81feb567", "AQAAAAIAAYagAAAAEGPH8CyS+KDZ9Pf0U6t6lPqFNQO2H8ZD6RyzGuUPA7lgfTqJexo7nMbWoOKKYof6qQ==", "3e31aa74-b4d4-44b9-8682-f43f196674db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a685ffa0-737d-49d7-9a06-0a8d61e52759", "AQAAAAIAAYagAAAAEGPH8CyS+KDZ9Pf0U6t6lPqFNQO2H8ZD6RyzGuUPA7lgfTqJexo7nMbWoOKKYof6qQ==", "392053e1-85db-43df-b1a3-70400ed0216d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f0ec086-b68c-4ac6-a76b-d8516c3f7ecf", "AQAAAAIAAYagAAAAEGPH8CyS+KDZ9Pf0U6t6lPqFNQO2H8ZD6RyzGuUPA7lgfTqJexo7nMbWoOKKYof6qQ==", "3ea8ed71-8372-46e7-8084-6ac1729abd39" });
        }
    }
}
