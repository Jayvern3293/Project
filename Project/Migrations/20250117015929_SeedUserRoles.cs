using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79df0297-50ce-457b-a85a-8f490dffa2fb", "Sedy", "AQAAAAIAAYagAAAAEIZrWYUIju9d0PG450sPUHx3RW91j/7gUE7hF/ejsJ5/jrwpHEIfGsHOMHqg2rutwA==", "1f222013-6967-4068-90a5-fc1f98cf413d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41547269-8efb-47e2-9e35-71ed65a0c9a0", "AQAAAAIAAYagAAAAEATyUIxPF1TpE9ddgGxOeVZwsAmgGv9HnI6bNtNMN13qLeyZEfq/i45LYJZQywYJ7Q==", "7133414a-eb66-4fe0-b0d3-418c63a7d3e9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3aa6a0f-5499-430c-a950-d4b35a8b6fbc", "Sedys", "AQAAAAIAAYagAAAAEBawJpyZkQ00MfQedCeSHVfB/IsbnQ7VHIcwWgQNUffeAJrMZF1MRvMsaHkoFr+eig==", "bb55500a-86d2-4f0f-bff7-fbf7997739e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51f79cfb-2001-4035-b676-512abd85b907", "AQAAAAIAAYagAAAAECwtcLC43jOSTrqT6IpjW6O91KE+AvI+e8m8Ed1EJWqCrXy2ymSxzwyibwv5EoBG6g==", "2a842ca3-00fb-434f-a086-5bc81b08bfcd" });
        }
    }
}
