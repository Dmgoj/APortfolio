using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APortfolio.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class DefaultedCreatedDateInPortfolioModelAndMadeProjectsNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 386, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 386, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 386, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 387, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 387, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 387, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 387, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 387, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 387, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 20, 20, 27, 55, 387, DateTimeKind.Local).AddTicks(41));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 17, 22, 37, 56, 672, DateTimeKind.Local).AddTicks(1397));
        }
    }
}
