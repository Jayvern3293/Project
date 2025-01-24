using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class OrganizationSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7fbeeb6-7d96-4b82-a646-4c8ca67d5f55", "AQAAAAIAAYagAAAAEDctbpwhunU6Ry5ulsV5/iwMxkjpj7Qj699NZ+5WmTFD+kWfd+LqMkrnhLJwMKi49Q==", "7584accd-6767-410c-bc6c-316fc11f20ea" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d1f3ee-80ed-4696-a1f2-f16cb52771b7", "AQAAAAIAAYagAAAAEEh5gtUIwbW3MeT1bf7FwL2dC32la09MUKJvJBHGxyExMvlQsLRrmCwTVk6iQHFMBQ==", "36aed453-f3a0-4616-bd33-582385371a1a" });
        }
    }
}
