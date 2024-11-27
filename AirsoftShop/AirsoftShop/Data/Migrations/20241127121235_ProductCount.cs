using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class ProductCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Replicas",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Replicas");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19a52205-0baf-4f5b-be52-bddfa2ef61de", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "60d1e647-7f76-4d07-a645-2498f89ca4dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a2b5c4-fedb-4a9f-81d9-06aa4f8530f0", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "9a291b56-de81-4073-825e-f7563c7a4f47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc858f74-2c61-4b22-a386-3bed46961a1a", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "d5c9d923-978f-45c8-8943-a703dfb08599" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83fd53e1-50ae-47e0-8be4-66f0c841d040", "AQAAAAIAAYagAAAAEMfptR3nqO1yhHyvTQ7OlYRNy3H45nRuaDqGDosk/PAXHw/QWq3XGQZjd1wIdJp4SQ==", "4c59b3de-562b-4ac6-abd0-ad54e75bd87a" });
        }
    }
}
