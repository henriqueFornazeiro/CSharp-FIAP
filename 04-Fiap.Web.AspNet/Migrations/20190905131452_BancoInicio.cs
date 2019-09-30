using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _04_Fiap.Web.AspNet.Migrations
{
    public partial class BancoInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table_Serie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nm_serie = table.Column<string>(maxLength: 50, nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    DataLancamento = table.Column<DateTime>(nullable: false),
                    Temporada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PriK_T_Serie", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Serie");
        }
    }
}
