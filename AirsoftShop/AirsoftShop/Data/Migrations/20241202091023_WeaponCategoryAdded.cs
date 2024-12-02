using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class WeaponCategoryAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WeaponCategory",
                table: "Replicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeaponCategory",
                table: "Replicas");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9455fc3-013b-439e-942c-8392849aa578", "AQAAAAIAAYagAAAAEKyDDAglHXghQvNoHoDG1ZTSbzmbSSqbg+W7oRwGgt5GOsJ6sauYInIeYocwnPwKYQ==", "a5176b56-3b8b-4473-98dd-4d094e39bf6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01586b0f-2f7a-4a83-bfca-c1069797c8aa", "AQAAAAIAAYagAAAAEKyDDAglHXghQvNoHoDG1ZTSbzmbSSqbg+W7oRwGgt5GOsJ6sauYInIeYocwnPwKYQ==", "82f86720-bff4-4f2c-b541-7bb38ceb2edb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcf7d955-dc3d-4b35-b8f3-ebc45c4defad", "AQAAAAIAAYagAAAAEKyDDAglHXghQvNoHoDG1ZTSbzmbSSqbg+W7oRwGgt5GOsJ6sauYInIeYocwnPwKYQ==", "ebce09a6-5b78-4a01-8cad-90159acfef24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e97fa011-b38f-4e0f-9993-02c5c3056864", "AQAAAAIAAYagAAAAEKyDDAglHXghQvNoHoDG1ZTSbzmbSSqbg+W7oRwGgt5GOsJ6sauYInIeYocwnPwKYQ==", "a405751a-20a5-478b-bd42-7f497d92ce59" });
        }
    }
}
