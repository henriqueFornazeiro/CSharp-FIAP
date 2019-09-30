using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _05_Fiap.Web.AspNet.Migrations
{
    public partial class BancoCondominioInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Condominio",
                columns: table => new
                {
                    CondominioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nm_Condominio = table.Column<string>(nullable: true),
                    Qtd_Blocos = table.Column<int>(nullable: false),
                    Ds_Ativo = table.Column<bool>(nullable: false),
                    Ds_Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Condominio", x => x.CondominioId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Condominio");
        }
    }
}
