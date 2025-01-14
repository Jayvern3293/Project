using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class PetSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pet",
                columns: new[] { "PetId", "Age", "Colour", "Gender", "Name", "OrganizationId", "Species" },
                values: new object[,]
                {
                    { 1, 5, "White", "Unspecified", "Kohaku", 1, "Dog" },
                    { 2, 1, "Brown", "Male", "Bean", 0, "Lizard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pet",
                keyColumn: "PetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pet",
                keyColumn: "PetId",
                keyValue: 2);
        }
    }
}
