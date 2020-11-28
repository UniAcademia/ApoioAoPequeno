using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaDoacoes.Infra.Migrations
{
    public partial class colunaActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "TB_INSTITUICAO_DOADORA",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "TB_INSTITUICAO_ASSISTIDA",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "TB_DOADOR",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "TB_DOACAO",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "ativo",
                table: "TB_ASSISTIDO",
                nullable: false,
                defaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "TB_INSTITUICAO_DOADORA");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "TB_INSTITUICAO_ASSISTIDA");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "TB_DOADOR");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "TB_DOACAO");

            migrationBuilder.DropColumn(
                name: "ativo",
                table: "TB_ASSISTIDO");
        }
    }
}
