using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class Bean : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a956b93-c737-4f71-b4ed-4b3faf2f0b8c", "AQAAAAIAAYagAAAAEAjiXy/NRYsWj8jFzj8evw1ujwp8MDLqb+KNyQCbC1+OsMTJkXcxwcd3IALRBFC6kg==", "b6044b1e-7e76-41dd-b153-e68a59aa948c" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "PetId",
                keyValue: 2,
                column: "Species",
                value: "Monitor Lizard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88998058-62cc-4cec-9075-b621720126c9", "AQAAAAIAAYagAAAAEBK4N65pbn0DeFRtuFcXgWjdhK5wabV4WNfb0Z1IqGldL6J+6+emrlCnrPA/7Jbs6A==", "c4edc01c-55e5-44fe-9703-05742b73f6af" });

            migrationBuilder.UpdateData(
                table: "Pet",
                keyColumn: "PetId",
                keyValue: 2,
                column: "Species",
                value: "Lizard");
        }
    }
}
