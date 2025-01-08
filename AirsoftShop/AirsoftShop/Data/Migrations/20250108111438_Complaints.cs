using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class Complaints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaint",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ComplaintType = table.Column<int>(type: "int", nullable: false),
                    ComplaintStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplaintItem_Complaint_ComplaintId",
                        column: x => x.ComplaintId,
                        principalTable: "Complaint",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee4dcd14-0b6b-4f90-b112-e9b0e94b7fef", "AQAAAAIAAYagAAAAEFmwSM/vNEwsR9n6hpYesw0z4WpkiP6E9J2abG9aivb1d4Cthr8moYlmVD0KErFDHA==", "8cb0a602-3d9c-4277-86ae-d362378423b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e793084-2ea7-4aa6-b17f-38f67e139c3f", "AQAAAAIAAYagAAAAEFmwSM/vNEwsR9n6hpYesw0z4WpkiP6E9J2abG9aivb1d4Cthr8moYlmVD0KErFDHA==", "50a8f87b-544e-49dc-a203-20c314b6b4fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad72b5e6-54ae-4b59-82bf-5031e2ca9d9f", "AQAAAAIAAYagAAAAEFmwSM/vNEwsR9n6hpYesw0z4WpkiP6E9J2abG9aivb1d4Cthr8moYlmVD0KErFDHA==", "9029709f-90d1-4709-9c3a-5411fbf75028" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7291db9e-9754-46d9-9707-b84d8be0117a", "AQAAAAIAAYagAAAAEFmwSM/vNEwsR9n6hpYesw0z4WpkiP6E9J2abG9aivb1d4Cthr8moYlmVD0KErFDHA==", "b43dabb0-7ae0-4708-9aa0-afa450fe0f02" });

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintItem_ComplaintId",
                table: "ComplaintItem",
                column: "ComplaintId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplaintItem");

            migrationBuilder.DropTable(
                name: "Complaint");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e672133-df82-43a1-ae27-6fee267b9a97", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "e6798d64-58ad-4845-96dd-92d3d32e3ba9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd1172b4-7992-4727-8854-88409d296eff", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "427c273b-07d8-4e4f-a488-3d8468786b45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d02da468-2035-49ba-a716-9bb5f848a32b", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "a10945bc-ef67-4c3c-acce-32c3f4d85157" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a511f84f-a7f0-4cf5-9003-d1fcb94ed76f", "AQAAAAIAAYagAAAAECr10n6OXBbiA4ODpm3u7T2O4eTmol7tpvwmozNuL60yYFgWOfBJuV8mJ8NzMshAQQ==", "c39c1e15-b68b-410e-b27a-9e4be538c8a5" });
        }
    }
}
