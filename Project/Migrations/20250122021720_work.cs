using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class work : Migration
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0699af23-9b9c-49b8-b71a-d3c6db70a5fb", "AQAAAAIAAYagAAAAEHhDSjmJmINVLVJaYQZRq7X9C/uusNUrqS6SDLZUOILe0kJR80iRU9XfRsQH6DxYXQ==", "17b9cda1-5792-4922-ac7c-15b72005a940" });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518ba", null, "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2bf11d3-1709-4383-8177-124a23b238fb", "AQAAAAIAAYagAAAAEAUlkhP+A6GYIWlR5G+FBEQfs5saJQxQTmgQbIQhMY7wJQ0g2nvo9jr4mv4S/04OOw==", "4c280253-9e0a-41d5-b7b5-3a6b0557521f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bc907e7-cef2-413f-a4e5-df53dcc5a87d", "AQAAAAIAAYagAAAAECHRXBsylenobCgFv/T2YTo0zX9hoJm1LZVWccwKH5iFmyeIGpM1oVce95BUDbHQKQ==", "d540a121-15a2-435d-9606-6909b3279556" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518ba", "2781efa7-66dc-47f0-860f-e506d04102e4" });
        }
    }
}
