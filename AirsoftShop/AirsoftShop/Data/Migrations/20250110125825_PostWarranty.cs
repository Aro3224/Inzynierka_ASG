using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class PostWarranty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostWarranties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DamageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceAnswerAfterRepair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostWarranties", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "960b0657-7167-4856-b847-764dd05a359e", "AQAAAAIAAYagAAAAECT1tcHj9+M6lvvg+uoFpv/zob9ZI5NMMEtxrAebNH8KZnd6dKhY6ZH3Wi0/uy0OLA==", "4e29c6e6-078b-4cf6-b0eb-1638fd389573" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab8da717-9d86-42fd-b67a-473e15d505f5", "AQAAAAIAAYagAAAAECT1tcHj9+M6lvvg+uoFpv/zob9ZI5NMMEtxrAebNH8KZnd6dKhY6ZH3Wi0/uy0OLA==", "3fd06a3a-c12f-494c-a2df-dc1132fd1831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81d84efc-6cb9-4327-a7c8-d01fc466a0b9", "AQAAAAIAAYagAAAAECT1tcHj9+M6lvvg+uoFpv/zob9ZI5NMMEtxrAebNH8KZnd6dKhY6ZH3Wi0/uy0OLA==", "1985387c-d3b4-40c6-92f5-feb548d65d42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37e70800-139c-4f9a-850f-681cf76a596d", "AQAAAAIAAYagAAAAECT1tcHj9+M6lvvg+uoFpv/zob9ZI5NMMEtxrAebNH8KZnd6dKhY6ZH3Wi0/uy0OLA==", "02cecfe5-cbeb-49e6-9ecc-273d70482f13" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostWarranties");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccac204f-a084-4cd1-bd96-abc8a4889bd2", "AQAAAAIAAYagAAAAEJrGKCO+I3jxW9Ue9wbJti0Vrbj/1txK9+9oNf4YuZVaZlE35ekTJ3BBYg4Xt8bjGg==", "3f6166d3-6a7e-4fa7-84df-b4489b3d4e34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfd31c4e-d753-41e7-8c74-94251ca0497c", "AQAAAAIAAYagAAAAEJrGKCO+I3jxW9Ue9wbJti0Vrbj/1txK9+9oNf4YuZVaZlE35ekTJ3BBYg4Xt8bjGg==", "fd4cb5e3-186a-46cc-a6da-279599cfc636" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5238b396-9b96-4379-b514-d340fe13dabb", "AQAAAAIAAYagAAAAEJrGKCO+I3jxW9Ue9wbJti0Vrbj/1txK9+9oNf4YuZVaZlE35ekTJ3BBYg4Xt8bjGg==", "919342b1-319e-4601-87c7-d094c9d692b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52c4680f-78cd-4ebb-b264-35e76f34704b", "AQAAAAIAAYagAAAAEJrGKCO+I3jxW9Ue9wbJti0Vrbj/1txK9+9oNf4YuZVaZlE35ekTJ3BBYg4Xt8bjGg==", "add1c9f2-15d2-41ff-a581-0daabfec0623" });
        }
    }
}
