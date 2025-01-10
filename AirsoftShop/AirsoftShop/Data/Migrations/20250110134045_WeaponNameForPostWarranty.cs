using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class WeaponNameForPostWarranty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WeaponName",
                table: "PostWarranties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WeaponName",
                table: "PostWarranties");

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
    }
}
