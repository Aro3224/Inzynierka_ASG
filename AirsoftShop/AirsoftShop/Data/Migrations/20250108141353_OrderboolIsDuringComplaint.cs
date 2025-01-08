using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class OrderboolIsDuringComplaint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDuringComplaint",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a09ffd4-1265-4887-aef3-bd1f23740694", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "3ae0331a-9323-41b9-b7e1-69da80357053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77342a6a-e84f-4646-8b0e-b32881a628e1", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "e65b9d83-1d71-4fbd-b27a-c1f73be0cb38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94879761-e214-4be2-85b9-b336d3bd23e0", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "f1659856-02f5-4c67-a1d9-c297fabd3b3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eaf5d51-0573-4e22-aeb2-3bd62f3c80b0", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "ed94d05e-bfba-47e7-b496-689bc2259363" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDuringComplaint",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe98d07c-7b23-497e-a47e-051f0921a3eb", "AQAAAAIAAYagAAAAEOyQskNDU819sFV6CZvP7zbu189HllS8XF8dKj2S2BSk1E4T5Lb3Xj0wTxFNvi9+Rg==", "4d8e2441-2d5c-4c0a-8516-c236a5a1c1d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ade4ba64-a82c-43a3-ab37-4ca78e254b36", "AQAAAAIAAYagAAAAEOyQskNDU819sFV6CZvP7zbu189HllS8XF8dKj2S2BSk1E4T5Lb3Xj0wTxFNvi9+Rg==", "b5225786-19ce-457b-9e01-637611bc27a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0be53b26-0312-4292-a95b-2fa3b8cad2df", "AQAAAAIAAYagAAAAEOyQskNDU819sFV6CZvP7zbu189HllS8XF8dKj2S2BSk1E4T5Lb3Xj0wTxFNvi9+Rg==", "eabfb20f-b171-458f-b88c-060d2d0d71d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a77a41d2-bfe0-494e-ac18-69142db3a1f5", "AQAAAAIAAYagAAAAEOyQskNDU819sFV6CZvP7zbu189HllS8XF8dKj2S2BSk1E4T5Lb3Xj0wTxFNvi9+Rg==", "b282b19c-3669-4e64-b486-743039d222ed" });
        }
    }
}
