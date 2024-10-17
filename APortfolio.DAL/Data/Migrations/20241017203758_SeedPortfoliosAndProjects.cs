using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APortfolio.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPortfoliosAndProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "PortfolioId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1382), "Project #1 Portfolio #1", "/images/projects/project1.jpeg", 1, "Project #1" },
                    { 2, new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1386), "Project #2 Portfolio #1", "/images/projects/project2.jpeg", 1, "Project #2" },
                    { 3, new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1388), "Project #3 Portfolio #1", "/images/projects/project3.jpeg", 1, "Project #3" },
                    { 4, new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1391), "Project #1 Portfolio #2", "/images/projects/project4.jpeg", 2, "Project #1" },
                    { 5, new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1393), "Project #2 Portfolio #2", "/images/projects/project5.jpeg", 2, "Project #2" },
                    { 6, new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1395), "Project #1 Portfolio #3", "/images/projects/project6.jpeg", 3, "Project #1" },
                    { 7, new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1397), "Project #2 Portfolio #3", "/images/projects/project7.jpeg", 3, "Project #2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 11, 55, 55, 876, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 11, 55, 55, 876, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 10, 11, 55, 55, 876, DateTimeKind.Local).AddTicks(3316));
        }
    }
}
