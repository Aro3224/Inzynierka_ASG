using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirsoftShop.Migrations
{
    /// <inheritdoc />
    public partial class complaintstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComplaintItem_Complaint_ComplaintId",
                table: "ComplaintItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint");

            migrationBuilder.RenameTable(
                name: "Complaint",
                newName: "Complaints");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complaints",
                table: "Complaints",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc3ec2aa-adbb-401b-80a0-54e0290246dd", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "a5034cbf-0473-4948-8d36-0c6caebb6c34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9db3ecb0-5fe6-4c24-bb0d-7384dadfeede", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "3a121781-89e5-47b5-bce1-c0ae40bab338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7904efb3-58d0-4659-a592-6752cc881e62", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "323c485a-6d1d-4e6b-9c48-299f6be8193d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28e53619-5fa4-4067-baa0-1d248d320b55", "AQAAAAIAAYagAAAAEEmwSHBb7ZbNFbMDEbvEofCHlfHtSr/HHd6Vov/k7dB5d33sjk+e2zKAj+1KuPqy+Q==", "38c5950c-e878-465d-82fc-976376f4e695" });

            migrationBuilder.AddForeignKey(
                name: "FK_ComplaintItem_Complaints_ComplaintId",
                table: "ComplaintItem",
                column: "ComplaintId",
                principalTable: "Complaints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComplaintItem_Complaints_ComplaintId",
                table: "ComplaintItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complaints",
                table: "Complaints");

            migrationBuilder.RenameTable(
                name: "Complaints",
                newName: "Complaint");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complaint",
                table: "Complaint",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ComplaintItem_Complaint_ComplaintId",
                table: "ComplaintItem",
                column: "ComplaintId",
                principalTable: "Complaint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
