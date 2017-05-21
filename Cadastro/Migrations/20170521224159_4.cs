using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cadastro.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Cidade_Estado_estadoid", table: "Cidade");
            migrationBuilder.DropForeignKey(name: "FK_Cliente_Cidade_cidadeid", table: "Cliente");
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Cliente",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Estado_EstadoId",
                table: "Cidade",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Cidade_CidadeId",
                table: "Cliente",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.RenameColumn(
                name: "sigla",
                table: "Estado",
                newName: "Sigla");
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Estado",
                newName: "Nome");
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Estado",
                newName: "Id");
            migrationBuilder.RenameColumn(
                name: "tipoPessoa",
                table: "Cliente",
                newName: "TipoPessoa");
            migrationBuilder.RenameColumn(
                name: "telefoneSecundario",
                table: "Cliente",
                newName: "TelefoneSecundario");
            migrationBuilder.RenameColumn(
                name: "telefonePrincipal",
                table: "Cliente",
                newName: "TelefonePrincipal");
            migrationBuilder.RenameColumn(
                name: "rgIe",
                table: "Cliente",
                newName: "RgIe");
            migrationBuilder.RenameColumn(
                name: "numero",
                table: "Cliente",
                newName: "Numero");
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");
            migrationBuilder.RenameColumn(
                name: "logradouro",
                table: "Cliente",
                newName: "Logradouro");
            migrationBuilder.RenameColumn(
                name: "email",
                table: "Cliente",
                newName: "Email");
            migrationBuilder.RenameColumn(
                name: "dataNascimento",
                table: "Cliente",
                newName: "DataNascimento");
            migrationBuilder.RenameColumn(
                name: "cpfCnpj",
                table: "Cliente",
                newName: "CpfCnpj");
            migrationBuilder.RenameColumn(
                name: "complemento",
                table: "Cliente",
                newName: "Complemento");
            migrationBuilder.RenameColumn(
                name: "cidadeid",
                table: "Cliente",
                newName: "CidadeId");
            migrationBuilder.RenameColumn(
                name: "cep",
                table: "Cliente",
                newName: "Cep");
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cliente",
                newName: "Id");
            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cidade",
                newName: "Nome");
            migrationBuilder.RenameColumn(
                name: "estadoid",
                table: "Cidade",
                newName: "EstadoId");
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cidade",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Cidade_Estado_EstadoId", table: "Cidade");
            migrationBuilder.DropForeignKey(name: "FK_Cliente_Cidade_CidadeId", table: "Cliente");
            migrationBuilder.DropColumn(name: "Bairro", table: "Cliente");
            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Estado_estadoid",
                table: "Cidade",
                column: "estadoid",
                principalTable: "Estado",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Cidade_cidadeid",
                table: "Cliente",
                column: "cidadeid",
                principalTable: "Cidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.RenameColumn(
                name: "Sigla",
                table: "Estado",
                newName: "sigla");
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Estado",
                newName: "nome");
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Estado",
                newName: "id");
            migrationBuilder.RenameColumn(
                name: "TipoPessoa",
                table: "Cliente",
                newName: "tipoPessoa");
            migrationBuilder.RenameColumn(
                name: "TelefoneSecundario",
                table: "Cliente",
                newName: "telefoneSecundario");
            migrationBuilder.RenameColumn(
                name: "TelefonePrincipal",
                table: "Cliente",
                newName: "telefonePrincipal");
            migrationBuilder.RenameColumn(
                name: "RgIe",
                table: "Cliente",
                newName: "rgIe");
            migrationBuilder.RenameColumn(
                name: "Numero",
                table: "Cliente",
                newName: "numero");
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "nome");
            migrationBuilder.RenameColumn(
                name: "Logradouro",
                table: "Cliente",
                newName: "logradouro");
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Cliente",
                newName: "email");
            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Cliente",
                newName: "dataNascimento");
            migrationBuilder.RenameColumn(
                name: "CpfCnpj",
                table: "Cliente",
                newName: "cpfCnpj");
            migrationBuilder.RenameColumn(
                name: "Complemento",
                table: "Cliente",
                newName: "complemento");
            migrationBuilder.RenameColumn(
                name: "CidadeId",
                table: "Cliente",
                newName: "cidadeid");
            migrationBuilder.RenameColumn(
                name: "Cep",
                table: "Cliente",
                newName: "cep");
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "id");
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cidade",
                newName: "nome");
            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "Cidade",
                newName: "estadoid");
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cidade",
                newName: "id");
        }
    }
}
