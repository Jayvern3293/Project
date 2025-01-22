using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5247d952-d24f-46e7-8f9c-ca305fb3c384", "AQAAAAIAAYagAAAAELlFf+sFzz0/1txcAi0BgXXDjEF+s+OXFS8SwKnNRhub/VfIVBsHyo89g6xB7sYD4g==", "8ce4ffaf-1737-4221-9b49-341ae63e39ce" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49ccbf15-e86a-4f97-b30c-259305439a3a", "AQAAAAIAAYagAAAAEDA/Oq7ixEkozM/Hc1oRvM7L3ZmzvkDv4mqCcbxHZjjytvjFtEeZAvr/9YzpSvdsxA==", "4c69ee4a-1522-473e-a256-b910e062e3c5" });
        }
    }
}
