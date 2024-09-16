using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APortfolio.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakeBioAndAddressInAppUserNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Project_ProjectId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolio_AspNetUsers_UserId",
                table: "Portfolio");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Portfolio_PortfolioId",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Media",
                table: "Media");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Portfolio",
                newName: "Portfolios");

            migrationBuilder.RenameTable(
                name: "Media",
                newName: "Medias");

            migrationBuilder.RenameIndex(
                name: "IX_Project_PortfolioId",
                table: "Projects",
                newName: "IX_Projects_PortfolioId");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolio_UserId",
                table: "Portfolios",
                newName: "IX_Portfolios_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Media_ProjectId",
                table: "Medias",
                newName: "IX_Medias_ProjectId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medias",
                table: "Medias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_Projects_ProjectId",
                table: "Medias",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Portfolios_PortfolioId",
                table: "Projects",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_Projects_ProjectId",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_AspNetUsers_UserId",
                table: "Portfolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Portfolios_PortfolioId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Portfolios",
                table: "Portfolios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medias",
                table: "Medias");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Portfolios",
                newName: "Portfolio");

            migrationBuilder.RenameTable(
                name: "Medias",
                newName: "Media");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_PortfolioId",
                table: "Project",
                newName: "IX_Project_PortfolioId");

            migrationBuilder.RenameIndex(
                name: "IX_Portfolios_UserId",
                table: "Portfolio",
                newName: "IX_Portfolio_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_ProjectId",
                table: "Media",
                newName: "IX_Media_ProjectId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Portfolio",
                table: "Portfolio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Media",
                table: "Media",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Project_ProjectId",
                table: "Media",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolio_AspNetUsers_UserId",
                table: "Portfolio",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Portfolio_PortfolioId",
                table: "Project",
                column: "PortfolioId",
                principalTable: "Portfolio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
