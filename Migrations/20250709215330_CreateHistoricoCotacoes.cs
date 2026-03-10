using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIIsAnalyzer.Migrations
{
    /// <inheritdoc />
    public partial class CreateHistoricoCotacoes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoricoCotacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FiiId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cotacao = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false),
                    DataReferencia = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoCotacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoCotacoes_FIIs_FiiId",
                        column: x => x.FiiId,
                        principalTable: "FIIs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoCotacoes_FiiId",
                table: "HistoricoCotacoes",
                column: "FiiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoCotacoes");
        }
    }
}
