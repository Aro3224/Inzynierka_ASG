using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class UserIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "31931323-1e4d-4eaa-9324-b79a522ca8aa", "AQAAAAIAAYagAAAAEPjYO9Lxu0TTd6Aa6krzSleviToEe0iicSXWJ/0lqpMqli0Kgkk/JEwJ9Odi+lpuig==", "c49c19a4-700d-4032-8974-e72c94ec7a85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7cc9dd4-5e1b-4c46-a9cb-268202d6069b", "AQAAAAIAAYagAAAAEPjYO9Lxu0TTd6Aa6krzSleviToEe0iicSXWJ/0lqpMqli0Kgkk/JEwJ9Odi+lpuig==", "8d6b0668-89aa-46ff-8b49-62a07d22e3f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2467b6f-6409-4751-9dfa-803e746ce5eb", "AQAAAAIAAYagAAAAEPjYO9Lxu0TTd6Aa6krzSleviToEe0iicSXWJ/0lqpMqli0Kgkk/JEwJ9Odi+lpuig==", "6e8ce1d1-46be-4103-96cf-ae0047b774ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36053a57-436e-4390-a731-1aeb194cbaf2", "AQAAAAIAAYagAAAAEPjYO9Lxu0TTd6Aa6krzSleviToEe0iicSXWJ/0lqpMqli0Kgkk/JEwJ9Odi+lpuig==", "a1eded77-777c-448d-8dc4-7e3314a83a51" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
