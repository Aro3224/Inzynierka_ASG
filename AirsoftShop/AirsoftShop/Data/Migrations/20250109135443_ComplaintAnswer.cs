using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintAnswer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComplaintAnswer",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplaintAnswer",
                table: "Complaints");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a09ffd4-1265-4887-aef3-bd1f23740694", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "3ae0331a-9323-41b9-b7e1-69da80357053" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77342a6a-e84f-4646-8b0e-b32881a628e1", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "e65b9d83-1d71-4fbd-b27a-c1f73be0cb38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94879761-e214-4be2-85b9-b336d3bd23e0", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "f1659856-02f5-4c67-a1d9-c297fabd3b3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4eaf5d51-0573-4e22-aeb2-3bd62f3c80b0", "AQAAAAIAAYagAAAAEN1l5DSONe3UEicaN2R8WZ/8Q6tCjMeOzAP3x62vllQiY2WVIcMTso0FmPaTYHoIJg==", "ed94d05e-bfba-47e7-b496-689bc2259363" });
        }
    }
}
