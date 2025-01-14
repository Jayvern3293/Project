using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class PetUserSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Address", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "123 Test Street", "johnbork1@gmail.com", "John Bork" },
                    { 2, "555 Haight Street", "ortizpapi@gmail.com", "Big Papi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);
        }
    }
}
