using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class complaintUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComplaintDescription",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerComplaintChoice",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplaintDescription",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CustomerComplaintChoice",
                table: "Complaints");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc3ec2aa-adbb-401b-80a0-54e0290246dd", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "a5034cbf-0473-4948-8d36-0c6caebb6c34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9db3ecb0-5fe6-4c24-bb0d-7384dadfeede", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "3a121781-89e5-47b5-bce1-c0ae40bab338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7904efb3-58d0-4659-a592-6752cc881e62", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "323c485a-6d1d-4e6b-9c48-299f6be8193d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28e53619-5fa4-4067-baa0-1d248d320b55", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "38c5950c-e878-465d-82fc-976376f4e695" });
        }
    }
}
