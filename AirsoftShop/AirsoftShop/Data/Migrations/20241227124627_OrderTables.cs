using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class OrderTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReplicaId = table.Column<int>(type: "int", nullable: true),
                    PartId = table.Column<int>(type: "int", nullable: true),
                    AccessoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Accessories_AccessoryId",
                        column: x => x.AccessoryId,
                        principalTable: "Accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Parts_PartId",
                        column: x => x.PartId,
                        principalTable: "Parts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_OrderItems_Replicas_ReplicaId",
                        column: x => x.ReplicaId,
                        principalTable: "Replicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_AccessoryId",
                table: "OrderItems",
                column: "AccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_PartId",
                table: "OrderItems",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ReplicaId",
                table: "OrderItems",
                column: "ReplicaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a9cfc2-4b32-494a-919e-b55d2dfc9353", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "fcb5d6e0-99ae-4070-a55c-25da02c2efad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a18b60b0-2c76-47ae-8156-42ad11cbe516", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "aa98da9b-a049-4679-acfd-3c017adb8e6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e21491b1-c03b-46c6-bafe-2d879b8e149a", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "bf585a6d-b503-4951-9a78-a5bdc838e497" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33cb122c-ba4a-46e4-bb42-7a41324233d7", "AQAAAAIAAYagAAAAEFgrfNOP5U/CTiaJCxWnQUY+5+UYb+A67bOrX2mtyRFSsmCQ7PfEbAgyTMIYcIjJTA==", "3afd05c5-daeb-4c0a-9335-3390de8df21e" });
        }
    }
}
