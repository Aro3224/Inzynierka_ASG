using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HouseNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "HouseNumber", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "b9f05ec5-7b4b-4630-bbd6-6d132b38ab2b", null, "admin@gmail.com", true, null, true, null, "ADMIN@GMAIL.COM", "ADMIN1", "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", null, false, null, "95799d25-3edb-4871-aa9d-b743357025d0", null, false, "admin1" },
                    { "2", 0, null, "e45bd259-6e88-496f-b8cb-32af83efd232", null, "user@gmail.com", true, null, true, null, "USER@GMAIL.COM", "USER1", "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", null, false, null, "91a4f298-9cb5-4b4d-a196-79223d3136e3", null, false, "user1" },
                    { "3", 0, null, "d185e11e-1caf-431e-be7b-fda53aa31aa8", null, "user2@gmail.com", true, null, true, null, "USER2@GMAIL.COM", "USER2", "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", null, false, null, "4a78bb0f-f2b5-4561-af0a-a1f64a59f047", null, false, "user2" },
                    { "4", 0, null, "fb4fca0b-2b82-4fd7-a1a9-22fb016b3808", null, "user3@gmail.com", true, null, true, null, "USER3@GMAIL.COM", "USER3", "AQAAAAIAAYagAAAAEJHLMql+TlBhfRwdaTiD6LC735+M0Mzrnc7b7agO9jJALhguBygKxRwU6hGdVrMTQw==", null, false, null, "48a5e95d-2291-4424-ac91-c717432407aa", null, false, "user3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "2", "2" },
                    { "2", "3" },
                    { "2", "4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HouseNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "AspNetUsers");
        }
    }
}
