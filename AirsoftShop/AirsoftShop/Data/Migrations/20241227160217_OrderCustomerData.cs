using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class OrderCustomerData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerSurname",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02282f1f-4a82-4a1c-a77d-0d142428609c", "AQAAAAIAAYagAAAAEK+22a43DIWSqLrM/ZXoNmIU0iy/+aQsfZVDWk0QOd9mqhzpQCu/770weyie7wQoGw==", "12804799-a278-42ad-9d3b-bb0ddc07d9c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d201978f-eb05-4fdc-b2be-5380afbd0bef", "AQAAAAIAAYagAAAAEK+22a43DIWSqLrM/ZXoNmIU0iy/+aQsfZVDWk0QOd9mqhzpQCu/770weyie7wQoGw==", "ac97051f-a5f6-42c5-9249-e50c878ac37f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a28f3c0-26fe-4dea-a231-69161634c339", "AQAAAAIAAYagAAAAEK+22a43DIWSqLrM/ZXoNmIU0iy/+aQsfZVDWk0QOd9mqhzpQCu/770weyie7wQoGw==", "1674eca1-ba27-493a-a394-74c93bf402bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "526520fe-5995-483e-bc7b-f7e304da55f2", "AQAAAAIAAYagAAAAEK+22a43DIWSqLrM/ZXoNmIU0iy/+aQsfZVDWk0QOd9mqhzpQCu/770weyie7wQoGw==", "9c343076-462b-42dc-b175-35aa17d06899" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerSurname",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
