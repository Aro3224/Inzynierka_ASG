using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class WeaponIdForWarranty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeaponId",
                table: "PostWarranties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb84f26f-d7ac-468f-8f04-51ba715ef2e7", "AQAAAAIAAYagAAAAEBd7Vi1M3z8jEugKe2TVvxiliDw1OgFouhqaz+6b0GVz0+fOLlaB+Db/p/Cprb9ntA==", "d82c0195-c5ce-443e-9523-7f8816884cc0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c9b8aec-6559-4794-a71f-0b149c95b3d7", "AQAAAAIAAYagAAAAEBd7Vi1M3z8jEugKe2TVvxiliDw1OgFouhqaz+6b0GVz0+fOLlaB+Db/p/Cprb9ntA==", "17fee421-8804-4ffb-8769-4a6e80752218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7366a86a-c1e7-4eb4-9e12-1d70122998b4", "AQAAAAIAAYagAAAAEBd7Vi1M3z8jEugKe2TVvxiliDw1OgFouhqaz+6b0GVz0+fOLlaB+Db/p/Cprb9ntA==", "429b8c6b-e0af-4ff4-ba2c-7825cc8e61a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "678eea60-3a70-46db-ba9e-9cd7ecaa5858", "AQAAAAIAAYagAAAAEBd7Vi1M3z8jEugKe2TVvxiliDw1OgFouhqaz+6b0GVz0+fOLlaB+Db/p/Cprb9ntA==", "bc466ba0-3312-4d03-a41a-56bf4c8ee007" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "PostWarranties");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aabf305a-763d-4a52-af34-9664a72d0469", "AQAAAAIAAYagAAAAEFgVxLGtEQv0NH8vSstcPOE44TJv/ADohSpJqoVhUxxva4/T/t0MfWajaCWI73qcig==", "741282c0-9468-4468-9c52-7dc7f0c404c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f8f74c0-61d1-42c9-a5af-e913e17b632a", "AQAAAAIAAYagAAAAEFgVxLGtEQv0NH8vSstcPOE44TJv/ADohSpJqoVhUxxva4/T/t0MfWajaCWI73qcig==", "ad8e7ae9-880a-4174-a435-bdaec70cdc05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d0cbf27-8a82-49e5-ae2d-95f0d5a385f5", "AQAAAAIAAYagAAAAEFgVxLGtEQv0NH8vSstcPOE44TJv/ADohSpJqoVhUxxva4/T/t0MfWajaCWI73qcig==", "24b42d9f-38c8-42b9-935b-42fee86bff9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6ecc487-5f71-471e-b2ae-93862f5675ea", "AQAAAAIAAYagAAAAEFgVxLGtEQv0NH8vSstcPOE44TJv/ADohSpJqoVhUxxva4/T/t0MfWajaCWI73qcig==", "95b51a74-697c-4027-aac7-35d8dfeab468" });
        }
    }
}
