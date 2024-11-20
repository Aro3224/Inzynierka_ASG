using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDateOfBirth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9f05ec5-7b4b-4630-bbd6-6d132b38ab2b", null, "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", "95799d25-3edb-4871-aa9d-b743357025d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e45bd259-6e88-496f-b8cb-32af83efd232", null, "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", "91a4f298-9cb5-4b4d-a196-79223d3136e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d185e11e-1caf-431e-be7b-fda53aa31aa8", null, "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", "4a78bb0f-f2b5-4561-af0a-a1f64a59f047" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb4fca0b-2b82-4fd7-a1a9-22fb016b3808", null, "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", "48a5e95d-2291-4424-ac91-c717432407aa" });
        }
    }
}
