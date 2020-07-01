using Microsoft.EntityFrameworkCore.Migrations;

namespace If.Itc.Integrations.Web.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Integrations_Systems_AssetCode1",
                table: "Integrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Systems",
                table: "Systems");

            migrationBuilder.DropColumn(
                name: "SystemName",
                table: "Systems");

            migrationBuilder.RenameTable(
                name: "Systems",
                newName: "Assets");

            migrationBuilder.AddColumn<string>(
                name: "AssetName",
                table: "Assets",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "AssetCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations_Assets_AssetCode1",
                table: "Integrations",
                column: "AssetCode1",
                principalTable: "Assets",
                principalColumn: "AssetCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Integrations_Assets_AssetCode1",
                table: "Integrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "AssetName",
                table: "Assets");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "Systems");

            migrationBuilder.AddColumn<string>(
                name: "SystemName",
                table: "Systems",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Systems",
                table: "Systems",
                column: "AssetCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations_Systems_AssetCode1",
                table: "Integrations",
                column: "AssetCode1",
                principalTable: "Systems",
                principalColumn: "AssetCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
