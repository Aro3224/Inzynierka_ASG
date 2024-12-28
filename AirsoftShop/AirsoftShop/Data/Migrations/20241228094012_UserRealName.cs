using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class UserRealName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp", "Surname" },
                values: new object[] { "da58ef71-5819-4411-bfdb-3fbbc9b3fe2a", null, "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "f9b980ab-96b0-45cb-b645-fba53672915e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp", "Surname" },
                values: new object[] { "127cf9cd-9ac5-4081-aafb-3192ed3287be", null, "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "f0f105f1-6d2b-4b77-a22b-4469559dc18c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp", "Surname" },
                values: new object[] { "6bb1d6e4-68dc-402c-8409-d692b67efd0b", null, "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "b236253e-64fb-45c1-b826-bbf1d6560e54", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp", "Surname" },
                values: new object[] { "0418100e-b4f2-4559-8795-48e9febfbb6c", null, "AQAAAAIAAYagAAAAEIulRCC2bzntl7uYd0eHMEGuKxVvhOXsktKsy5U5eKfqV9zNCkflv/4sg/OnsLgUhA==", "a9a2bd08-c075-41ce-95d7-c19a1b6fe82c", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

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
    }
}
