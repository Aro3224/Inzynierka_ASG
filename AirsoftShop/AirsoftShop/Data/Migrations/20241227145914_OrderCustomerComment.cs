using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class OrderCustomerComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerComment",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88bc09f6-5592-43aa-92b4-69d450157fd2", "AQAAAAIAAYagAAAAEKT1TCU3YXGp4KAa5SgL3KDyK8X3s5z8ORu5mLUOKSQVKKupo2raMWMXRik3a46p2A==", "79df8307-1779-4c33-b79f-aa8e62300b5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fec17bcb-c328-4284-9da0-5484703ed7fa", "AQAAAAIAAYagAAAAEKT1TCU3YXGp4KAa5SgL3KDyK8X3s5z8ORu5mLUOKSQVKKupo2raMWMXRik3a46p2A==", "6e2b9061-cfd2-4d0d-8008-e0738d357cbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5508f53d-a884-4741-bf9b-6ac7d36affa8", "AQAAAAIAAYagAAAAEKT1TCU3YXGp4KAa5SgL3KDyK8X3s5z8ORu5mLUOKSQVKKupo2raMWMXRik3a46p2A==", "de38bb76-7681-4854-860b-e67ca727edca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ec8a3bd-9a77-4bf5-91f1-37ea42d35852", "AQAAAAIAAYagAAAAEKT1TCU3YXGp4KAa5SgL3KDyK8X3s5z8ORu5mLUOKSQVKKupo2raMWMXRik3a46p2A==", "329228d6-646b-4cfa-aede-4c2840164dd0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerComment",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be58f4f3-594f-4d9a-8775-36a01796543a", "AQAAAAIAAYagAAAAEOG4Z5WjdlNSy+OFJMm8OoImoEOTZPwRQm0tEpzNv9pPJzF4KXOol2ivxDJ1YGg+NA==", "606295fe-d6e2-49cd-8164-68546c31102a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "180f6acf-473b-4a6d-a066-0e510608e07f", "AQAAAAIAAYagAAAAEOG4Z5WjdlNSy+OFJMm8OoImoEOTZPwRQm0tEpzNv9pPJzF4KXOol2ivxDJ1YGg+NA==", "95863d68-58d5-4f79-b0b1-84844a158f9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "729cf347-297c-48c0-adf5-655cf4aaf379", "AQAAAAIAAYagAAAAEOG4Z5WjdlNSy+OFJMm8OoImoEOTZPwRQm0tEpzNv9pPJzF4KXOol2ivxDJ1YGg+NA==", "e089e8f8-1967-4295-bf13-a2f40166dd86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e8145b-4305-4e76-bbf5-685805de71a3", "AQAAAAIAAYagAAAAEOG4Z5WjdlNSy+OFJMm8OoImoEOTZPwRQm0tEpzNv9pPJzF4KXOol2ivxDJ1YGg+NA==", "96f0ac16-fae5-42d1-9469-f3506142a1b4" });
        }
    }
}
