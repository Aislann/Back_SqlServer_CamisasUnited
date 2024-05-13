using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace camisas_united.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    NomeEmpresa = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    TituloContato = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CEP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pais = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Celular = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CEP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pais = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimeiroNome = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UltimoNome = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Titulo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    DataContratacao = table.Column<DateTime>(type: "datetime", nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    CEP = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Pais = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Extensao = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Quantidade = table.Column<int>(type: "int", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    UnidadesEstoque = table.Column<int>(type: "int", nullable: true),
                    UnidadesEncomenda = table.Column<int>(type: "int", nullable: true),
                    IdFornecedor = table.Column<int>(type: "int", nullable: true),
                    IdCategoria = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Produto__IdCateg__3F466844",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Produto__IdForne__403A8C7D",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdCategoria",
                table: "Produto",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdFornecedor",
                table: "Produto",
                column: "IdFornecedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
