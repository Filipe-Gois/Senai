using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi_inlock_codefirst.Migrations
{
    /// <inheritdoc />
    public partial class BD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudio",
                columns: table => new
                {
                    IdEstudio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeEstudio = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudio", x => x.IdEstudio);
                });

            migrationBuilder.CreateTable(
                name: "TiposUsuario",
                columns: table => new
                {
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TituloTipoUsuario = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposUsuario", x => x.IdTipoUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    IdJogo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeJogo = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "DATE", nullable: false),
                    PrecoJogo = table.Column<decimal>(type: "DECIMAL(4,2)", nullable: false),
                    IdEstudio = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.IdJogo);
                    table.ForeignKey(
                        name: "FK_Jogo_Estudio_IdEstudio",
                        column: x => x.IdEstudio,
                        principalTable: "Estudio",
                        principalColumn: "IdEstudio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeUsuario = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    EmailUsuario = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    SenhaUsuario = table.Column<string>(type: "VARCHAR(60)", maxLength: 60, nullable: false),
                    IdTipoUsuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                    table.ForeignKey(
                        name: "FK_Usuario_TiposUsuario_IdTipoUsuario",
                        column: x => x.IdTipoUsuario,
                        principalTable: "TiposUsuario",
                        principalColumn: "IdTipoUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_IdEstudio",
                table: "Jogo",
                column: "IdEstudio");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_EmailUsuario",
                table: "Usuario",
                column: "EmailUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdTipoUsuario",
                table: "Usuario",
                column: "IdTipoUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Estudio");

            migrationBuilder.DropTable(
                name: "TiposUsuario");
        }
    }
}
