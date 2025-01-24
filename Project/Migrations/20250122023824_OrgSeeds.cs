using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class OrgSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af4a0b85-3890-4b24-b31c-f19367b5ffbc", "AQAAAAIAAYagAAAAEKY17S7RzYOEoTizKz8P/qF5LXUCp1Cg1AhIrOYOkUbjrW3h8NWFZWWnj3bUe3uU7A==", "6b8bc7e8-ff38-4961-ab26-e7c154a997f8" });

            migrationBuilder.InsertData(
                table: "Organization",
                columns: new[] { "OrganizationId", "Address", "Name" },
                values: new object[] { 1, "977 Grove Street", "HYV Animal Shelter" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Organization",
                keyColumn: "OrganizationId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7fbeeb6-7d96-4b82-a646-4c8ca67d5f55", "AQAAAAIAAYagAAAAEDctbpwhunU6Ry5ulsV5/iwMxkjpj7Qj699NZ+5WmTFD+kWfd+LqMkrnhLJwMKi49Q==", "7584accd-6767-410c-bc6c-316fc11f20ea" });
        }
    }
}
