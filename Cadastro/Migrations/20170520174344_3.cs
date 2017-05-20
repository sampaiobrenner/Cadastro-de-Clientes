using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cadastro.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Cidade_Estado_estadoid", table: "Cidade");
            migrationBuilder.DropForeignKey(name: "FK_Cliente_Cidade_cidadeid", table: "Cliente");
            migrationBuilder.AddColumn<string>(
                name: "sigla",
                table: "Estado",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Estado_estadoid",
                table: "Cidade",
                column: "estadoid",
                principalTable: "Estado",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Cidade_cidadeid",
                table: "Cliente",
                column: "cidadeid",
                principalTable: "Cidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Cidade_Estado_estadoid", table: "Cidade");
            migrationBuilder.DropForeignKey(name: "FK_Cliente_Cidade_cidadeid", table: "Cliente");
            migrationBuilder.DropColumn(name: "sigla", table: "Estado");
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
        }
    }
}
