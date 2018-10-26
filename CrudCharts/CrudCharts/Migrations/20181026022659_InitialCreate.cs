using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudCharts.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Usuario = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoFrete",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UfOrigem = table.Column<string>(nullable: true),
                    UfDestino = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoFrete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rotas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    UfOrigem = table.Column<string>(nullable: false),
                    UfDestino = table.Column<string>(nullable: false),
                    Distancia = table.Column<double>(nullable: false),
                    Preco = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rotas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "PedidoFrete");

            migrationBuilder.DropTable(
                name: "Rotas");
        }
    }
}
