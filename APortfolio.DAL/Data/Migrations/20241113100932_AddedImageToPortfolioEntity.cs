using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APortfolio.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageToPortfolioEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Portfolios",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7100), "/images/projects/default.jpeg" });

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7158), "/images/projects/default.jpeg" });

            migrationBuilder.UpdateData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Image" },
                values: new object[] { new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7161), "/images/projects/default.jpeg" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 13, 11, 9, 29, 821, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Portfolios");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Portfolios",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
