using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class UnifyAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeNumber",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "AspNetUsers",
                newName: "Address");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17f09af6-adb2-40c2-bc6c-55894edb2bc6", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "2a5f0feb-d40f-46a7-be94-48310209ef09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bac7d9de-abc0-4c56-8336-fc4491b70723", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "39919466-2d83-4237-b6c0-66b131342044" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d2150a0-3c4f-4dc1-a726-5072d69bb96e", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "445a0d9a-3664-401d-919f-df42b1519546" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c05bdbfc-d974-4df0-9b64-e39a7b5e2afd", "AQAAAAIAAYagAAAAEBHOrlVILM03MNIMQsNgZBGFFDgAPrnWbG2sHm4Q6PuJm9LSi/eWOG/+9ADB2HPjgA==", "3aedc4f4-0369-45dd-88fa-5de6dbb05cd3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "AspNetUsers",
                newName: "Street");

            migrationBuilder.AddColumn<string>(
                name: "HomeNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "HomeNumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "227abd74-eb5b-4674-92c2-e6b97e1b5ad0", null, "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "13b8ac67-cc54-49b2-a912-0b699f7dc58f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "HomeNumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3da515d2-4225-4c59-abfb-13df9842ca20", null, "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "cf705e7d-335a-467a-9c85-00a74c904a47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "HomeNumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d6385e-ea3e-4330-a003-1e5817fccfa5", null, "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "d7002582-865c-4e5c-ac51-f8b3cae86c19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "HomeNumber", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31f974e8-4038-4c9e-b779-ca403ab15c66", null, "AQAAAAIAAYagAAAAEChPrSO5UOOKJnDrVK89UN74N1xyOS9JbMNTJolfJIM1EpK4fal5F8rpbvUcpSUHbg==", "8d20761c-ec6e-41ea-9d46-18bd8fbe09ed" });
        }
    }
}
