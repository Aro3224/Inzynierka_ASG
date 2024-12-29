using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class CourierCompanyToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourierCompany",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "779bdef4-88a0-48e6-ab42-841c31c1f949", "AQAAAAIAAYagAAAAEHE3nK2+XbKVMX7BfGB+TsAUakT18uRyHr63nEcilfmzWFOfMkXg6o+M7GSj/5iU+w==", "0040902b-79e2-42ba-b4b1-de43e59298fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9935981-0a25-4315-9f97-20d534a1417c", "AQAAAAIAAYagAAAAEHE3nK2+XbKVMX7BfGB+TsAUakT18uRyHr63nEcilfmzWFOfMkXg6o+M7GSj/5iU+w==", "80383368-9c32-45c6-bf70-cc095f6bd7d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d966012-6035-4e8a-a763-3455d894cee8", "AQAAAAIAAYagAAAAEHE3nK2+XbKVMX7BfGB+TsAUakT18uRyHr63nEcilfmzWFOfMkXg6o+M7GSj/5iU+w==", "73786e25-5e55-43a7-9812-cc75b24a3c83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ab3e30b-c51a-417c-8b51-46a21b7fa619", "AQAAAAIAAYagAAAAEHE3nK2+XbKVMX7BfGB+TsAUakT18uRyHr63nEcilfmzWFOfMkXg6o+M7GSj/5iU+w==", "7aeb94cf-2fa6-43db-929d-09803bdffc6b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourierCompany",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da58ef71-5819-4411-bfdb-3fbbc9b3fe2a", "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "f9b980ab-96b0-45cb-b645-fba53672915e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "127cf9cd-9ac5-4081-aafb-3192ed3287be", "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "f0f105f1-6d2b-4b77-a22b-4469559dc18c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bb1d6e4-68dc-402c-8409-d692b67efd0b", "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "b236253e-64fb-45c1-b826-bbf1d6560e54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0418100e-b4f2-4559-8795-48e9febfbb6c", "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "a9a2bd08-c075-41ce-95d7-c19a1b6fe82c" });
        }
    }
}
