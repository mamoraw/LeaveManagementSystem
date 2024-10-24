using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b0ca64d-f877-4dd5-8944-edf7551a967e",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35814009-9b9d-48b0-aed2-f2e602567720", new DateOnly(1950, 12, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEJrD1f0g4bPZCLFHN+rlxfEbsJgTY2BTNAgB8m60q5w0pXVqOxiXoi7jZ7XdN2m7jg==", "4d3de87c-8138-420a-9634-b4089b6c4085" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b0ca64d-f877-4dd5-8944-edf7551a967e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "107fc9fa-45e3-4a9a-b1e4-2b49d8959633", "AQAAAAIAAYagAAAAECVCHvUV6NuZGAeNM1dT2zrXz3HvOUMvcHK5Ax+A1OSSV/HP23dN+RTApE8Ay510AQ==", "c8945c28-d4d8-485f-9c97-0ed951cc5382" });
        }
    }
}
