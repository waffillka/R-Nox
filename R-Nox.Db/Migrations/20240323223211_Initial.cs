using System;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace R_Nox.Db.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "assembly",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assembly", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "module",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    AssemblyId = table.Column<Guid>(type: "uuid", nullable: false),
                    type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_module", x => x.id);
                    table.ForeignKey(
                        name: "FK_module_assembly_AssemblyId",
                        column: x => x.AssemblyId,
                        principalTable: "assembly",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "telemetry",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    telemetry = table.Column<JsonElement>(type: "jsonb", nullable: false),
                    timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    module_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telemetry", x => x.id);
                    table.ForeignKey(
                        name: "FK_telemetry_module_module_id",
                        column: x => x.module_id,
                        principalTable: "module",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_module_AssemblyId",
                table: "module",
                column: "AssemblyId");

            migrationBuilder.CreateIndex(
                name: "IX_telemetry_module_id",
                table: "telemetry",
                column: "module_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "telemetry");

            migrationBuilder.DropTable(
                name: "module");

            migrationBuilder.DropTable(
                name: "assembly");
        }
    }
}
