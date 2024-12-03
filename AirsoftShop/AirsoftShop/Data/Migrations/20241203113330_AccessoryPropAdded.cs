using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class AccessoryPropAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BbAmmount",
                table: "Accessories",
                newName: "Bbsize");

            migrationBuilder.AddColumn<int>(
                name: "BatteryVoltage",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b9720cc-63f5-4996-948a-e4a83cf742fc", "AQAAAAIAAYagAAAAEEZhvyEqpft6N8kglvH6ONALgkvOVityQx9N+/kMH+KcC9YYCB/8VFXmSdMwo2mv0Q==", "4da884c9-83cb-4f24-a81d-5f13d5d20ae0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7be9705-2165-4a81-a852-3210b7f3cb09", "AQAAAAIAAYagAAAAEEZhvyEqpft6N8kglvH6ONALgkvOVityQx9N+/kMH+KcC9YYCB/8VFXmSdMwo2mv0Q==", "6d085ae0-99e7-41f1-9e49-aae209b38e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea75656d-eb8e-440c-a932-681cd5669b68", "AQAAAAIAAYagAAAAEEZhvyEqpft6N8kglvH6ONALgkvOVityQx9N+/kMH+KcC9YYCB/8VFXmSdMwo2mv0Q==", "084e21ea-81dc-4125-9f11-6c8cb26c2f5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45987e09-1302-4ae9-b929-0005af810040", "AQAAAAIAAYagAAAAEEZhvyEqpft6N8kglvH6ONALgkvOVityQx9N+/kMH+KcC9YYCB/8VFXmSdMwo2mv0Q==", "347a4bed-8567-44e2-8fbc-0a2002cc4dc3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryVoltage",
                table: "Accessories");

            migrationBuilder.RenameColumn(
                name: "Bbsize",
                table: "Accessories",
                newName: "BbAmmount");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4489cb00-3475-405a-9171-f9e6109c709e", "AQAAAAIAAYagAAAAEC7SBDSkVs3j3fDPgpY6YgCLtIgy3DFpYkVIw6gMd88rFHPXgN3iw4Bq86SY1Su5Aw==", "ac6237f2-a471-4c1b-b7d3-340d53d7a927" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a87c74d0-1d8c-4514-91df-9ab831703b38", "AQAAAAIAAYagAAAAEC7SBDSkVs3j3fDPgpY6YgCLtIgy3DFpYkVIw6gMd88rFHPXgN3iw4Bq86SY1Su5Aw==", "810d3153-21ba-4412-9abf-fb051daa3214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a5f6b5b-64e5-45f0-87c0-c142050b7105", "AQAAAAIAAYagAAAAEC7SBDSkVs3j3fDPgpY6YgCLtIgy3DFpYkVIw6gMd88rFHPXgN3iw4Bq86SY1Su5Aw==", "1b1ce97a-1c19-4d24-8157-3980dd3e7fc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63e9df9e-6b17-497a-859b-10a0042c1dea", "AQAAAAIAAYagAAAAEC7SBDSkVs3j3fDPgpY6YgCLtIgy3DFpYkVIw6gMd88rFHPXgN3iw4Bq86SY1Su5Aw==", "f2f76dd7-b86a-4589-b5c0-40662ce36d10" });
        }
    }
}
