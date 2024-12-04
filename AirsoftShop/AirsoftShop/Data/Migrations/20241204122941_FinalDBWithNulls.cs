using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class FinalDBWithNulls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "657f08e6-01eb-467d-85a5-0dbfd07f6d20", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "07783109-bff9-40f1-956c-02fdf37fae08" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7212201-0fa7-41cf-9d0f-1e8456bd5212", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "ef361cd2-dee8-4b2d-8b20-36a2489d0819" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fb00e75-3638-46c5-a0de-04d51433f5b1", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "4b500cf2-5795-40b6-bca8-a430b9c91d53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8f4b8e5-c686-4fb9-99ee-db12b79c3636", "AQAAAAIAAYagAAAAEInkfjBLizUvfVIxPpp5hy5tDa/7InfqlqUD/lF6IqEYsSAsWJNqAhonRLwwX4Ny4A==", "8603a364-a0dd-4cf8-bc4d-2702691e1564" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ba00bfd-8f67-411c-a3b9-e288cb64de27", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "06560c37-eb4c-4153-8656-3d29a7ffb46a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c10cd103-b9a7-47ea-b676-089aa15037ba", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "25c6ea25-94de-4c55-a534-01caeb3a0bdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0220be62-79e3-49b7-8571-786fe780c289", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "f5a43d75-7bce-4a70-8c3f-817ff7dc3641" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76eddc8d-d40b-43fb-b58a-29432a748167", "AQAAAAIAAYagAAAAECnuTIRJHFyJHLhBdcCdsWwRCwPaMKtClx8Ahq+N3PH5unLHy7Vj8xR8pOI9LN4K7g==", "9ae7ae2e-0ad3-49f7-8385-90fc7ce49ef4" });
        }
    }
}
