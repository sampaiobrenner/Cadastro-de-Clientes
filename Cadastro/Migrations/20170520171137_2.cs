using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace Cadastro.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Cidade_Estado_Estadoid", table: "Cidade");
            migrationBuilder.DropForeignKey(name: "FK_Cliente_Cidade_cidadeid", table: "Cliente");
            migrationBuilder.AlterColumn<int>(
                name: "Estadoid",
                table: "Cidade",
                nullable: false);
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
            migrationBuilder.RenameColumn(
                name: "Estadoid",
                table: "Cidade",
                newName: "estadoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Cidade_Estado_estadoid", table: "Cidade");
            migrationBuilder.DropForeignKey(name: "FK_Cliente_Cidade_cidadeid", table: "Cliente");
            migrationBuilder.AlterColumn<int>(
                name: "estadoid",
                table: "Cidade",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Cidade_Estado_Estadoid",
                table: "Cidade",
                column: "Estadoid",
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
                name: "estadoid",
                table: "Cidade",
                newName: "Estadoid");
        }
    }
}
