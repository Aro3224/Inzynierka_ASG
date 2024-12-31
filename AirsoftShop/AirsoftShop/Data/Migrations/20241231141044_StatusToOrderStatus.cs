using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class StatusToOrderStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "OrderStatus");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e672133-df82-43a1-ae27-6fee267b9a97", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "e6798d64-58ad-4845-96dd-92d3d32e3ba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1172b4-7992-4727-8854-88409d296eff", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "427c273b-07d8-4e4f-a488-3d8468786b45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d02da468-2035-49ba-a716-9bb5f848a32b", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "a10945bc-ef67-4c3c-acce-32c3f4d85157" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a511f84f-a7f0-4cf5-9003-d1fcb94ed76f", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "c39c1e15-b68b-410e-b27a-9e4be538c8a5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderStatus",
                table: "Orders",
                newName: "Status");

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
    }
}
