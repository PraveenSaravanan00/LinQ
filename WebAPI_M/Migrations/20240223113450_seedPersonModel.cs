using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAPI_M.Migrations
{
    /// <inheritdoc />
    public partial class seedPersonModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonModels",
                columns: new[] { "personId", "CreatedTime", "age", "personName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 23, 17, 4, 50, 431, DateTimeKind.Local).AddTicks(2042), 21, "Praveen" },
                    { 2, new DateTime(2024, 2, 23, 17, 4, 50, 431, DateTimeKind.Local).AddTicks(2055), 23, "Sandy" },
                    { 3, new DateTime(2024, 2, 23, 17, 4, 50, 431, DateTimeKind.Local).AddTicks(2057), 22, "Vikram" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 3);
        }
    }
}
