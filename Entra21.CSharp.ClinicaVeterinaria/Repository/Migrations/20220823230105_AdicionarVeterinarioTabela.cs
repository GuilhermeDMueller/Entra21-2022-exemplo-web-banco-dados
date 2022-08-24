﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entra21.CSharp.ClinicaVeterinaria.Repositorio.Migrations
{
    public partial class AdicionarVeterinarioTabela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Veterinario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "VARCHAR(30)", maxLength: 30, nullable: false),
                    Crmv = table.Column<string>(type: "VARCHAR(7)", maxLength: 7, nullable: false),
                    Idade = table.Column<int>(type: "INT", nullable: true),
                    Salario = table.Column<decimal>(type: "DECIMAL(9,2)", precision: 9, scale: 2, nullable: false),
                    Empregado = table.Column<bool>(type: "BIT", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Id", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Veterinario",
                columns: new[] { "Id", "Crmv", "Idade", "Nome", "Salario" },
                values: new object[,]
                {
                    { 1, "66666SC", null, "Amanda", 0m },
                    { 2, "89898SC", null, "Gui", 0m }
                });

            migrationBuilder.InsertData(
                table: "racas",
                columns: new[] { "id", "especie", "nome" },
                values: new object[,]
                {
                    { 1, "Gato", "Frajola" },
                    { 2, "Capivara", "Piupiu" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Veterinario");

            migrationBuilder.DeleteData(
                table: "racas",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "racas",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
