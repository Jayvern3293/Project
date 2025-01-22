using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
