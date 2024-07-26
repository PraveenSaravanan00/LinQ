using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI_M.Migrations
{
    /// <inheritdoc />
    public partial class seedPersonModelwithCreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 23, 17, 7, 11, 306, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 23, 17, 7, 11, 306, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 23, 17, 7, 11, 306, DateTimeKind.Local).AddTicks(4058));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 23, 17, 4, 50, 431, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 23, 17, 4, 50, 431, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "PersonModels",
                keyColumn: "personId",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 23, 17, 4, 50, 431, DateTimeKind.Local).AddTicks(2057));
        }
    }
}
