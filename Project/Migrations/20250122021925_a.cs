using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class a : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518ba", "2781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49ccbf15-e86a-4f97-b30c-259305439a3a", "AQAAAAIAAYagAAAAEDA/Oq7ixEkozM/Hc1oRvM7L3ZmzvkDv4mqCcbxHZjjytvjFtEeZAvr/9YzpSvdsxA==", "4c69ee4a-1522-473e-a256-b910e062e3c5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518ba", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ff92513-df95-4d9f-91b4-b5c3858b3812", "AQAAAAIAAYagAAAAEArbkvHjJN5R5LIOIR4rUiGN3CcYOBeJ/aIMTmoLahoc2nHTDQ5ofk3uMHM30/w5Dw==", "86c58307-062d-46a6-9e33-ea15cff90711" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2781efa7-66dc-47f0-860f-e506d04102e4", 0, "0699af23-9b9c-49b8-b71a-d3c6db70a5fb", "user@localhost.com", true, "John", "Bork", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHhDSjmJmINVLVJaYQZRq7X9C/uusNUrqS6SDLZUOILe0kJR80iRU9XfRsQH6DxYXQ==", null, false, "17b9cda1-5792-4922-ac7c-15b72005a940", false, "user@localhost.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518ba", "2781efa7-66dc-47f0-860f-e506d04102e4" });
        }
    }
}
