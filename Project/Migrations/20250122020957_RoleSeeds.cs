using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4184bb7a-9688-497f-b7f6-bf52674a69bb", "AQAAAAIAAYagAAAAENoXjk2zTeyj2at8b22xwcYseoT3vHpbxkL/94reXyoEBuGdwTemQRipOB2muOw8pQ==", "5c95eddf-dfa3-4607-960d-554456ceff90" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2781efa7-66dc-47f0-860f-e506d04102e4", 0, "b54413b5-92ec-48fa-8616-522129b561e2", "user@localhost.com", true, "John", "Bork", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPpJHkNpS3j62rlsXtN7IJ12cd0S/iOM+yCoH6rJFz1taM6eI1qHNzr6M0f4MVZgOw==", null, false, "8fd544c6-3b79-4f27-8b1f-fd19ffdd9b28", false, "user@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518ba", "2781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518ba", "2781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a956b93-c737-4f71-b4ed-4b3faf2f0b8c", "AQAAAAIAAYagAAAAEAjiXy/NRYsWj8jFzj8evw1ujwp8MDLqb+KNyQCbC1+OsMTJkXcxwcd3IALRBFC6kg==", "b6044b1e-7e76-41dd-b153-e68a59aa948c" });
        }
    }
}
