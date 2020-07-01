using Microsoft.EntityFrameworkCore.Migrations;

namespace If.Itc.Integrations.Web.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Integrations_Systems_SystemCode1",
                table: "Integrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Systems",
                table: "Systems");

            migrationBuilder.DropIndex(
                name: "IX_Integrations_SystemCode1",
                table: "Integrations");

            migrationBuilder.DropColumn(
                name: "SystemCode",
                table: "Systems");

            migrationBuilder.DropColumn(
                name: "SystemCode",
                table: "Integrations");

            migrationBuilder.DropColumn(
                name: "SystemCode1",
                table: "Integrations");

            migrationBuilder.AddColumn<string>(
                name: "AssetCode",
                table: "Systems",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssetCode",
                table: "Integrations",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssetCode1",
                table: "Integrations",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Systems",
                table: "Systems",
                column: "AssetCode");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_AssetCode1",
                table: "Integrations",
                column: "AssetCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations_Systems_AssetCode1",
                table: "Integrations",
                column: "AssetCode1",
                principalTable: "Systems",
                principalColumn: "AssetCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Integrations_Systems_AssetCode1",
                table: "Integrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Systems",
                table: "Systems");

            migrationBuilder.DropIndex(
                name: "IX_Integrations_AssetCode1",
                table: "Integrations");

            migrationBuilder.DropColumn(
                name: "AssetCode",
                table: "Systems");

            migrationBuilder.DropColumn(
                name: "AssetCode",
                table: "Integrations");

            migrationBuilder.DropColumn(
                name: "AssetCode1",
                table: "Integrations");

            migrationBuilder.AddColumn<string>(
                name: "SystemCode",
                table: "Systems",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SystemCode",
                table: "Integrations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SystemCode1",
                table: "Integrations",
                type: "nvarchar(8)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Systems",
                table: "Systems",
                column: "SystemCode");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_SystemCode1",
                table: "Integrations",
                column: "SystemCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Integrations_Systems_SystemCode1",
                table: "Integrations",
                column: "SystemCode1",
                principalTable: "Systems",
                principalColumn: "SystemCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
