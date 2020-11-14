using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace localizaBaba.Web.Migrations
{
    public partial class criaçãodasclasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("3a3f6040-b4bf-4e55-adde-6fad5b985933"));

            migrationBuilder.AddColumn<string>(
                name: "SobreNome",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Babas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    SobreNome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Babas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    SobreNome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Babas",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { new Guid("5f290abb-1d4e-4cc9-9b5b-e9d0fc675ee0"), "baba@baba.com", "Novo Baba", "123456", null });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { new Guid("1544abf6-beb5-4928-93d2-96007a0915c5"), "cliente@cliente.com", "Novo Cliente", "123456", null });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "Senha", "SobreNome" },
                values: new object[] { new Guid("121ff2ca-ae86-4921-a7b4-2334fdf613df"), "luiz@rkcomex.com", "Luiz", "123456", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Babas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("121ff2ca-ae86-4921-a7b4-2334fdf613df"));

            migrationBuilder.DropColumn(
                name: "SobreNome",
                table: "Usuarios");

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "Nome", "Senha" },
                values: new object[] { new Guid("3a3f6040-b4bf-4e55-adde-6fad5b985933"), "luiz@rkcomex.com", "Luiz", "123456" });
        }
    }
}
