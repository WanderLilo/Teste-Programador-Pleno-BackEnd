using Microsoft.EntityFrameworkCore.Migrations;

namespace tarefa_2.Infrastructure.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ESTADOS",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CIDADES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    EstadoId = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIDADES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CIDADES_ESTADOS_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "ESTADOS",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CIDADES_EstadoId",
                table: "CIDADES",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CIDADES_Nome",
                table: "CIDADES",
                column: "Nome");

            migrationBuilder.CreateIndex(
                name: "IX_ESTADOS_Nome",
                table: "ESTADOS",
                column: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CIDADES");

            migrationBuilder.DropTable(
                name: "ESTADOS");
        }
    }
}
