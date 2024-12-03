using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class ProductPropAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BearingDiameter",
                table: "Parts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "AccessoryType",
                table: "Accessories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BearingDiameter",
                table: "Parts");

            migrationBuilder.DropColumn(
                name: "AccessoryType",
                table: "Accessories");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6210cc1d-5837-451c-870d-c723bbd5c6f1", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "897856b7-b13e-419e-aa6c-097942c94a63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a37c389-95b6-4c09-906a-3e5487bd4f09", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "2c7d0492-66b8-4c29-bdb6-e03d9d66d692" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d558db0d-84d2-4f03-bbeb-3ee703fda192", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "7ad811ed-35c3-4906-94c1-cb2dd577872d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fdca64a-c678-4045-9475-77298d5e499e", "AQAAAAIAAYagAAAAEMGilr/5PW4EvOZgT6a0zPkQpqnQnmg1ngCEamLvpXINazl9lqCupX+Jgdk8R/yNdg==", "d93d83aa-cde2-40dd-a51a-654bdb33b69a" });
        }
    }
}
