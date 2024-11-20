using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class RenameHouseNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HouseNumber",
                table: "AspNetUsers",
                newName: "HomeNumber");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "227abd74-eb5b-4674-92c2-e6b97e1b5ad0", "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "13b8ac67-cc54-49b2-a912-0b699f7dc58f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3da515d2-4225-4c59-abfb-13df9842ca20", "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "cf705e7d-335a-467a-9c85-00a74c904a47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d6385e-ea3e-4330-a003-1e5817fccfa5", "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "d7002582-865c-4e5c-ac51-f8b3cae86c19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31f974e8-4038-4c9e-b779-ca403ab15c66", "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "8d20761c-ec6e-41ea-9d46-18bd8fbe09ed" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HomeNumber",
                table: "AspNetUsers",
                newName: "HouseNumber");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0c0b786-8861-4e14-917b-9c3ec2af443a", "AQAAAAIAAYagAAAAEGPO8o5M2gvyXiCJMiPHORAngIZA2HTu1dfWTyGsKOwYDPYPMwetqJTo3TJdiiLvBg==", "a0683c85-1d2d-4a86-b70e-bc17398c62a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ba01e03-da0d-4709-9eda-3cd85c5a8ba9", "AQAAAAIAAYagAAAAEGPO8o5M2gvyXiCJMiPHORAngIZA2HTu1dfWTyGsKOwYDPYPMwetqJTo3TJdiiLvBg==", "babbfe31-af55-4d94-96ac-199ca50d98a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f563766b-03ef-4ee7-be28-5dc5cdf7cd87", "AQAAAAIAAYagAAAAEGPO8o5M2gvyXiCJMiPHORAngIZA2HTu1dfWTyGsKOwYDPYPMwetqJTo3TJdiiLvBg==", "1703c9b0-1238-4e5d-a81a-596aa7718558" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b7d0360-f7f1-4e71-a3bd-ee9f601a2c82", "AQAAAAIAAYagAAAAEGPO8o5M2gvyXiCJMiPHORAngIZA2HTu1dfWTyGsKOwYDPYPMwetqJTo3TJdiiLvBg==", "8808b1d6-0353-4574-a6a9-85c3b14787de" });
        }
    }
}
