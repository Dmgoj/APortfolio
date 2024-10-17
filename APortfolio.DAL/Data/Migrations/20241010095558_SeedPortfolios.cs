using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APortfolio.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPortfolios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 10, 11, 55, 55, 876, DateTimeKind.Local).AddTicks(3270), "This is the description for Portfolio 1", "Portfolio 1", "c2c38126-c0ff-46c1-8fc5-23fb21ec07ed" },
                    { 2, new DateTime(2024, 10, 10, 11, 55, 55, 876, DateTimeKind.Local).AddTicks(3313), "This is the description for Portfolio 2", "Portfolio 2", "c2c38126-c0ff-46c1-8fc5-23fb21ec07ed" },
                    { 3, new DateTime(2024, 10, 10, 11, 55, 55, 876, DateTimeKind.Local).AddTicks(3316), "This is the description for Portfolio 3", "Portfolio 3", "c2c38126-c0ff-46c1-8fc5-23fb21ec07ed" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
