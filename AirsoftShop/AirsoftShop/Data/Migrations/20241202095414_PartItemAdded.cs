using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class PartItemAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartType = table.Column<int>(type: "int", nullable: false),
                    InternalPartType = table.Column<int>(type: "int", nullable: false),
                    ExternalPartType = table.Column<int>(type: "int", nullable: false),
                    ItemMaterial = table.Column<int>(type: "int", nullable: false),
                    MagazineType = table.Column<int>(type: "int", nullable: false),
                    MagazineCapacity = table.Column<int>(type: "int", nullable: false),
                    GearboxType = table.Column<int>(type: "int", nullable: false),
                    ItemLenght = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_Parts", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c87a9dd5-a62b-4ed0-9269-7ce9a21466fc", "AQAAAAIAAYagAAAAENnfInLZdvRAqphJiOdyMrH6u+B75gVhd8s1vTg3iRB0dUs7Gm0/Wgsaf1kF/gLMnA==", "fb3b764e-90db-4a0a-820c-b3bf54734bf1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6914aa72-a074-440b-ba5e-2d8fcb4ef0da", "AQAAAAIAAYagAAAAENnfInLZdvRAqphJiOdyMrH6u+B75gVhd8s1vTg3iRB0dUs7Gm0/Wgsaf1kF/gLMnA==", "093c6428-4b85-437e-b662-f58db7691152" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24ef062d-49f2-4c62-8259-2c9d19866017", "AQAAAAIAAYagAAAAENnfInLZdvRAqphJiOdyMrH6u+B75gVhd8s1vTg3iRB0dUs7Gm0/Wgsaf1kF/gLMnA==", "5d3a6796-c9df-47c5-a8e3-123efc748bab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f246aecc-59da-4367-8d5f-d6f3339eabea", "AQAAAAIAAYagAAAAENnfInLZdvRAqphJiOdyMrH6u+B75gVhd8s1vTg3iRB0dUs7Gm0/Wgsaf1kF/gLMnA==", "1dae2c44-323f-480d-a6a8-7db7dfd5f7f6" });
        }
    }
}
