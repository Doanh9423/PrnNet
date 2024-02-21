using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestIdentity2.Migrations
{
    /// <inheritdoc />
    public partial class addDataForRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "465c4268-5365-40fb-b3fc-b1e5a02a3bae", null, "seller", "seller" },
                    { "912936de-3a7d-4685-950d-3afd0a29b9fe", null, "client", "client" },
                    { "fed914da-3dd5-4b17-b206-7fb2f5cc4650", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "465c4268-5365-40fb-b3fc-b1e5a02a3bae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "912936de-3a7d-4685-950d-3afd0a29b9fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fed914da-3dd5-4b17-b206-7fb2f5cc4650");
        }
    }
}
