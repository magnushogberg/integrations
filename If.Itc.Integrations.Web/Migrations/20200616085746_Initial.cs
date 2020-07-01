using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace If.Itc.Integrations.Web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Environments",
                columns: table => new
                {
                    EnvironmentCode = table.Column<string>(maxLength: 5, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Environments", x => x.EnvironmentCode);
                });

            migrationBuilder.CreateTable(
                name: "Protocols",
                columns: table => new
                {
                    ProtocolCode = table.Column<string>(maxLength: 8, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocols", x => x.ProtocolCode);
                });

            migrationBuilder.CreateTable(
                name: "Systems",
                columns: table => new
                {
                    SystemCode = table.Column<string>(maxLength: 8, nullable: false),
                    SystemName = table.Column<string>(maxLength: 150, nullable: true),
                    ResponsibleEmail = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systems", x => x.SystemCode);
                });

            migrationBuilder.CreateTable(
                name: "Integrations",
                columns: table => new
                {
                    IntegrationId = table.Column<Guid>(nullable: false),
                    SystemCode = table.Column<string>(maxLength: 8, nullable: true),
                    EnvironmentCode = table.Column<string>(maxLength: 5, nullable: true),
                    IntegrationName = table.Column<string>(maxLength: 50, nullable: true),
                    CallerSenderCode = table.Column<string>(maxLength: 8, nullable: true),
                    ProviderReceiverCode = table.Column<string>(maxLength: 8, nullable: true),
                    ProtocolCode = table.Column<string>(maxLength: 8, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    DataObject = table.Column<string>(maxLength: 150, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    Updated = table.Column<DateTime>(maxLength: 150, nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    SystemCode1 = table.Column<string>(nullable: true),
                    ProtocolCode1 = table.Column<string>(nullable: true),
                    EnvironmentCode1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integrations", x => x.IntegrationId);
                    table.ForeignKey(
                        name: "FK_Integrations_Environments_EnvironmentCode1",
                        column: x => x.EnvironmentCode1,
                        principalTable: "Environments",
                        principalColumn: "EnvironmentCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Integrations_Protocols_ProtocolCode1",
                        column: x => x.ProtocolCode1,
                        principalTable: "Protocols",
                        principalColumn: "ProtocolCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Integrations_Systems_SystemCode1",
                        column: x => x.SystemCode1,
                        principalTable: "Systems",
                        principalColumn: "SystemCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_EnvironmentCode1",
                table: "Integrations",
                column: "EnvironmentCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_ProtocolCode1",
                table: "Integrations",
                column: "ProtocolCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Integrations_SystemCode1",
                table: "Integrations",
                column: "SystemCode1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Integrations");

            migrationBuilder.DropTable(
                name: "Environments");

            migrationBuilder.DropTable(
                name: "Protocols");

            migrationBuilder.DropTable(
                name: "Systems");
        }
    }
}
