using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace Cadastro.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.id);
                });
            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estadoid = table.Column<int>(nullable: true),
                    nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_Estadoid",
                        column: x => x.Estadoid,
                        principalTable: "Estado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    cep = table.Column<string>(nullable: true),
                    cidadeid = table.Column<int>(nullable: false),
                    complemento = table.Column<string>(nullable: true),
                    cpfCnpj = table.Column<string>(nullable: true),
                    dataNascimento = table.Column<DateTime>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    logradouro = table.Column<string>(nullable: true),
                    nome = table.Column<string>(nullable: true),
                    numero = table.Column<string>(nullable: true),
                    rgIe = table.Column<string>(nullable: true),
                    telefonePrincipal = table.Column<string>(nullable: true),
                    telefoneSecundario = table.Column<string>(nullable: true),
                    tipoPessoa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cliente_Cidade_cidadeid",
                        column: x => x.cidadeid,
                        principalTable: "Cidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Cliente");
            migrationBuilder.DropTable("Cidade");
            migrationBuilder.DropTable("Estado");
        }
    }
}
