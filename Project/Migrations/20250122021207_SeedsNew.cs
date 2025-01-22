using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedsNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "732e0e9b-a827-4dd5-be1c-712f1bb4de2f", "AQAAAAIAAYagAAAAEC5x650wGddrVp7YBBbe6akC9cYK1gqdO1aZCxiZhwr+yowYSKRfodO071ojv7iVMw==", "39ed1a3f-66c6-4310-94b6-6fabe7fb2ebe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "398343d7-2003-4276-9c1f-c3601702e28e", "AQAAAAIAAYagAAAAEKH+eLR0jPM4zEVXZgmIJXop0YAsPbKCWAFCl8JPHE4TzM5wtkkQWeQGltFppXOg+w==", "4075a6b1-325c-46e5-b6a6-8f8e030ba262" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "2781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4184bb7a-9688-497f-b7f6-bf52674a69bb", "AQAAAAIAAYagAAAAENoXjk2zTeyj2at8b22xwcYseoT3vHpbxkL/94reXyoEBuGdwTemQRipOB2muOw8pQ==", "5c95eddf-dfa3-4607-960d-554456ceff90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b54413b5-92ec-48fa-8616-522129b561e2", "AQAAAAIAAYagAAAAEPpJHkNpS3j62rlsXtN7IJ12cd0S/iOM+yCoH6rJFz1taM6eI1qHNzr6M0f4MVZgOw==", "8fd544c6-3b79-4f27-8b1f-fd19ffdd9b28" });
        }
    }
}
